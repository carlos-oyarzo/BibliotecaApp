// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Formulario de inicio de sesión. Valida credenciales y abre el dashboard.

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

        // Validation: both fields required
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter your email and password.",
                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Validate email format
        if (!email.Contains("@") || !email.Contains("."))
        {
            MessageBox.Show("Please enter a valid email address.",
                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmail.Focus();
            return;
        }

        // TODO: Replace with real authentication when AuthController exists in the API:
        //   var response = await Program.Api.PostLoginAsync(email, password);
        //   if (!response.IsSuccessStatusCode) { MessageBox.Show("Incorrect email or password."); return; }
        // The AuthController was removed from the API; it will be added when Rol 1
        // implements security. For now, any non-empty input opens the Dashboard.
        var dashboard = new DashboardForm(email);
        dashboard.Show();
        this.Hide();
    }

    private void txtEmail_TextChanged(object sender, EventArgs e)
    {

    }
}