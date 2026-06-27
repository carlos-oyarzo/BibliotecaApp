// ─── Responsable: Alejandro Viana — Rol 3 (backend-usuarios-libros) ───
// Modelo de dominio para Libros. Define los atributos base del libro en el sistema.

namespace BibliotecaApp.Domain;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public bool IsAvailable { get; set; } = true;

    public List<Prestamo> Prestamos { get; set; } = new();
}