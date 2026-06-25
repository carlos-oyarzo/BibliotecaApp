// ... mantén tus usings actuales ...
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using biblioteca_API.Data;
using biblioteca_API.Domain;

namespace biblioteca_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LibrosController : ControllerBase
{
    private readonly BibliotecaContext _context;
    public LibrosController(BibliotecaContext context) => _context = context;

    
    [HttpGet("isbn/{isbn}")]
    public async Task<ActionResult<Libro>> GetLibroPorIsbn(string isbn)
    {
        var libro = await _context.Libros.FirstOrDefaultAsync(l => l.ISBN == isbn);
        return libro == null ? NotFound(new { mensaje = "El ISBN no corresponde a ningún libro" }) : libro;
    }

    
    [HttpPost]
    public async Task<ActionResult<Libro>> PostLibro([FromBody] Libro libro)
    {
        var existe = await _context.Libros.AnyAsync(l => l.ISBN == libro.ISBN);
        if (existe) return BadRequest(new { mensaje = "Este ISBN ya está registrado en el sistema" });

        _context.Libros.Add(libro);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetLibroPorIsbn), new { isbn = libro.ISBN }, libro);
    }
}
