using BibliotecaApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BibliotecaApp.Domain;

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
        public async Task<IActionResult> RegistrarPrestamo(int bookId, int userId)
        {
            // 1. Verificar si el libro existe y si está disponible
            var book = await _context.Books.FindAsync(bookId);
            if (book == null) return NotFound("El libro especificado no existe.");
            if (!book.IsAvailable) return BadRequest("El libro ya se encuentra prestado.");

            // 2. Verificar si el usuario existe
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return NotFound("El usuario especificado no existe.");

            // 3. Crear el registro del préstamo
            var loan = new Loan
            {
                BookId = bookId,
                UserId = userId,
                LoanDate = DateTime.Now
            };

            // 4. Cambiar el estado del libro a NO disponible
            book.IsAvailable = false;

            _context.Loans.Add(loan);
            await _context.SaveChangesAsync();

            return Ok(new { Mensaje = $"Libro '{book.Title}' prestado con éxito a {user.Name}." });
        }

        // Endpoint para devolver un libro
        [HttpPost("devolver/{bookId}")]
        public async Task<IActionResult> DevolverLibro(int bookId)
        {
            // Buscar el préstamo activo de ese libro (que no tenga fecha de devolución)
            var loan = await _context.Loans
                .FirstOrDefaultAsync(l => l.BookId == bookId && l.ReturnDate == null);

            if (loan == null) return NotFound("No se encontró ningún préstamo activo para este libro.");

            var book = await _context.Books.FindAsync(bookId);
            if (book != null)
            {
                // Cambiar el libro a disponible nuevamente
                book.IsAvailable = true;
            }

            // Registrar la fecha de devolución
            loan.ReturnDate = DateTime.Now;

            await _context.SaveChangesAsync();
            return Ok(new { Mensaje = "El libro ha sido devuelto y está disponible nuevamente." });
        }
    }
}
