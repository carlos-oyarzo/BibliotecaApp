// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// DTOs para deserializar las respuestas JSON de la API REST.

namespace BibliotecaApp.WinForms;

public class BookDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public bool IsAvailable { get; set; }
}

public class UserDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
}

public class LoanResultDto
{
    public string Mensaje { get; set; } = string.Empty;
}