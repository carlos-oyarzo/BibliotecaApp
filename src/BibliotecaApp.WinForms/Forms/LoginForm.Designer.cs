// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Diseño generado por el diseñador de Windows Forms para LoginForm (auto-generado).

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
        lblAppName = new Label();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblPassword = new Label();
        txtPassword = new TextBox();
        btnLogin = new Button();
        SuspendLayout();
        // 
        // lblAppName
        // 
        lblAppName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblAppName.Location = new Point(50, 30);
        lblAppName.Name = "lblAppName";
        lblAppName.Size = new Size(300, 45);
        lblAppName.TabIndex = 0;
        lblAppName.Text = "BibliotecaApp";
        lblAppName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblEmail
        // 
        lblEmail.Location = new Point(50, 100);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(80, 23);
        lblEmail.TabIndex = 1;
        lblEmail.Text = "Email:";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(50, 125);
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "user@email.com";
        txtEmail.Size = new Size(300, 23);
        txtEmail.TabIndex = 2;
        txtEmail.TextChanged += txtEmail_TextChanged;
        // 
        // lblPassword
        // 
        lblPassword.Location = new Point(50, 165);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(80, 23);
        lblPassword.TabIndex = 3;
        lblPassword.Text = "Password:";
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(50, 190);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(300, 23);
        txtPassword.TabIndex = 4;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.SteelBlue;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Segoe UI", 11F);
        btnLogin.ForeColor = Color.White;
        btnLogin.Location = new Point(50, 240);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(300, 40);
        btnLogin.TabIndex = 5;
        btnLogin.Text = "Sign In";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 320);
        Controls.Add(lblAppName);
        Controls.Add(lblEmail);
        Controls.Add(txtEmail);
        Controls.Add(lblPassword);
        Controls.Add(txtPassword);
        Controls.Add(btnLogin);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "BibliotecaApp — Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblAppName;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
}