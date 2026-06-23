using BibliotecaApp.Domain;

namespace BibliotecaApp.Services;

// =============================================
// CONTRATO DE PRÉSTAMOS — Responsable: Carlos (Rol 4)
// =============================================
// Interfaz que define todas las operaciones de préstamos.
// 
// ¿Por qué una interfaz?
//   - El frontend (WinForms) consume ILoanService, no LoanService.
//     Así si cambia la implementación, el frontend no se rompe.
//   - Los tests pueden mockear esta interfaz si hace falta.
//   - Rol 2 (frontend) solo necesita conocer estos métodos, no cómo funcionan.
//
// Métodos:
//   BorrowBook      → prestar un libro (valida disponibilidad)
//   ReturnBook      → devolver un libro (libera el ejemplar)
//   GetOverdueLoans → listar préstamos vencidos (para multas/reclamos)
//   GetActiveLoansByUser → consultar qué libros tiene prestados un usuario
// =============================================

public interface ILoanService
{
    /// <summary>
    /// Presta un libro a un usuario. Valida que el usuario exista y
    /// que el libro esté disponible. Establece vencimiento a 15 días.
    /// </summary>
    /// <returns>El préstamo creado con todos sus datos.</returns>
    /// <exception cref="InvalidOperationException">Si el usuario no existe o el libro no está disponible.</exception>
    Loan BorrowBook(int userId, int bookId);

    /// <summary>
    /// Registra la devolución de un préstamo. Marca el libro como disponible.
    /// </summary>
    /// <exception cref="InvalidOperationException">Si el préstamo no existe o ya fue devuelto.</exception>
    void ReturnBook(int loanId);

    /// <summary>
    /// Obtiene todos los préstamos cuya fecha de vencimiento ya pasó
    /// y que todavía no fueron devueltos.
    /// </summary>
    List<Loan> GetOverdueLoans();

    /// <summary>
    /// Obtiene los préstamos activos (no devueltos) de un usuario específico.
    /// </summary>
    List<Loan> GetActiveLoansByUser(int userId);
}
