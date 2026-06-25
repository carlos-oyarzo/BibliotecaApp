namespace BibliotecaApp.WinForms.Forms;

public partial class LoanManagementForm : Form
{
    public LoanManagementForm()
    {
        InitializeComponent();
        this.Load += LoanManagementForm_Load;
    }

    private void LoanManagementForm_Load(object sender, EventArgs e)
    {
        LoadCombos();
        SetupGridColumns();
        LoadActiveLoans();
    }

    // Fill the user and book dropdowns with sample data
    // TODO: replace with real service calls
    private void LoadCombos()
    {
        cmbUsers.Items.Clear();
        cmbUsers.Items.AddRange(new object[]
            { "Alice Johnson", "Bob Martinez", "Carol White" });
        cmbUsers.SelectedIndex = 0;

        cmbBooks.Items.Clear();
        cmbBooks.Items.AddRange(new object[]
            { "Clean Code", "Design Patterns", "The Pragmatic Programmer" });
        cmbBooks.SelectedIndex = 0;
    }

    private void SetupGridColumns()
    {
        dgvActiveLoans.Columns.Clear();

        dgvActiveLoans.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Id", HeaderText = "ID", Width = 50 });
        dgvActiveLoans.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "User", HeaderText = "User" });
        dgvActiveLoans.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Book", HeaderText = "Book" });
        dgvActiveLoans.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "LoanDate", HeaderText = "Loan Date", Width = 110 });
        dgvActiveLoans.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "DueDate", HeaderText = "Due Date", Width = 110 });
    }

    // TODO: replace with _loanService.GetActiveLoans()
    private void LoadActiveLoans()
    {
        var sampleLoans = new[]
        {
            new { Id = 1, User = "Alice Johnson", Book = "Clean Code",
                  LoanDate = "2025-06-01", DueDate = "2025-06-15" },
            new { Id = 2, User = "Bob Martinez",  Book = "Design Patterns",
                  LoanDate = "2025-06-05", DueDate = "2025-06-19" },
        };
        dgvActiveLoans.DataSource = sampleLoans;
    }

    private void btnBorrow_Click(object sender, EventArgs e)
    {
        if (cmbUsers.SelectedItem == null || cmbBooks.SelectedItem == null)
        {
            MessageBox.Show("Please select a user and a book.",
                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string user = cmbUsers.SelectedItem.ToString() ?? "";
        string book = cmbBooks.SelectedItem.ToString() ?? "";

        // TODO: replace with _loanService.BorrowBook(userId, bookId)
        MessageBox.Show($"Book '{book}' lent to '{user}' successfully.",
            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        LoadActiveLoans();
    }

    private void btnReturn_Click(object sender, EventArgs e)
    {
        if (dgvActiveLoans.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a loan to return.",
                "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var row = dgvActiveLoans.SelectedRows[0];
        string book = row.Cells["Book"].Value?.ToString() ?? "";

        // TODO: replace with _loanService.ReturnBook(loanId)
        MessageBox.Show($"Book '{book}' returned successfully.",
            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        LoadActiveLoans();
    }
}
