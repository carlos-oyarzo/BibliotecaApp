namespace BibliotecaApp.WinForms.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text.Trim();
        string password = txtPassword.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Por favor ingresa tu correo y contraseña.",
                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!email.Contains("@") || !email.Contains("."))
        {
            MessageBox.Show("Por favor ingresa un correo electrónico válido.",
                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmail.Focus();
            return;
        }

        // TODO: reemplazar con autenticación real:
        // var userService = Program.ServiceProvider.GetRequiredService<IUserService>();
        // var user = userService.Login(email, password);
        // if (user == null) { MessageBox.Show("Correo o contraseña incorrectos."); return; }

        var dashboard = new DashboardForm(email);
        dashboard.Show();
        this.Hide();
    }
}