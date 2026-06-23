namespace BibliotecaApp.WinForms.Forms;

// =============================================
// UserManagementForm — Gestión de usuarios (CRUD)
// =============================================
// Rol 2: pantalla para administrar usuarios del sistema.
//
// Controles que necesitan:
//   - DataGridView (dgvUsers) con columnas: Nombre, Email, Rol
//   - Button "Agregar" (btnAdd) → abre formulario de edición
//   - Button "Editar" (btnEdit) → edita el usuario seleccionado
//   - Button "Eliminar" (btnDelete) → confirma y borra
//
// Lógica:
//   1. Al cargar: llenar dgvUsers con IUserService.GetAllUsers()
//   2. Agregar/Editar: abrir un formulario con campos Nombre, Email, Rol
//   3. Eliminar: MessageBox confirmación → IUserService.DeleteUser(id)
//
// Para obtener el servicio:
//   var userService = Program.ServiceProvider.GetRequiredService<IUserService>();
// =============================================

public partial class UserManagementForm : Form
{
    public UserManagementForm()
    {
        InitializeComponent();
    }
}
