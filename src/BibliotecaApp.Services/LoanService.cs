using BibliotecaApp.Data;
using BibliotecaApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApp.Services;

// =============================================
// MODELO COMPARTIDO — Responsable: Charly (Rol 4)
// =============================================
// Implementación del servicio de préstamos. Contiene las reglas de negocio
// para prestar y devolver libros, y las consultas de préstamos activos/vencidos.
// El préstamo máximo por usuario es 2 y el plazo de vencimiento es de 14 días.
// =============================================

public class LoanService : ILoanService
{
    private readonly AppDbContext _context;

    // Cantidad máxima de préstamos activos permitidos por usuario.
    private const int MaxActiveLoansPerUser = 2;

    // Días de plazo para devolver un libro desde la fecha de préstamo.
    private const int LoanDurationDays = 14;

    public LoanService(AppDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Devuelve todos los préstamos activos (ReturnDate == null) con libro
    /// y usuario cargados de forma anticipada.
    /// </summary>
    public async Task<IEnumerable<Loan>> GetActiveLoans()
    {
        return await _context.Loans
            .Where(l => l.ReturnDate == null)
            .Include(l => l.Book)
            .Include(l => l.User)
            .ToListAsync();
    }

    /// <summary>
    /// Devuelve los préstamos activos cuya fecha de vencimiento ya pasó
    /// (DueDate anterior a la fecha actual UTC), con libro y usuario cargados.
    /// </summary>
    public async Task<IEnumerable<Loan>> GetOverdueLoans()
    {
        return await _context.Loans
            .Where(l => l.ReturnDate == null && l.DueDate < DateTime.UtcNow)
            .Include(l => l.Book)
            .Include(l => l.User)
            .ToListAsync();
    }

    /// <summary>
    /// Presta un libro a un usuario. Aplica las reglas de negocio:
    ///   - El usuario no puede tener 2 o más préstamos activos.
    ///   - El libro no puede tener un préstamo activo pendiente de devolución.
    /// Crea el préstamo con LoanDate = ahora (UTC), DueDate = ahora + 14 días.
    /// </summary>
    public async Task<Loan> BorrowBook(int userId, int bookId)
    {
        // Guarda: ¿el usuario ya alcanzó el límite de préstamos activos?
        var activeLoansCount = await _context.Loans
            .CountAsync(l => l.UserId == userId && l.ReturnDate == null);

        if (activeLoansCount >= MaxActiveLoansPerUser)
        {
            throw new InvalidOperationException("El usuario ya tiene 2 préstamos activos.");
        }

        // Guarda: ¿el libro tiene un préstamo activo pendiente de devolución?
        var bookHasActiveLoan = await _context.Loans
            .AnyAsync(l => l.BookId == bookId && l.ReturnDate == null);

        if (bookHasActiveLoan)
        {
            throw new InvalidOperationException("El libro no está disponible.");
        }

        // Carga el libro para marcarlo como no disponible.
        var book = await _context.Books.FindAsync(bookId)
            ?? throw new KeyNotFoundException("Libro no encontrado.");

        // Crea el préstamo con los campos calculados por el servicio (política, no datos).
        var loan = new Loan
        {
            BookId = bookId,
            UserId = userId,
            LoanDate = DateTime.UtcNow,
            DueDate = DateTime.UtcNow.AddDays(LoanDurationDays),
            ReturnDate = null
        };

        book.IsAvailable = false;
        _context.Loans.Add(loan);
        await _context.SaveChangesAsync();

        return loan;
    }

    /// <summary>
    /// Registra la devolución de un préstamo activo. Fija ReturnDate a la fecha
    /// actual (UTC) y marca el libro asociado como disponible nuevamente.
    /// </summary>
    public async Task ReturnBook(int loanId)
    {
        // Busca el préstamo activo (sin devolución) por id, incluyendo el libro.
        var loan = await _context.Loans
            .Include(l => l.Book)
            .FirstOrDefaultAsync(l => l.Id == loanId && l.ReturnDate == null);

        if (loan == null)
        {
            throw new KeyNotFoundException("Préstamo no encontrado.");
        }

        // Registra la devolución y libera el libro asociado.
        loan.ReturnDate = DateTime.UtcNow;

        if (loan.Book is not null)
        {
            loan.Book.IsAvailable = true;
        }

        await _context.SaveChangesAsync();
    }
}