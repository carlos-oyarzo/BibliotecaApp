namespace BibliotecaApp.WinForms.Forms;

// =============================================
// LoginForm — Pantalla de inicio de sesión
// =============================================
// Rol 2: acá tienen que armar el formulario de login.
//
// Controles que necesitan:
//   - TextBox para email (txtEmail)
//   - TextBox para contraseña (txtPassword, con PasswordChar = '*')
//   - Button "Iniciar sesión" (btnLogin)
//   - Label para el título "BibliotecaApp"
//
// Lógica:
//   1. Cuando aprieten "Iniciar sesión", llamar a IUserService.Login(email, password)
//   2. Si falla: MessageBox.Show("Usuario o contraseña incorrectos")
//   3. Si es exitoso: new DashboardForm().Show() y this.Hide()
//
// Para obtener el servicio:
//   var userService = Program.ServiceProvider.GetRequiredService<IUserService>();
// =============================================

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }
}
