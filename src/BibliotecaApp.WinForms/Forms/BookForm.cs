// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Formulario de alta/edición de un libro. Llama a la API REST al guardar.

namespace BibliotecaApp.WinForms.Forms;

public partial class BookForm : Form
{
    // 0 = new book, any other value = editing existing book
    private int _bookId = 0;

    // Constructor for NEW book
    public BookForm()
    {
        InitializeComponent();
        this.Text = "New Book";
    }

    // Constructor for EDITING an existing book
    public BookForm(int bookId, string title, string author, string isbn)
    {
        InitializeComponent();
        _bookId = bookId;
        txtTitle.Text = title;
        txtAuthor.Text = author;
        txtISBN.Text = isbn;
        this.Text = "Edit Book";
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        string title = txtTitle.Text.Trim();
        string author = txtAuthor.Text.Trim();
        string isbn = txtISBN.Text.Trim();

        if (string.IsNullOrEmpty(title))
        {
            MessageBox.Show("The Title field is required.",
                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTitle.Focus();
            return;
        }

        if (string.IsNullOrEmpty(author))
        {
            MessageBox.Show("The Author field is required.",
                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtAuthor.Focus();
            return;
        }

        if (string.IsNullOrEmpty(isbn))
        {
            MessageBox.Show("The ISBN field is required.",
                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtISBN.Focus();
            return;
        }

        var book = new BookDto
        {
            Id = _bookId,
            Title = title,
            Author = author,
            ISBN = isbn
        };

        try
        {
            if (_bookId == 0)
            {
                await Program.Api.CreateBookAsync(book);
                MessageBox.Show($"Book '{title}' created successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await Program.Api.UpdateBookAsync(_bookId, book);
                MessageBox.Show($"Book '{title}' updated successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving book: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}