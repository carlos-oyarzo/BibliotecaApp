namespace BibliotecaApp.Domain;

// =============================================
// MODELO COMPARTIDO — Responsable: Charly (Rol 4)
// =============================================
// Entidad de préstamo del sistema. Representa el acto de prestar un libro
// a un usuario, con fecha de préstamo, vencimiento y devolución.
// La regla de vencimiento (14 días) la aplica el LoanService, no la entidad.
// =============================================

public class Loan
{
    /// <summary>
    /// Identificador único del préstamo.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Clave foránea al libro prestado.
    /// </summary>
    public int BookId { get; set; }

    /// <summary>
    /// Clave foránea al usuario que solicita el préstamo.
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Fecha en la que se realiza el préstamo (UTC).
    /// </summary>
    public DateTime LoanDate { get; set; }

    /// <summary>
    /// Fecha de vencimiento del préstamo (LoanDate + 14 días).
    /// La calcula el LoanService al crear el préstamo.
    /// </summary>
    public DateTime DueDate { get; set; }

    /// <summary>
    /// Fecha de devolución del libro (nullable mientras no se devuelva).
    /// </summary>
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// Navegación al libro prestado.
    /// </summary>
    public Book? Book { get; set; }

    /// <summary>
    /// Navegación al usuario que tomó el préstamo.
    /// </summary>
    public User? User { get; set; }
}