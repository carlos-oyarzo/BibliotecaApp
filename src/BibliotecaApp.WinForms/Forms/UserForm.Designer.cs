namespace BibliotecaApp.WinForms.Forms;

partial class UserForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblName = new System.Windows.Forms.Label();
        txtName = new System.Windows.Forms.TextBox();
        lblEmail = new System.Windows.Forms.Label();
        txtEmail = new System.Windows.Forms.TextBox();
        lblRole = new System.Windows.Forms.Label();
        cmbRole = new System.Windows.Forms.ComboBox();
        lblPassword = new System.Windows.Forms.Label();
        txtPassword = new System.Windows.Forms.TextBox();
        btnSave = new System.Windows.Forms.Button();
        btnCancel = new System.Windows.Forms.Button();

        SuspendLayout();

        lblName.Text = "Nombre:";
        lblName.Location = new System.Drawing.Point(20, 22);
        lblName.Size = new System.Drawing.Size(80, 23);

        txtName.Location = new System.Drawing.Point(110, 19);
        txtName.Size = new System.Drawing.Size(260, 23);
        txtName.Name = "txtName";

        lblEmail.Text = "Correo:";
        lblEmail.Location = new System.Drawing.Point(20, 62);
        lblEmail.Size = new System.Drawing.Size(80, 23);

        txtEmail.Location = new System.Drawing.Point(110, 59);
        txtEmail.Size = new System.Drawing.Size(260, 23);
        txtEmail.Name = "txtEmail";

        lblRole.Text = "Rol:";
        lblRole.Location = new System.Drawing.Point(20, 102);
        lblRole.Size = new System.Drawing.Size(80, 23);

        cmbRole.Location = new System.Drawing.Point(110, 99);
        cmbRole.Size = new System.Drawing.Size(260, 23);
        cmbRole.Name = "cmbRole";
        cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbRole.Items.AddRange(new object[] { "Administrador", "Usuario" });

        lblPassword.Text = "Contraseña:";
        lblPassword.Location = new System.Drawing.Point(20, 142);
        lblPassword.Size = new System.Drawing.Size(80, 23);

        txtPassword.Location = new System.Drawing.Point(110, 139);
        txtPassword.Size = new System.Drawing.Size(260, 23);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';

        btnSave.Text = "Guardar";
        btnSave.Location = new System.Drawing.Point(110, 195);
        btnSave.Size = new System.Drawing.Size(100, 35);
        btnSave.BackColor = System.Drawing.Color.SteelBlue;
        btnSave.ForeColor = System.Drawing.Color.White;
        btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSave.Name = "btnSave";
        btnSave.Click += new System.EventHandler(btnSave_Click);

        btnCancel.Text = "Cancelar";
        btnCancel.Location = new System.Drawing.Point(220, 195);
        btnCancel.Size = new System.Drawing.Size(100, 35);
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Name = "btnCancel";
        btnCancel.Click += new System.EventHandler(btnCancel_Click);

        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 265);
        this.Text = "BiblioSys — Usuario";
        this.Controls.AddRange(new System.Windows.Forms.Control[]
        {
            lblName,     txtName,
            lblEmail,    txtEmail,
            lblRole,     cmbRole,
            lblPassword, txtPassword,
            btnSave,     btnCancel
        });

        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblRole;
    private System.Windows.Forms.ComboBox cmbRole;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
}