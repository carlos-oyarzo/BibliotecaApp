namespace BibliotecaApp.WinForms.Forms;

public partial class OverdueLoansForm : Form
{
    public OverdueLoansForm()
    {
        InitializeComponent();
        this.Load += OverdueLoansForm_Load;
    }

    private void OverdueLoansForm_Load(object sender, EventArgs e)
    {
        SetupGridColumns();
        LoadOverdueLoans();
    }

    private void SetupGridColumns()
    {
        dgvOverdue.Columns.Clear();

        dgvOverdue.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "User", HeaderText = "Usuario" });
        dgvOverdue.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Book", HeaderText = "Libro" });
        dgvOverdue.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "LoanDate", HeaderText = "Fecha Préstamo", Width = 130 });
        dgvOverdue.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "DueDate", HeaderText = "Fecha Vencimiento", Width = 130 });
        dgvOverdue.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "DaysLate", HeaderText = "Días de Atraso", Width = 110 });
    }

    private void LoadOverdueLoans()
    {
        var today = DateTime.Today;

        // TODO: reemplazar con _loanService.GetOverdueLoans()
        var overdueLoans = new[]
        {
            new { User = "Alice Johnson", Book = "Clean Code",
                  LoanDate = "2025-05-01", DueDate = "2025-05-15",
                  DaysLate = (today - new DateTime(2025, 5, 15)).Days },
            new { User = "Bob Martinez",  Book = "Design Patterns",
                  LoanDate = "2025-05-10", DueDate = "2025-05-24",
                  DaysLate = (today - new DateTime(2025, 5, 24)).Days },
        };

        dgvOverdue.DataSource = overdueLoans;
        lblCount.Text = $"Total préstamos vencidos: {overdueLoans.Length}";
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        LoadOverdueLoans();
    }
}