using biblioteca_API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using biblioteca_API.Domain;


namespace biblioteca_API.Controllers
{
    [Route("api/Prestamos")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        private readonly BibliotecaContext _context;

        public PrestamosController(BibliotecaContext context)
        {
            _context = context;
        }

        // Endpoint para registrar un nuevo préstamo
        [HttpPost]
        public async Task<IActionResult> RegistrarPrestamo(int libroId, int usuarioId)
        {
            // 1. Verificar si el libro existe y si está disponible
            var libro = await _context.Libros.FindAsync(libroId);
            if (libro == null) return NotFound("El libro especificado no existe.");
            if (!libro.Disponible) return BadRequest("El libro ya se encuentra prestado.");

            // 2. Verificar si el usuario existe
            var usuario = await _context.Usuarios.FindAsync(usuarioId);
            if (usuario == null) return NotFound("El usuario especificado no existe.");

            // 3. Crear el registro del préstamo
            var prestamo = new Prestamo
            {
                LibroId = libroId,
                UsuarioId = usuarioId,
                FechaPrestamo = DateTime.Now
            };

            // 4. Cambiar el estado del libro a NO disponible
            libro.Disponible = false;

            _context.Prestamos.Add(prestamo);
            await _context.SaveChangesAsync();

            return Ok(new { Mensaje = $"Libro '{libro.Titulo}' prestado con éxito a {usuario.Nombre}." });
        }

        // Endpoint para devolver un libro
        [HttpPost("devolver/{libroId}")]
        public async Task<IActionResult> DevolverLibro(int libroId)
        {
            // Buscar el préstamo activo de ese libro (que no tenga fecha de devolución)
            var prestamo = await _context.Prestamos
                .FirstOrDefaultAsync(p => p.LibroId == libroId && p.FechaDevolucion == null);

            if (prestamo == null) return NotFound("No se encontró ningún préstamo activo para este libro.");

            var libro = await _context.Libros.FindAsync(libroId);
            if (libro != null)
            {
                // Cambiar el libro a disponible nuevamente
                libro.Disponible = true;
            }

            // Registrar la fecha de devolución
            prestamo.FechaDevolucion = DateTime.Now;

            await _context.SaveChangesAsync();
            return Ok(new { Mensaje = "El libro ha sido devuelto y está disponible nuevamente." });
        }
    }
}
