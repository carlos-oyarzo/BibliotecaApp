// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Punto de entrada de la aplicación Windows Forms. Configura el cliente HTTP y arranca el formulario de login.

using BibliotecaApp.WinForms.Forms;

namespace BibliotecaApp.WinForms;

static class Program
{
    /// <summary>Cliente HTTP compartido para consumir la API REST de la biblioteca.</summary>
    public static ApiClient Api { get; } = new("http://localhost:5027");

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new LoginForm());
    }
}