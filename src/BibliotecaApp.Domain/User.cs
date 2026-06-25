namespace BibliotecaApp.Domain;

// =============================================
// MODELO COMPARTIDO — Responsable: Juan Acevedo y Alejandro Viana
// =============================================
// Esta es la definición base del usuario en el sistema.
// Rol 1 (db-seguridad): agreguen acá las validaciones de contraseña,
//   el hashing con BCrypt y cualquier campo de seguridad que necesiten.
// Rol 3 (backend-usuarios-libros): extiendan con los campos que requieran
//   para el registro, login y gestión de usuarios.
// =============================================

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    // Rol 1: este campo almacena el hash BCrypt, NUNCA la contraseña en texto plano.
    // Usar BCrypt.Net-Next para generar y verificar hashes.
    public string PasswordHash { get; set; } = string.Empty;

    // Rol 3: pueden usar esto para diferenciar "admin" de "user" si hace falta.
    public string Role { get; set; } = "user";

    // Fecha de registro del usuario (requerido por Rol 3 / AuthController).
    public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

    // Navegación: préstamos asociados a este usuario
    public List<Loan> Loans { get; set; } = new();
}
