// ─── Responsable: Alejandro Viana — Rol 3 (backend-usuarios-libros) ───
// Interfaz para el servicio de libros. Define las operaciones CRUD y búsqueda.

using BibliotecaApp.Domain;

namespace BibliotecaApp.Services;

public interface IBookService
{
    Task<List<Book>> GetAllAsync();
    Task<Book?> GetByIdAsync(int id);
    Task<Book> CreateAsync(Book book);
    Task<Book?> UpdateAsync(int id, Book book);
    Task<bool> DeleteAsync(int id);
    Task<Book?> GetByIsbnAsync(string isbn);
    Task<bool> IsbnExistsAsync(string isbn);
}