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
        { DataPropertyName = "Name", HeaderText = "Name" });
        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Email", HeaderText = "Email" });
        dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
        { DataPropertyName = "Role", HeaderText = "Role", Width = 120 });
    }

    // TODO: replace with _userService.GetAllUsers()
    private void LoadUsers()
    {
        var sampleUsers = new[]
        {
            new { Id = 1, Name = "Alice Johnson", Email = "alice@library.com",
                  Role = "Admin" },
            new { Id = 2, Name = "Bob Martinez",  Email = "bob@library.com",
                  Role = "User" },
            new { Id = 3, Name = "Carol White",   Email = "carol@library.com",
                  Role = "User" },
        };
        dgvUsers.DataSource = sampleUsers;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        // TODO: open a UserForm in "new user" mode
        MessageBox.Show("Add User form — coming from Role 3.",
            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        LoadUsers();
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

        // TODO: open UserForm in "edit user" mode
        MessageBox.Show($"Edit form for '{name}' — coming from Role 3.",
            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        LoadUsers();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvUsers.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a user to delete.",
                "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var row = dgvUsers.SelectedRows[0];
        string name = row.Cells["Name"].Value?.ToString() ?? "";

        var confirm = MessageBox.Show(
            $"Are you sure you want to delete '{name}'?",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (confirm == DialogResult.Yes)
        {
            // TODO: replace with _userService.DeleteUser(id)
            MessageBox.Show("User deleted successfully.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsers();
        }
    }
}