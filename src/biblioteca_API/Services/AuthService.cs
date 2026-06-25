using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using biblioteca_API.Data;
using biblioteca_API.Models;
using BibliotecaApp.Domain;

namespace biblioteca_API.Services;

public class AuthService
{
    private readonly BibliotecaContext _context;
    private readonly IConfiguration _configuration;

    public AuthService(BibliotecaContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    public async Task<string?> LoginAsync(LoginRequest request)
    {
        // Busca al usuario por su email
        var usuario = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);

        // Valida si existe y si la contraseña coincide
        if (usuario == null || usuario.PasswordHash != request.Password)
            return null;

        // Si es correcto, genera y retorna el Token JWT
        return GenerarJwtToken(usuario);
    }

    private string GenerarJwtToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"] ?? "ClaveSuperSecretaDeMasDe32CaracteresParaLaBiblioteca!");

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email)
            }),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}
