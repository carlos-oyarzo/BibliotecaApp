using BibliotecaApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApp.Services;

// =============================================
// LÓGICA DE PRÉSTAMOS — Responsable: Carlos (Rol 4)
// =============================================
// Implementa ILoanService con toda la lógica de negocio de préstamos.
//
// Decisiones de diseño:
//   - Recibe DbContext por constructor (inyección de dependencias).
//     Esto permite usar MySQL en producción y InMemory en tests
//     sin cambiar NADA del servicio. Mismo código, distinta BD.
//
//   - Usa DbContext.Set<T>() en vez de propiedades tipadas para no
//     acoplarse a un DbContext concreto. Así funciona con cualquier
//     DbContext que tenga Users, Books y Loans.
//
//   - Las validaciones lanzan InvalidOperationException con mensajes
//     en español porque el frontend puede mostrarlos directo al usuario.
//
// Reglas de negocio:
//   1. Solo se prestan libros marcados como disponibles (IsAvailable = true)
//   2. El préstamo vence a los 15 días corridos
//   3. Un libro devuelto vuelve a estar disponible inmediatamente
//   4. No se puede devolver dos veces el mismo préstamo
// =============================================

public class LoanService : ILoanService
{
    private readonly DbContext _context;

    public LoanService(DbContext context)
    {
        _context = context;
    }

    public Loan BorrowBook(int userId, int bookId)
    {
        // Validar que el usuario existe
        var user = _context.Set<User>().Find(userId)
            ?? throw new InvalidOperationException("El usuario no existe.");

        // Validar que el libro existe
        var book = _context.Set<Book>().Find(bookId)
            ?? throw new InvalidOperationException("El libro no existe.");

        // Validar disponibilidad (regla de negocio #1)
        if (!book.IsAvailable)
            throw new InvalidOperationException("El libro no está disponible.");

        // Marcar libro como prestado (regla de negocio #3: se revierte en ReturnBook)
        book.IsAvailable = false;

        var loan = new Loan
        {
            UserId = userId,
            BookId = bookId,
            LoanDate = DateTime.Now,
            DueDate = DateTime.Now.AddDays(15),   // Regla de negocio #2
            ReturnDate = null                      // null = préstamo activo
        };

        _context.Set<Loan>().Add(loan);
        _context.SaveChanges();

        return loan;
    }

    public void ReturnBook(int loanId)
    {
        // Include(Book) para poder acceder a loan.Book y marcarlo disponible
        var loan = _context.Set<Loan>()
            .Include(l => l.Book)
            .FirstOrDefault(l => l.Id == loanId)
            ?? throw new InvalidOperationException("El préstamo no existe.");

        // Regla de negocio #4: no devolver dos veces
        if (loan.ReturnDate != null)
            throw new InvalidOperationException("El préstamo ya fue devuelto.");

        // Registrar devolución
        loan.ReturnDate = DateTime.Now;

        // Regla de negocio #3: liberar el libro
        loan.Book.IsAvailable = true;

        _context.SaveChanges();
    }

    public List<Loan> GetOverdueLoans()
    {
        // Préstamos vencidos: DueDate ya pasó Y ReturnDate sigue null
        return _context.Set<Loan>()
            .Include(l => l.User)    // Para mostrar nombre de usuario en la UI
            .Include(l => l.Book)    // Para mostrar título del libro en la UI
            .Where(l => l.ReturnDate == null && l.DueDate < DateTime.Now)
            .ToList();
    }

    public List<Loan> GetActiveLoansByUser(int userId)
    {
        // Préstamos activos de un usuario: ReturnDate es null
        return _context.Set<Loan>()
            .Include(l => l.Book)    // Para mostrar qué libros tiene
            .Where(l => l.UserId == userId && l.ReturnDate == null)
            .ToList();
    }
}
