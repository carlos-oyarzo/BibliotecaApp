// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Gestión de préstamos. Registra préstamos de libros y marca devoluciones.

namespace BibliotecaApp.WinForms.Forms;

public partial class LoanManagementForm : Form
{
    public LoanManagementForm()
    {
        InitializeComponent();
        this.Load += LoanManagementForm_Load;
    }

    private async void LoanManagementForm_Load(object sender, EventArgs e)
    {
        await LoadCombos();
        SetupGridColumns();
        LoadActiveLoans();
    }

    // Fill the user and book dropdowns from the API REST
    private async Task LoadCombos()
    {
        try
        {
            var users = await Program.Api.GetUsersAsync();
            cmbUsers.DataSource = users;
            cmbUsers.DisplayMember = "Name";
            cmbUsers.ValueMember = "Id";

            var books = await Program.Api.GetBooksAsync();
            cmbBooks.DataSource = books;
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "Id";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading data: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SetupGridColumns()
    {
        dgvActiveLoans.AutoGenerateColumns = false;
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

    // TODO: replace sample data when a GET api/Prestamos endpoint exists in the API.
    //       Currently the API only exposes POST (borrow) and POST devolver (return).
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

    private async void btnBorrow_Click(object sender, EventArgs e)
    {
        if (cmbUsers.SelectedValue == null || cmbBooks.SelectedValue == null)
        {
            MessageBox.Show("Please select a user and a book.",
                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int userId = Convert.ToInt32(cmbUsers.SelectedValue);
        int bookId = Convert.ToInt32(cmbBooks.SelectedValue);
        string user = cmbUsers.Text;
        string book = cmbBooks.Text;

        try
        {
            var result = await Program.Api.BorrowBookAsync(bookId, userId);
            MessageBox.Show(result?.Mensaje ?? $"Book '{book}' lent to '{user}' successfully.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadActiveLoans();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error lending book: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnReturn_Click(object sender, EventArgs e)
    {
        if (dgvActiveLoans.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a loan to return.",
                "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var row = dgvActiveLoans.SelectedRows[0];
        int id = Convert.ToInt32(row.Cells["Id"].Value);
        string book = row.Cells["Book"].Value?.ToString() ?? "";

        // TODO: store real loan/book IDs from the API. The grid currently shows
        //       sample data with fake IDs, so this calls ReturnBookAsync(id) which
        //       the API treats as a bookId. Replace once GET api/Prestamos exists.
        try
        {
            var result = await Program.Api.ReturnBookAsync(id);
            MessageBox.Show(result?.Mensaje ?? $"Book '{book}' returned successfully.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadActiveLoans();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error returning book: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}