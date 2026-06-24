using biblioteca_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


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

        [HttpPost]
        public async Task<IActionResult> RegistrarPrestamo(int bookId, int userId)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (book == null) return NotFound("El libro especificado no existe.");
            if (!book.IsAvailable) return BadRequest("El libro ya se encuentra prestado.");

            var user = await _context.Users.FindAsync(userId);
            if (user == null) return NotFound("El usuario especificado no existe.");

            var prestamo = new Prestamo
            {
                BookId = bookId,
                UserId = userId,
                LoanDate = DateTime.Now
            };

            book.IsAvailable = false;

            _context.Prestamos.Add(prestamo);
            await _context.SaveChangesAsync();

            return Ok(new { Mensaje = $"Libro '{book.Title}' prestado con éxito a {user.Name}." });
        }

        [HttpPost("devolver/{bookId}")]
        public async Task<IActionResult> DevolverLibro(int bookId)
        {
            var prestamo = await _context.Prestamos
                .FirstOrDefaultAsync(p => p.BookId == bookId && p.ReturnDate == null);

            if (prestamo == null) return NotFound("No se encontró ningún préstamo activo para este libro.");

            var book = await _context.Books.FindAsync(bookId);
            if (book != null)
            {
                book.IsAvailable = true;
            }

            prestamo.ReturnDate = DateTime.Now;

            await _context.SaveChangesAsync();
            return Ok(new { Mensaje = "El libro ha sido devuelto y está disponible nuevamente." });
        }
    }
}
