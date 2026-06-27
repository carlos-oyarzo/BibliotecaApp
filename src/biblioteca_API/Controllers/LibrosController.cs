// ─── Responsable: Alejandro Viana — Rol 3 (backend-usuarios-libros) ───
// Controlador REST para la gestión de libros (CRUD) sobre la API.

using BibliotecaApp.Domain;
using BibliotecaApp.Services;
using Microsoft.AspNetCore.Mvc;

[Route("api/Libros")]
[ApiController]
public class LibrosController : ControllerBase
{
    private readonly IBookService _bookService;

    public LibrosController(IBookService bookService)
    {
        _bookService = bookService;
    }

    // GET: api/Libros
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
    {
        return await _bookService.GetAllAsync();
    }

    // GET: api/Libros/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> GetBook(int id)
    {
        var book = await _bookService.GetByIdAsync(id);

        if (book == null)
        {
            return NotFound();
        }

        return book;
    }

    // PUT: api/Libros/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutBook(int? id, Book book)
    {
        if (id != book.Id)
        {
            return BadRequest();
        }

        var updated = await _bookService.UpdateAsync(id.Value, book);
        if (updated == null)
        {
            return NotFound();
        }

        return NoContent();
    }

    // POST: api/Libros
    [HttpPost]
    public async Task<ActionResult<Book>> PostBook(Book book)
    {
        var created = await _bookService.CreateAsync(book);

        return CreatedAtAction("GetBook", new { id = created.Id }, created);
    }

    // DELETE: api/Libros/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBook(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var deleted = await _bookService.DeleteAsync(id.Value);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}