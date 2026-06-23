namespace BibliotecaApp.Domain;

// =============================================
// MODELO COMPARTIDO — Responsable: Alejandro Viana
// =============================================
// Esta es la definición base del libro en el sistema.
// Rol 3 (backend-usuarios-libros): acá van a implementar el CRUD completo.
//   Agreguen los campos que consideren necesarios: género, editorial,
//   año de publicación, cantidad de ejemplares, etc.
// =============================================

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;

    // Rol 3: el ISBN es único por libro, pueden agregar validación de formato.
    public string ISBN { get; set; } = string.Empty;

    // Importante para préstamos: LoanService usa esta propiedad para saber
    // si el libro se puede prestar o no. No la eliminen ni le cambien el nombre.
    public bool IsAvailable { get; set; } = true;

    // Relación con préstamos: un libro puede estar en muchos préstamos (historial).
    public List<Loan> Loans { get; set; } = new();
}
