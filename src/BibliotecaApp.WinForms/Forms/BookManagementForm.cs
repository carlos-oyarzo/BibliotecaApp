namespace BibliotecaApp.WinForms.Forms;

public partial class BookManagementForm : Form
{
    public BookManagementForm()
    {
        InitializeComponent();
        this.Load += BookManagementForm_Load;
    }

    private void BookManagementForm_Load(object sender, EventArgs e)
    {
        SetupGridColumns();
        LoadBooks();
    }

    private void SetupGridColumns()
    {
        dgvBooks.Columns.Clear();

        dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Id", HeaderText = "ID", Width = 50 });
        dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Title", HeaderText = "Título" });
        dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Author", HeaderText = "Autor" });
        dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "ISBN", HeaderText = "ISBN", Width = 160 });
    }

    private void LoadBooks()
    {
        // TODO: reemplazar con _bookService.GetAllBooks()
        var sampleBooks = new[]
        {
            new { Id = 1, Title = "Clean Code",
                  Author = "Robert C. Martin", ISBN = "978-0132350884" },
            new { Id = 2, Title = "The Pragmatic Programmer",
                  Author = "Andrew Hunt",       ISBN = "978-0201616224" },
            new { Id = 3, Title = "Design Patterns",
                  Author = "Gang of Four",      ISBN = "978-0201633610" },
        };
        dgvBooks.DataSource = sampleBooks;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using var form = new BookForm();
        if (form.ShowDialog() == DialogResult.OK)
            LoadBooks();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvBooks.SelectedRows.Count == 0)
        {
            MessageBox.Show("Por favor selecciona un libro para editar.",
                "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var row = dgvBooks.SelectedRows[0];
        int id = Convert.ToInt32(row.Cells["Id"].Value);
        string title = row.Cells["Title"].Value?.ToString() ?? "";
        string author = row.Cells["Author"].Value?.ToString() ?? "";
        string isbn = row.Cells["ISBN"].Value?.ToString() ?? "";

        using var form = new BookForm(id, title, author, isbn);
        if (form.ShowDialog() == DialogResult.OK)
            LoadBooks();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvBooks.SelectedRows.Count == 0)
        {
            MessageBox.Show("Por favor selecciona un libro para eliminar.",
                "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var row = dgvBooks.SelectedRows[0];
        string title = row.Cells["Title"].Value?.ToString() ?? "";

        var confirm = MessageBox.Show(
            $"¿Estás seguro de que deseas eliminar '{title}'?",
            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (confirm == DialogResult.Yes)
        {
            // TODO: reemplazar con _bookService.DeleteBook(id)
            MessageBox.Show("Libro eliminado correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadBooks();
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        string query = txtSearch.Text.Trim().ToLower();
        if (string.IsNullOrEmpty(query)) { LoadBooks(); return; }

        var all = new[]
        {
            new { Id = 1, Title = "Clean Code",
                  Author = "Robert C. Martin", ISBN = "978-0132350884" },
            new { Id = 2, Title = "The Pragmatic Programmer",
                  Author = "Andrew Hunt",       ISBN = "978-0201616224" },
            new { Id = 3, Title = "Design Patterns",
                  Author = "Gang of Four",      ISBN = "978-0201633610" },
        };

        dgvBooks.DataSource = all
            .Where(b => b.Title.ToLower().Contains(query)
                     || b.Author.ToLower().Contains(query))
            .ToArray();
    }
}