namespace BibliotecaApp.Domain;

// =============================================
// MODELO DE PRÉSTAMO — Responsable: Carlos (Rol 4)
// =============================================
// Representa un préstamo de libro a un usuario.
// 
// Flujo de vida de un préstamo:
//   1. BorrowBook() → crea el registro con LoanDate = hoy, DueDate = +15 días
//   2. Durante el préstamo → ReturnDate es null (libro prestado)
//   3. ReturnBook() → establece ReturnDate y marca el libro como disponible
//
// Propiedades clave:
//   - UserId / BookId: claves foráneas (EF Core las relaciona automático)
//   - LoanDate: cuándo se prestó
//   - DueDate: fecha límite de devolución (15 días después del préstamo)
//   - ReturnDate: null = sigue prestado, tiene valor = ya devuelto
// =============================================

public class Loan
{
    public int Id { get; set; }

    // FK → Usuario que pidió el préstamo
    public int UserId { get; set; }

    // FK → Libro prestado
    public int BookId { get; set; }

    // Fecha en que se realizó el préstamo
    public DateTime LoanDate { get; set; }

    // Fecha límite para devolver (LoanDate + 15 días)
    public DateTime DueDate { get; set; }

    // Fecha real de devolución. null = todavía no se devolvió.
    public DateTime? ReturnDate { get; set; }

    // Navegación EF Core — no se setea manual, lo carga el ORM
    public User User { get; set; } = null!;
    public Book Book { get; set; } = null!;
}
