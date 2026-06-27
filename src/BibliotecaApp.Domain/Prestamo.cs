// ─── Responsable: Carlos — Rol 4 (backend-prestamos) ───
// Modelo de dominio para Préstamos. Relaciona libros con usuarios y registra fechas.

namespace BibliotecaApp.Domain;

public class Prestamo
{
    public int Id { get; set; }

    public int BookId { get; set; }
    public Book? Book { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }

    public DateTime LoanDate { get; set; } = DateTime.Now;
    public DateTime? ReturnDate { get; set; }
}
