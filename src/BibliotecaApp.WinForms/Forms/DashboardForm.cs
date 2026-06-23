namespace BibliotecaApp.WinForms.Forms;

// =============================================
// DashboardForm — Pantalla principal
// =============================================
// Rol 2: este es el menú principal después del login.
//
// Controles que necesitan:
//   - Varios Button grandes para navegar:
//     * btnBooks    → "Gestión de Libros" → abre BookManagementForm
//     * btnUsers    → "Gestión de Usuarios" → abre UserManagementForm
//     * btnLoans    → "Préstamos" → abre LoanManagementForm
//     * btnOverdue  → "Préstamos Vencidos" → abre OverdueLoansForm
//   - Label con el nombre del usuario logueado (lblUserName)
//
// Recibir el usuario logueado por constructor:
//   public DashboardForm(string userName) { ... }
// =============================================

public partial class DashboardForm : Form
{
    public DashboardForm()
    {
        InitializeComponent();
    }
}
