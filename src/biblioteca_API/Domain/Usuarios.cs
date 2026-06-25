namespace biblioteca_API.Domain
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty; // 👈 Requerido para el Login
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;
    }
}
