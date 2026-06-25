using biblioteca_API.Domain;
using Microsoft.EntityFrameworkCore;

namespace biblioteca_API.Data
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {
        }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

    }
}
    

