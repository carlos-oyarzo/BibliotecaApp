namespace BibliotecaApp.WinForms.Forms;

public partial class UserManagementForm : Form
{
    public UserManagementForm()
    {
        InitializeComponent();
        this.Load += UserManagementForm_Load;
    }

    private void UserManagementForm_Load(object sender, EventArgs e)
    {
        SetupGridColumns();
        LoadUsers();
    }

    private void SetupGridColumns()
    {
        dgvUsers.Columns.Clear();

        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Id", HeaderText = "ID", Width = 50 });
        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Name", HeaderText = "Nombre" });
        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Email", HeaderText = "Correo" });
        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Role", HeaderText = "Rol", Width = 120 });
    }

    private void LoadUsers()
    {
        // TODO: reemplazar con _userService.GetAllUsers()
        var sampleUsers = new[]
        {
            new { Id = 1, Name = "Alice Johnson",
                  Email = "alice@library.com", Role = "Administrador" },
            new { Id = 2, Name = "Bob Martinez",
                  Email = "bob@library.com",   Role = "Usuario" },
            new { Id = 3, Name = "Carol White",
                  Email = "carol@library.com", Role = "Usuario" },
        };
        dgvUsers.DataSource = sampleUsers;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using var form = new UserForm();
        if (form.ShowDialog() == DialogResult.OK)
            LoadUsers();
    }
    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvUsers.SelectedRows.Count == 0)
        {
            MessageBox.Show("Por favor selecciona un usuario para editar.",
                "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var row = dgvUsers.SelectedRows[0];
        int id = Convert.ToInt32(row.Cells["Id"].Value);
        string name = row.Cells["Name"].Value?.ToString() ?? "";
        string email = row.Cells["Email"].Value?.ToString() ?? "";
        string role = row.Cells["Role"].Value?.ToString() ?? "";

        using var form = new UserForm(id, name, email, role);
        if (form.ShowDialog() == DialogResult.OK)
            LoadUsers();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvUsers.SelectedRows.Count == 0)
        {
            MessageBox.Show("Por favor selecciona un usuario para eliminar.",
                "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var row = dgvUsers.SelectedRows[0];
        string name = row.Cells["Name"].Value?.ToString() ?? "";

        var confirm = MessageBox.Show(
            $"¿Estás seguro de que deseas eliminar a '{name}'?",
            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (confirm == DialogResult.Yes)
        {
            // TODO: reemplazar con _userService.DeleteUser(id)
            MessageBox.Show("Usuario eliminado correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsers();
        }
    }
}