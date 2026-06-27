// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Pantalla principal del dashboard.Menu de navegación a cada módulo de la biblioteca.

namespace BibliotecaApp.WinForms.Forms;

public partial class DashboardForm : Form
{
    // Receives the logged-in user's name from LoginForm
    public DashboardForm(string userName)
    {
        InitializeComponent();
        lblUserName.Text = $"Logged in as: {userName}";
    }

    private void btnBooks_Click(object sender, EventArgs e)
    {
        var form = new BookManagementForm();
        form.Show();
    }

    private void btnUsers_Click(object sender, EventArgs e)
    {
        var form = new UserManagementForm();
        form.Show();
    }

    private void btnLoans_Click(object sender, EventArgs e)
    {
        var form = new LoanManagementForm();
        form.Show();
    }

    private void btnOverdue_Click(object sender, EventArgs e)
    {
        var form = new OverdueLoansForm();
        form.Show();
    }

    private void DashboardForm_Load(object sender, EventArgs e)
    {

    }
}