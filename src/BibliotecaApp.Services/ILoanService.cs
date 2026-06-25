using BibliotecaApp.Domain;

namespace BibliotecaApp.Services;

// =============================================
// MODELO COMPARTIDO — Responsable: Charly (Rol 4)
// =============================================
// Contrato del servicio de préstamos. Define las operaciones disponibles
// para gestionar préstamos de libros: prestar, devolver y consultar.
// =============================================

public interface ILoanService
{
    /// <summary>
    /// Devuelve todos los préstamos activos (sin devolución), con el libro
    /// y el usuario asociados cargados de forma anticipada (eager loading).
    /// </summary>
    Task<IEnumerable<Loan>> GetActiveLoans();

    /// <summary>
    /// Devuelve los préstamos activos cuya fecha de vencimiento ya pasó
    /// (DueDate anterior a la fecha actual), con libro y usuario cargados.
    /// </summary>
    Task<IEnumerable<Loan>> GetOverdueLoans();

    /// <summary>
    /// Presta un libro a un usuario. Crea un nuevo préstamo con fecha de
    /// vencimiento = fecha actual + 14 días.
    /// Falla si el libro no está disponible o el usuario ya tiene 2 préstamos activos.
    /// </summary>
    Task<Loan> BorrowBook(int userId, int bookId);

    /// <summary>
    /// Registra la devolución de un préstamo activo, fijando ReturnDate a la fecha actual.
    /// Falla si no existe un préstamo activo para el id indicado.
    /// </summary>
    Task ReturnBook(int loanId);
}