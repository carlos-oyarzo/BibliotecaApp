using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BibliotecaApp.Domain;
using BibliotecaApp.Data;

[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    private readonly BibliotecaContext _context;
    public UsuariosController(BibliotecaContext context)
    {
        _context = context;
    }

    // GET: api/Usuarios
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsuarios()
    {
        return await _context.Users.ToListAsync();
    }

    // GET: api/Usuarios/5
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUsuarios(int id)
    {
        var user = await _context.Users.FindAsync(id);

        if (user == null)
        {
            return NotFound();
        }

        return user;
    }

    // PUT: api/Usuarios/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutUsuarios(int? id, User user)
    {
        if (id != user.Id)
        {
            return BadRequest();
        }

        _context.Entry(user).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!UserExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Usuarios
    [HttpPost]
    public async Task<ActionResult<User>> PostUsuarios(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetUsuarios", new { id = user.Id }, user);
    }

    // DELETE: api/Usuarios/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUsuarios(int? id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null)
        {
            return NotFound();
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool UserExists(int? id)
    {
        return _context.Users.Any(e => e.Id == id);
    }
}
