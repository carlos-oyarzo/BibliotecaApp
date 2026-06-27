// ─── Responsable: Alejandro Viana — Rol 3 (backend-usuarios-libros) ───
// Interfaz para el servicio de usuarios. Define las operaciones CRUD.

using BibliotecaApp.Domain;

namespace BibliotecaApp.Services;

public interface IUserService
{
    Task<List<User>> GetAllAsync();
    Task<User?> GetByIdAsync(int id);
    Task<User> CreateAsync(User user);
    Task<User?> UpdateAsync(int id, User user);
    Task<bool> DeleteAsync(int id);
}