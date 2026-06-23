namespace BibliotecaApp.WinForms.Forms;

// =============================================
// BookForm — Formulario para agregar/editar un libro
// =============================================
// Rol 2: formulario chico que se abre desde BookManagementForm.
//
// Controles que necesitan:
//   - TextBox para Título (txtTitle)
//   - TextBox para Autor (txtAuthor)
//   - TextBox para ISBN (txtISBN)
//   - Button "Guardar" (btnSave)
//   - Button "Cancelar" (btnCancel)
//
// Modos de uso:
//   - Nuevo libro: BookForm() → al guardar llama IBookService.CreateBook(...)
//   - Editar libro: BookForm(book) → al guardar llama IBookService.UpdateBook(...)
//
// Validaciones:
//   - Título, Autor e ISBN son obligatorios
//   - Si falta alguno: MessageBox.Show("El campo X es obligatorio.")
// =============================================

public partial class BookForm : Form
{
    public BookForm()
    {
        InitializeComponent();
    }
}
