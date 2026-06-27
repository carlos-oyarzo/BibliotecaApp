// ─── Responsable: Juan Acevedo y Alejandro Viana — Roles 1 (db-seguridad) y 3 (backend-usuarios-libros) ───
// Modelo de dominio para Usuarios. Define los atributos base y de seguridad del usuario.

namespace BibliotecaApp.Domain;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = "user";

    public List<Prestamo> Prestamos { get; set; } = new();
}