using Microsoft.AspNetCore.Mvc;
using BibliotecaApp.Services;

namespace biblioteca_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService) => _authService = authService;

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var token = await _authService.LoginAsync(request);
        if (token == null) return Unauthorized(new { mensaje = "Email o contraseña incorrectos" });

        return Ok(new { token });
    }
}
