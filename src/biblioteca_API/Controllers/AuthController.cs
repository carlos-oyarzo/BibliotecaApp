using Microsoft.AspNetCore.Mvc;
using biblioteca_API.Domain;
using biblioteca_API.Services;

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

        return Ok(new { token }); // El Frontend recibe el token exitosamente aquí
    }
}
