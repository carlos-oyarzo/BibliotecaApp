// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Listado y gestión de libros. Carga la grilla y abre BookForm para alta/edición.

namespace BibliotecaApp.WinForms.Forms;

public partial class BookManagementForm : Form
{
    public BookManagementForm()
    {
        InitializeComponent();
        this.Load += BookManagementForm_Load;
    }

    private async void BookManagementForm_Load(object sender, EventArgs e)
    {
        SetupGridColumns();
        await LoadBooks();
    }

    private void SetupGridColumns()
    {
        dgvBooks.AutoGenerateColumns = false;
        dgvBooks.Columns.Clear();

        dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Id", HeaderText = "ID", Width = 50 });
        dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Title", HeaderText = "Title" });
        dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Author", HeaderText = "Author" });
        dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "ISBN", HeaderText = "ISBN", Width = 160 });
    }

    private async Task LoadBooks()
    {
        try
        {
            var books = await Program.Api.GetBooksAsync();
            dgvBooks.DataSource = books;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading books: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnAdd_Click(object sender, EventArgs e)
    {
        using var form = new BookForm();
        if (form.ShowDialog() == DialogResult.OK)
            await LoadBooks();
    }

    private async void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvBooks.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a book to edit.",
                "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var row = dgvBooks.SelectedRows[0];
        int id = Convert.ToInt32(row.Cells["Id"].Value);
        string title = row.Cells["Title"].Value?.ToString() ?? "";
        string author = row.Cells["Author"].Value?.ToString() ?? "";
        string isbn = row.Cells["ISBN"].Value?.ToString() ?? "";

        using var form = new BookForm(id, title, author, isbn);
        if (form.ShowDialog() == DialogResult.OK)
            await LoadBooks();
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvBooks.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a book to delete.",
                "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var row = dgvBooks.SelectedRows[0];
        int id = Convert.ToInt32(row.Cells["Id"].Value);
        string title = row.Cells["Title"].Value?.ToString() ?? "";

        var confirm = MessageBox.Show(
            $"Are you sure you want to delete '{title}'?",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (confirm == DialogResult.Yes)
        {
            try
            {
                await Program.Api.DeleteBookAsync(id);
                MessageBox.Show("Book deleted successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting book: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        string query = txtSearch.Text.Trim().ToLower();
        if (string.IsNullOrEmpty(query)) { await LoadBooks(); return; }

        try
        {
            var all = await Program.Api.GetBooksAsync();
            dgvBooks.DataSource = all
                .Where(b => b.Title.ToLower().Contains(query)
                         || b.Author.ToLower().Contains(query))
                .ToList();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error searching books: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}