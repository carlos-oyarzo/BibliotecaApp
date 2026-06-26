namespace BibliotecaApp.WinForms.Forms;

public partial class BookForm : Form
{
    private int _bookId = 0;

    public BookForm()
    {
        InitializeComponent();
        this.Text = "Nuevo Libro";
    }

    public BookForm(int bookId, string title, string author, string isbn)
    {
        InitializeComponent();
        _bookId = bookId;
        txtTitle.Text = title;
        txtAuthor.Text = author;
        txtISBN.Text = isbn;
        this.Text = "Editar Libro";
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        string title = txtTitle.Text.Trim();
        string author = txtAuthor.Text.Trim();
        string isbn = txtISBN.Text.Trim();

        if (string.IsNullOrEmpty(title))
        {
            MessageBox.Show("El campo Título es obligatorio.",
                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTitle.Focus();
            return;
        }

        if (string.IsNullOrEmpty(author))
        {
            MessageBox.Show("El campo Autor es obligatorio.",
                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtAuthor.Focus();
            return;
        }

        if (string.IsNullOrEmpty(isbn))
        {
            MessageBox.Show("El campo ISBN es obligatorio.",
                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtISBN.Focus();
            return;
        }

        if (_bookId == 0)
        {
            // TODO: reemplazar con _bookService.CreateBook(title, author, isbn)
            MessageBox.Show($"Libro '{title}' creado correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            // TODO: reemplazar con _bookService.UpdateBook(_bookId, title, author, isbn)
            MessageBox.Show($"Libro '{title}' actualizado correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}