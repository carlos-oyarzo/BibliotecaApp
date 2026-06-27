// ─── Responsable: Carlos — Rol 4 (backend-prestamos) ───
// Servicio de préstamos. Implementa la lógica de negocio de préstamo y devolución de libros.
// Las validaciones de existencia y disponibilidad se lanzan como excepciones para que el
// controlador las traduzca a los códigos HTTP y mensajes originales.

using BibliotecaApp.Data;
using BibliotecaApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApp.Services;

public class LoanService : ILoanService
{
    private readonly BibliotecaContext _context;

    public LoanService(BibliotecaContext context)
    {
        _context = context;
    }

    public async Task<Prestamo> BorrowBookAsync(int bookId, int userId)
    {
        var book = await _context.Books.FindAsync(bookId);
        if (book == null)
        {
            throw new KeyNotFoundException("El libro especificado no existe.");
        }
        if (!book.IsAvailable)
        {
            throw new InvalidOperationException("El libro ya se encuentra prestado.");
        }

        var user = await _context.Users.FindAsync(userId);
        if (user == null)
        {
            throw new KeyNotFoundException("El usuario especificado no existe.");
        }

        var prestamo = new Prestamo
        {
            BookId = bookId,
            UserId = userId,
            LoanDate = DateTime.Now,
            Book = book,
            User = user
        };

        book.IsAvailable = false;

        _context.Prestamos.Add(prestamo);
        await _context.SaveChangesAsync();

        return prestamo;
    }

    public async Task<Prestamo> ReturnBookAsync(int bookId)
    {
        var prestamo = await _context.Prestamos
            .FirstOrDefaultAsync(p => p.BookId == bookId && p.ReturnDate == null);

        if (prestamo == null)
        {
            throw new KeyNotFoundException("No se encontró ningún préstamo activo para este libro.");
        }

        var book = await _context.Books.FindAsync(bookId);
        if (book != null)
        {
            book.IsAvailable = true;
        }

        prestamo.ReturnDate = DateTime.Now;

        await _context.SaveChangesAsync();
        return prestamo;
    }
}