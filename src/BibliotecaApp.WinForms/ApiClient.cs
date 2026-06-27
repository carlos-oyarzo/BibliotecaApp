// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Cliente HTTP para consumir la API REST de la biblioteca.
// Wrap simple sobre HttpClient, compartido desde Program.Api.

using System.Net.Http.Json;

namespace BibliotecaApp.WinForms;

public class ApiClient
{
    private readonly HttpClient _http;

    public ApiClient(string baseUrl)
    {
        _http = new HttpClient { BaseAddress = new Uri(baseUrl) };
    }

    // ── Books ──────────────────────────────────────

    public async Task<List<BookDto>> GetBooksAsync()
        => await _http.GetFromJsonAsync<List<BookDto>>("api/Libros") ?? new();

    public async Task<BookDto?> GetBookAsync(int id)
        => await _http.GetFromJsonAsync<BookDto>($"api/Libros/{id}");

    public async Task<BookDto?> CreateBookAsync(BookDto book)
    {
        var response = await _http.PostAsJsonAsync("api/Libros", book);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<BookDto>();
    }

    public async Task UpdateBookAsync(int id, BookDto book)
    {
        var response = await _http.PutAsJsonAsync($"api/Libros/{id}", book);
        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteBookAsync(int id)
    {
        var response = await _http.DeleteAsync($"api/Libros/{id}");
        response.EnsureSuccessStatusCode();
    }

    // ── Users ──────────────────────────────────────

    public async Task<List<UserDto>> GetUsersAsync()
        => await _http.GetFromJsonAsync<List<UserDto>>("api/Usuarios") ?? new();

    public async Task<UserDto?> GetUserAsync(int id)
        => await _http.GetFromJsonAsync<UserDto>($"api/Usuarios/{id}");

    public async Task<UserDto?> CreateUserAsync(UserDto user)
    {
        var response = await _http.PostAsJsonAsync("api/Usuarios", user);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<UserDto>();
    }

    public async Task UpdateUserAsync(int id, UserDto user)
    {
        var response = await _http.PutAsJsonAsync($"api/Usuarios/{id}", user);
        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteUserAsync(int id)
    {
        var response = await _http.DeleteAsync($"api/Usuarios/{id}");
        response.EnsureSuccessStatusCode();
    }

    // ── Loans ──────────────────────────────────────

    public async Task<LoanResultDto?> BorrowBookAsync(int bookId, int userId)
    {
        var response = await _http.PostAsync($"api/Prestamos?bookId={bookId}&userId={userId}", null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<LoanResultDto>();
    }

    public async Task<LoanResultDto?> ReturnBookAsync(int bookId)
    {
        var response = await _http.PostAsync($"api/Prestamos/devolver/{bookId}", null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<LoanResultDto>();
    }
}