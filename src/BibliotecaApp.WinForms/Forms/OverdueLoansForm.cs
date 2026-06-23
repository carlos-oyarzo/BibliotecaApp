namespace BibliotecaApp.WinForms.Forms;

// =============================================
// OverdueLoansForm — Préstamos vencidos
// =============================================
// Rol 2: pantalla para ver préstamos fuera de término.
//
// Controles que necesitan:
//   - DataGridView (dgvOverdue) con columnas:
//       Usuario, Libro, Fecha préstamo, Fecha vencimiento, Días de atraso
//   - Button "Actualizar" (btnRefresh)
//   - Label con cantidad de préstamos vencidos
//
// Lógica:
//   1. Al cargar: llenar dgvOverdue con ILoanService.GetOverdueLoans()
//   2. Calcular "Días de atraso" = DateTime.Today - préstamo.DueDate
//   3. Botón Actualizar: vuelve a cargar los datos
//
// Para obtener el servicio:
//   var loanService = Program.ServiceProvider.GetRequiredService<ILoanService>();
// =============================================

public partial class OverdueLoansForm : Form
{
    public OverdueLoansForm()
    {
        InitializeComponent();
    }
}
