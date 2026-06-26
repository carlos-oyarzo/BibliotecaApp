namespace BibliotecaApp.WinForms.Forms;

public partial class DashboardForm : Form
{
    public DashboardForm(string userName)
    {
        InitializeComponent();
        lblUserName.Text = $"Usuario: {userName}";
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
}