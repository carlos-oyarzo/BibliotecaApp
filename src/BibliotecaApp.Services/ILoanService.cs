// ─── Responsable: Carlos — Rol 4 (backend-prestamos) ───
// Interfaz para el servicio de préstamos. Define operaciones de préstamo y devolución.

using BibliotecaApp.Domain;

namespace BibliotecaApp.Services;

public interface ILoanService
{
    Task<Prestamo> BorrowBookAsync(int bookId, int userId);
    Task<Prestamo> ReturnBookAsync(int bookId);
}