namespace BibliotecaApp.WinForms.Forms;

public partial class UserForm : Form
{
    private int _userId = 0;

    // Constructor para NUEVO usuario
    public UserForm()
    {
        InitializeComponent();
        this.Text = "Nuevo Usuario";
        cmbRole.SelectedIndex = 1;
    }

    // Constructor para EDITAR usuario existente
    public UserForm(int userId, string name, string email, string role)
    {
        InitializeComponent();
        _userId = userId;
        txtName.Text = name;
        txtEmail.Text = email;
        cmbRole.SelectedItem = role;
        txtPassword.PlaceholderText = "Dejar vacío para no cambiar";
        this.Text = "Editar Usuario";
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string email = txtEmail.Text.Trim();
        string role = cmbRole.SelectedItem?.ToString() ?? "";
        string password = txtPassword.Text.Trim();

        if (string.IsNullOrEmpty(name))
        {
            MessageBox.Show("El campo Nombre es obligatorio.",
                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtName.Focus();
            return;
        }

        if (string.IsNullOrEmpty(email))
        {
            MessageBox.Show("El campo Correo es obligatorio.",
                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmail.Focus();
            return;
        }

        if (!email.Contains("@") || !email.Contains("."))
        {
            MessageBox.Show("Por favor ingresa un correo electrónico válido.",
                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmail.Focus();
            return;
        }

        if (string.IsNullOrEmpty(role))
        {
            MessageBox.Show("Por favor selecciona un rol.",
                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbRole.Focus();
            return;
        }

        if (_userId == 0 && string.IsNullOrEmpty(password))
        {
            MessageBox.Show("El campo Contraseña es obligatorio para nuevos usuarios.",
                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPassword.Focus();
            return;
        }

        if (_userId == 0)
        {
            // TODO: reemplazar con _userService.CreateUser(name, email, role, password)
            MessageBox.Show($"Usuario '{name}' creado correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            // TODO: reemplazar con _userService.UpdateUser(_userId, name, email, role, password)
            MessageBox.Show($"Usuario '{name}' actualizado correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}