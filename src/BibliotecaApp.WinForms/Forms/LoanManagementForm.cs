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

    private void LoadCombos()
    {
        cmbUsers.Items.Clear();
        // TODO: reemplazar con userService.GetAllUsers()
        cmbUsers.Items.AddRange(new object[]
            { "Alice Johnson", "Bob Martinez", "Carol White" });
        cmbUsers.SelectedIndex = 0;

        cmbBooks.Items.Clear();
        // TODO: reemplazar con bookService.GetAvailableBooks()
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
        { DataPropertyName = "User", HeaderText = "Usuario" });
        dgvActiveLoans.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Book", HeaderText = "Libro" });
        dgvActiveLoans.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "LoanDate", HeaderText = "Fecha Préstamo", Width = 130 });
        dgvActiveLoans.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "DueDate", HeaderText = "Fecha Devolución", Width = 130 });
    }

    private void LoadActiveLoans()
    {
        // TODO: reemplazar con _loanService.GetActiveLoans()
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
            MessageBox.Show("Por favor selecciona un usuario y un libro.",
                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string user = cmbUsers.SelectedItem.ToString() ?? "";
        string book = cmbBooks.SelectedItem.ToString() ?? "";

        // TODO: reemplazar con _loanService.BorrowBook(userId, bookId)
        MessageBox.Show($"Libro '{book}' prestado a '{user}' correctamente.",
            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        LoadActiveLoans();
    }

    private void btnReturn_Click(object sender, EventArgs e)
    {
        if (dgvActiveLoans.SelectedRows.Count == 0)
        {
            MessageBox.Show("Por favor selecciona un préstamo para devolver.",
                "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var row = dgvActiveLoans.SelectedRows[0];
        string book = row.Cells["Book"].Value?.ToString() ?? "";

        // TODO: reemplazar con _loanService.ReturnBook(loanId)
        MessageBox.Show($"Libro '{book}' devuelto correctamente.",
            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        LoadActiveLoans();
    }
}