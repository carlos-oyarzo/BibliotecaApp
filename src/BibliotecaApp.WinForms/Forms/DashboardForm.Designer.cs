// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Diseño generado por el diseñador de Windows Forms para DashboardForm (auto-generado).

namespace BibliotecaApp.WinForms.Forms;

partial class DashboardForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
        lblWelcome = new Label();
        lblUserName = new Label();
        btnBooks = new Button();
        btnUsers = new Button();
        btnLoans = new Button();
        btnOverdue = new Button();
        SuspendLayout();
        // 
        // lblWelcome
        // 
        lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblWelcome.Location = new Point(40, 30);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Size = new Size(520, 40);
        lblWelcome.TabIndex = 0;
        lblWelcome.Text = "Welcome to BibliotecaApp";
        // 
        // lblUserName
        // 
        lblUserName.Font = new Font("Segoe UI", 11F);
        lblUserName.ForeColor = Color.Gray;
        lblUserName.Location = new Point(40, 75);
        lblUserName.Name = "lblUserName";
        lblUserName.Size = new Size(520, 25);
        lblUserName.TabIndex = 1;
        // 
        // btnBooks
        // 
        btnBooks.BackColor = Color.SteelBlue;
        btnBooks.FlatStyle = FlatStyle.Flat;
        btnBooks.Font = new Font("Segoe UI", 12F);
        btnBooks.ForeColor = Color.White;
        btnBooks.Location = new Point(40, 130);
        btnBooks.Name = "btnBooks";
        btnBooks.Size = new Size(240, 70);
        btnBooks.TabIndex = 2;
        btnBooks.Text = "📚  Book Management";
        btnBooks.UseVisualStyleBackColor = false;
        btnBooks.Click += btnBooks_Click;
        // 
        // btnUsers
        // 
        btnUsers.BackColor = Color.SeaGreen;
        btnUsers.FlatStyle = FlatStyle.Flat;
        btnUsers.Font = new Font("Segoe UI", 12F);
        btnUsers.ForeColor = Color.White;
        btnUsers.Location = new Point(310, 130);
        btnUsers.Name = "btnUsers";
        btnUsers.Size = new Size(240, 70);
        btnUsers.TabIndex = 3;
        btnUsers.Text = "👤  User Management";
        btnUsers.UseVisualStyleBackColor = false;
        btnUsers.Click += btnUsers_Click;
        // 
        // btnLoans
        // 
        btnLoans.BackColor = Color.DarkOrange;
        btnLoans.FlatStyle = FlatStyle.Flat;
        btnLoans.Font = new Font("Segoe UI", 12F);
        btnLoans.ForeColor = Color.White;
        btnLoans.Location = new Point(40, 230);
        btnLoans.Name = "btnLoans";
        btnLoans.Size = new Size(240, 70);
        btnLoans.TabIndex = 4;
        btnLoans.Text = "📋  Loan Management";
        btnLoans.UseVisualStyleBackColor = false;
        btnLoans.Click += btnLoans_Click;
        // 
        // btnOverdue
        // 
        btnOverdue.BackColor = Color.Firebrick;
        btnOverdue.FlatStyle = FlatStyle.Flat;
        btnOverdue.Font = new Font("Segoe UI", 12F);
        btnOverdue.ForeColor = Color.White;
        btnOverdue.Location = new Point(310, 230);
        btnOverdue.Name = "btnOverdue";
        btnOverdue.Size = new Size(240, 70);
        btnOverdue.TabIndex = 5;
        btnOverdue.Text = "⚠️  Overdue Loans";
        btnOverdue.UseVisualStyleBackColor = false;
        btnOverdue.Click += btnOverdue_Click;
        // 
        // DashboardForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(600, 360);
        Controls.Add(lblWelcome);
        Controls.Add(lblUserName);
        Controls.Add(btnBooks);
        Controls.Add(btnUsers);
        Controls.Add(btnLoans);
        Controls.Add(btnOverdue);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "DashboardForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "BibliotecaApp — Dashboard";
        Load += DashboardForm_Load;
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblWelcome;
    private System.Windows.Forms.Label lblUserName;
    private System.Windows.Forms.Button btnBooks;
    private System.Windows.Forms.Button btnUsers;
    private System.Windows.Forms.Button btnLoans;
    private System.Windows.Forms.Button btnOverdue;
}