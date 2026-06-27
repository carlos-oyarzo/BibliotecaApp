// ─── Responsable: Carlos — Rol 4 (backend-prestamos) ───
// Controlador REST para préstamos. Registra y devuelve préstamos de libros.

using BibliotecaApp.Domain;
using BibliotecaApp.Services;
using Microsoft.AspNetCore.Mvc;


namespace biblioteca_API.Controllers
{
    [Route("api/Prestamos")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        private readonly ILoanService _loanService;

        public PrestamosController(ILoanService loanService)
        {
            _loanService = loanService;
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarPrestamo(int bookId, int userId)
        {
            try
            {
                var prestamo = await _loanService.BorrowBookAsync(bookId, userId);

                return Ok(new { Mensaje = $"Libro '{prestamo.Book?.Title}' prestado con éxito a {prestamo.User?.Name}." });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("devolver/{bookId}")]
        public async Task<IActionResult> DevolverLibro(int bookId)
        {
            try
            {
                await _loanService.ReturnBookAsync(bookId);

                return Ok(new { Mensaje = "El libro ha sido devuelto y está disponible nuevamente." });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}