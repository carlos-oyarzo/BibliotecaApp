namespace BibliotecaApp.WinForms.Forms;

// =============================================
// BookManagementForm — Gestión de libros (CRUD)
// =============================================
// Rol 2: acá va la pantalla para administrar el catálogo de libros.
//
// Controles que necesitan:
//   - DataGridView (dgvBooks) con columnas: Título, Autor, ISBN, Disponible
//   - TextBox para buscar (txtSearch) + Button "Buscar" (btnSearch)
//   - Button "Agregar" (btnAdd) → abre BookForm en modo nuevo
//   - Button "Editar" (btnEdit) → abre BookForm con el libro seleccionado
//   - Button "Eliminar" (btnDelete) → confirma y borra
//
// Lógica:
//   1. Al cargar: llenar dgvBooks con IBookService.GetAllBooks()
//   2. Buscar: filtrar con IBookService.SearchBooks(txtSearch.Text)
//   3. Agregar/Editar: abrir BookForm, al cerrar refrescar la grilla
//   4. Eliminar: MessageBox confirmación → IBookService.DeleteBook(id)
//
// Para obtener el servicio:
//   var bookService = Program.ServiceProvider.GetRequiredService<IBookService>();
// =============================================

public partial class BookManagementForm : Form
{
    public BookManagementForm()
    {
        InitializeComponent();
    }
}
