// ─── Responsable: Alejandro Viana — Rol 3 (backend-usuarios-libros) ───
// Controlador REST para la gestión de usuarios (CRUD) sobre la API.

using BibliotecaApp.Domain;
using BibliotecaApp.Services;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    private readonly IUserService _userService;

    public UsuariosController(IUserService userService)
    {
        _userService = userService;
    }

    // GET: api/Usuarios
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        return await _userService.GetAllAsync();
    }

    // GET: api/Usuarios/5
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser(int id)
    {
        var user = await _userService.GetByIdAsync(id);

        if (user == null)
        {
            return NotFound();
        }

        return user;
    }

    // PUT: api/Usuarios/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutUser(int? id, User user)
    {
        if (id != user.Id)
        {
            return BadRequest();
        }

        var updated = await _userService.UpdateAsync(id.Value, user);
        if (updated == null)
        {
            return NotFound();
        }

        return NoContent();
    }

    // POST: api/Usuarios
    [HttpPost]
    public async Task<ActionResult<User>> PostUser(User user)
    {
        var created = await _userService.CreateAsync(user);

        return CreatedAtAction("GetUser", new { id = created.Id }, created);
    }

    // DELETE: api/Usuarios/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var deleted = await _userService.DeleteAsync(id.Value);
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}