// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Listado y gestión de usuarios. Carga la grilla desde la API REST.

namespace BibliotecaApp.WinForms.Forms;

public partial class UserManagementForm : Form
{
    public UserManagementForm()
    {
        InitializeComponent();
        this.Load += UserManagementForm_Load;
    }

    private async void UserManagementForm_Load(object sender, EventArgs e)
    {
        SetupGridColumns();
        await LoadUsers();
    }

    private void SetupGridColumns()
    {
        dgvUsers.AutoGenerateColumns = false;
        dgvUsers.Columns.Clear();

        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Id", HeaderText = "ID", Width = 50 });
        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Name", HeaderText = "Name" });
        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Email", HeaderText = "Email" });
        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Role", HeaderText = "Role", Width = 120 });
    }

    private async Task LoadUsers()
    {
        try
        {
            var users = await Program.Api.GetUsersAsync();
            dgvUsers.DataSource = users;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading users: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        // TODO: open a UserForm in "new user" mode (form coming from Role 3)
        MessageBox.Show("Add User form — coming from Role 3.",
            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgvUsers.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a user to edit.",
                "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var row = dgvUsers.SelectedRows[0];
        string name = row.Cells["Name"].Value?.ToString() ?? "";

        // TODO: open UserForm in "edit user" mode (form coming from Role 3)
        MessageBox.Show($"Edit form for '{name}' — coming from Role 3.",
            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvUsers.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a user to delete.",
                "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var row = dgvUsers.SelectedRows[0];
        int id = Convert.ToInt32(row.Cells["Id"].Value);
        string name = row.Cells["Name"].Value?.ToString() ?? "";

        var confirm = MessageBox.Show(
            $"Are you sure you want to delete '{name}'?",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (confirm == DialogResult.Yes)
        {
            try
            {
                await Program.Api.DeleteUserAsync(id);
                MessageBox.Show("User deleted successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}