// ─── Responsable: Alejandro Viana — Rol 3 (backend-usuarios-libros) ───
// Servicio de usuarios. Implementa la lógica de negocio CRUD sobre BibliotecaContext.

using BibliotecaApp.Data;
using BibliotecaApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApp.Services;

public class UserService : IUserService
{
    private readonly BibliotecaContext _context;

    public UserService(BibliotecaContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User?> GetByIdAsync(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    public async Task<User> CreateAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<User?> UpdateAsync(int id, User user)
    {
        if (id != user.Id)
        {
            return null;
        }

        _context.Entry(user).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await _context.Users.AnyAsync(e => e.Id == id))
            {
                return null;
            }
            else
            {
                throw;
            }
        }

        return user;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null)
        {
            return false;
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return true;
    }
}