using BibliotecaApp.WinForms.Forms;
// DESCOMENTAR cuando los otros compañeros creen sus servicios:
// using BibliotecaApp.Data;
// using BibliotecaApp.Services;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.DependencyInjection;

namespace BibliotecaApp.WinForms;

// =============================================
// Program.cs — Punto de entrada de la aplicación - Responsable: Deisy Jaramillo
// =============================================
// Rol 2: acá se configura la inyección de dependencias y arranca la app.
//
// PASO A PASO (a medida que los compañeros avancen):
//
// 1. Cuando Rol 1 (Juan) cree AppDbContext:
//    → Descomentar using BibliotecaApp.Data;
//    → Descomentar using Microsoft.EntityFrameworkCore;
//    → Descomentar las líneas de services.AddDbContext<AppDbContext>(...)
//
// 2. Cuando Rol 3 (Alejandro) cree IUserService / IBookService:
//    → Descomentar using BibliotecaApp.Services;
//    → Descomentar using Microsoft.Extensions.DependencyInjection;
//    → Descomentar services.AddScoped<IUserService, UserService>();
//    → Descomentar services.AddScoped<IBookService, BookService>();
//
// 3. Cuando Rol 4 (Carlos) tenga LoanService:
//    → Descomentar services.AddScoped<ILoanService, LoanService>();
//
// Para consumir un servicio desde cualquier formulario:
//   var loanService = Program.ServiceProvider.GetRequiredService<ILoanService>();
// =============================================

static class Program
{
    /// <summary>
    /// Proveedor de servicios. Se configura en Main() a medida que
    /// los servicios estén disponibles.
    /// </summary>
    // public static IServiceProvider ServiceProvider { get; private set; } = null!;

    /// <summary>
    /// Punto de entrada principal.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // ─── Configuración de inyección de dependencias (DESCOMENTAR CUANDO CORRESPONDA) ───
        //
        // var services = new ServiceCollection();
        //
        // // BD (Rol 1):
        // var connectionString = "Server=localhost;Database=biblioteca_db;User=root;Password=;";
        // services.AddDbContext<AppDbContext>(options =>
        //     options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        //
        // // Servicios:
        // services.AddScoped<ILoanService, LoanService>();     // Rol 4 — YA casi esta listo
        // services.AddScoped<IUserService, UserService>();    // Rol 3 — cuando esté listo
        // services.AddScoped<IBookService, BookService>();    // Rol 3 — cuando esté listo
        //
        // ServiceProvider = services.BuildServiceProvider();

        ApplicationConfiguration.Initialize();

        // Arranca con el LoginForm
        Application.Run(new LoginForm());
    }
}
