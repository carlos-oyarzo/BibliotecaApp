namespace BibliotecaApp.WinForms.Forms;

partial class LoginForm
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
        lblAppName = new System.Windows.Forms.Label();
        lblEmail = new System.Windows.Forms.Label();
        txtEmail = new System.Windows.Forms.TextBox();
        lblPassword = new System.Windows.Forms.Label();
        txtPassword = new System.Windows.Forms.TextBox();
        btnLogin = new System.Windows.Forms.Button();

        SuspendLayout();

        lblAppName.Text = "BiblioSys";
        lblAppName.Font = new System.Drawing.Font("Segoe UI", 20F,
                                   System.Drawing.FontStyle.Bold);
        lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        lblAppName.Location = new System.Drawing.Point(50, 30);
        lblAppName.Size = new System.Drawing.Size(300, 45);
        lblAppName.Name = "lblAppName";

        lblEmail.Text = "Correo electrónico:";
        lblEmail.Location = new System.Drawing.Point(50, 100);
        lblEmail.Size = new System.Drawing.Size(140, 23);

        txtEmail.Location = new System.Drawing.Point(50, 125);
        txtEmail.Size = new System.Drawing.Size(300, 23);
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "usuario@correo.com";

        lblPassword.Text = "Contraseña:";
        lblPassword.Location = new System.Drawing.Point(50, 165);
        lblPassword.Size = new System.Drawing.Size(100, 23);

        txtPassword.Location = new System.Drawing.Point(50, 190);
        txtPassword.Size = new System.Drawing.Size(300, 23);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';

        btnLogin.Text = "Iniciar Sesión";
        btnLogin.Location = new System.Drawing.Point(50, 240);
        btnLogin.Size = new System.Drawing.Size(300, 40);
        btnLogin.BackColor = System.Drawing.Color.SteelBlue;
        btnLogin.ForeColor = System.Drawing.Color.White;
        btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F);
        btnLogin.Name = "btnLogin";
        btnLogin.Click += new System.EventHandler(btnLogin_Click);

        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 320);
        this.Text = "BiblioSys — Iniciar Sesión";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Controls.AddRange(new System.Windows.Forms.Control[]
        {
            lblAppName, lblEmail, txtEmail,
            lblPassword, txtPassword, btnLogin
        });

        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblAppName;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
}