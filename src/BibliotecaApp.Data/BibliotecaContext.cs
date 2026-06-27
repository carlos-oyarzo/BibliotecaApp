// ─── Responsable: Juan Acevedo — Rol 1 (db-seguridad) ───
// DbContext de Entity Framework. Define los DbSet y la configuración de la base de datos.

using BibliotecaApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApp.Data;

public class BibliotecaContext : DbContext
{
    public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Prestamo> Prestamos { get; set; }
}
