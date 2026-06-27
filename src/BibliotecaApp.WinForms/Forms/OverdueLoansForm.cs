// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Listado de préstamos vencidos. Muestra los préstamos cuya devolución está atrasada.

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
        { DataPropertyName = "User", HeaderText = "User" });
        dgvOverdue.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Book", HeaderText = "Book" });
        dgvOverdue.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "LoanDate", HeaderText = "Loan Date", Width = 110 });
        dgvOverdue.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "DueDate", HeaderText = "Due Date", Width = 110 });
        dgvOverdue.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "DaysLate", HeaderText = "Days Late", Width = 90 });
    }

    // TODO: replace with _loanService.GetOverdueLoans()
    private void LoadOverdueLoans()
    {
        var today = DateTime.Today;

        var overdueLoans = new[]
        {
            new { User = "Alice Johnson", Book = "Clean Code",
                  LoanDate = "2025-05-01", DueDate = "2025-05-15",
                  // Days late = today minus the due date
                  DaysLate = (today - new DateTime(2025, 5, 15)).Days },
            new { User = "Bob Martinez",  Book = "Design Patterns",
                  LoanDate = "2025-05-10", DueDate = "2025-05-24",
                  DaysLate = (today - new DateTime(2025, 5, 24)).Days },
        };

        dgvOverdue.DataSource = overdueLoans;

        // Update the counter label
        lblCount.Text = $"Total overdue loans: {overdueLoans.Length}";
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        LoadOverdueLoans();
    }
}