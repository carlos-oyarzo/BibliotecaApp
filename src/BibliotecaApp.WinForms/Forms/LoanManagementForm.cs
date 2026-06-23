namespace BibliotecaApp.WinForms.Forms;

// =============================================
// LoanManagementForm — Gestión de préstamos
// =============================================
// Rol 2: pantalla para prestar y devolver libros.
//
// Controles que necesitan:
//   SECCIÓN "NUEVO PRÉSTAMO":
//     - ComboBox de usuarios (cmbUsers) → llenar con IUserService.GetAllUsers()
//     - ComboBox de libros disponibles (cmbBooks) → llenar con IBookService.GetAvailableBooks()
//     - Button "Prestar" (btnBorrow) → llama a ILoanService.BorrowBook()
//     - Mostrar resultado: MessageBox con éxito o error
//
//   SECCIÓN "PRÉSTAMOS ACTIVOS":
//     - DataGridView (dgvActiveLoans) con columnas: Usuario, Libro, Préstamo, Vencimiento
//     - Button "Devolver" (btnReturn) → llama a ILoanService.ReturnBook()
//
// Lógica:
//   1. Al cargar: llenar combos y grilla de activos con ILoanService.GetActiveLoansByUser()
//      (o podés mostrar todos los activos con GetOverdueLoans filtrando)
//   2. Prestar: validar que haya usuario y libro seleccionados → BorrowBook(userId, bookId)
//   3. Devolver: tomar el préstamo seleccionado en la grilla → ReturnBook(loanId)
//   4. Refrescar la grilla después de cada operación
//
// Para obtener los servicios:
//   var loanService = Program.ServiceProvider.GetRequiredService<ILoanService>();
//   var bookService = Program.ServiceProvider.GetRequiredService<IBookService>();
//   var userService = Program.ServiceProvider.GetRequiredService<IUserService>();
// =============================================

public partial class LoanManagementForm : Form
{
    public LoanManagementForm()
    {
        InitializeComponent();
    }
}
