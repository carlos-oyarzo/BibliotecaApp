// ─── Responsable: Alejandro Viana — Rol 3 (backend-usuarios-libros) ───
// Servicio de libros. Implementa la lógica de negocio CRUD y búsqueda por ISBN sobre BibliotecaContext.

using BibliotecaApp.Data;
using BibliotecaApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApp.Services;

public class BookService : IBookService
{
    private readonly BibliotecaContext _context;

    public BookService(BibliotecaContext context)
    {
        _context = context;
    }

    public async Task<List<Book>> GetAllAsync()
    {
        return await _context.Books.ToListAsync();
    }

    public async Task<Book?> GetByIdAsync(int id)
    {
        return await _context.Books.FindAsync(id);
    }

    public async Task<Book> CreateAsync(Book book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();
        return book;
    }

    public async Task<Book?> UpdateAsync(int id, Book book)
    {
        if (id != book.Id)
        {
            return null;
        }

        _context.Entry(book).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await _context.Books.AnyAsync(e => e.Id == id))
            {
                return null;
            }
            else
            {
                throw;
            }
        }

        return book;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var book = await _context.Books.FindAsync(id);
        if (book == null)
        {
            return false;
        }

        _context.Books.Remove(book);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Book?> GetByIsbnAsync(string isbn)
    {
        return await _context.Books.FirstOrDefaultAsync(b => b.ISBN == isbn);
    }

    public async Task<bool> IsbnExistsAsync(string isbn)
    {
        return await _context.Books.AnyAsync(b => b.ISBN == isbn);
    }
}