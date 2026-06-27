// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Diseño generado por el diseñador de Windows Forms para LoanManagementForm (auto-generado).

namespace BibliotecaApp.WinForms.Forms;

partial class LoanManagementForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanManagementForm));
        grpNewLoan = new GroupBox();
        lblUser = new Label();
        cmbUsers = new ComboBox();
        lblBook = new Label();
        cmbBooks = new ComboBox();
        btnBorrow = new Button();
        grpActive = new GroupBox();
        dgvActiveLoans = new DataGridView();
        btnReturn = new Button();
        grpNewLoan.SuspendLayout();
        grpActive.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvActiveLoans).BeginInit();
        SuspendLayout();
        // 
        // grpNewLoan
        // 
        grpNewLoan.Controls.Add(lblUser);
        grpNewLoan.Controls.Add(cmbUsers);
        grpNewLoan.Controls.Add(lblBook);
        grpNewLoan.Controls.Add(cmbBooks);
        grpNewLoan.Controls.Add(btnBorrow);
        grpNewLoan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpNewLoan.Location = new Point(15, 15);
        grpNewLoan.Name = "grpNewLoan";
        grpNewLoan.Size = new Size(860, 120);
        grpNewLoan.TabIndex = 0;
        grpNewLoan.TabStop = false;
        grpNewLoan.Text = "New Loan";
        // 
        // lblUser
        // 
        lblUser.Location = new Point(15, 35);
        lblUser.Name = "lblUser";
        lblUser.Size = new Size(50, 23);
        lblUser.TabIndex = 0;
        lblUser.Text = "User:";
        // 
        // cmbUsers
        // 
        cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbUsers.Location = new Point(70, 32);
        cmbUsers.Name = "cmbUsers";
        cmbUsers.Size = new Size(280, 25);
        cmbUsers.TabIndex = 1;
        // 
        // lblBook
        // 
        lblBook.Location = new Point(370, 35);
        lblBook.Name = "lblBook";
        lblBook.Size = new Size(50, 23);
        lblBook.TabIndex = 2;
        lblBook.Text = "Book:";
        // 
        // cmbBooks
        // 
        cmbBooks.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbBooks.Location = new Point(425, 32);
        cmbBooks.Name = "cmbBooks";
        cmbBooks.Size = new Size(280, 25);
        cmbBooks.TabIndex = 3;
        // 
        // btnBorrow
        // 
        btnBorrow.BackColor = Color.SteelBlue;
        btnBorrow.FlatStyle = FlatStyle.Flat;
        btnBorrow.ForeColor = Color.White;
        btnBorrow.Location = new Point(720, 28);
        btnBorrow.Name = "btnBorrow";
        btnBorrow.Size = new Size(120, 35);
        btnBorrow.TabIndex = 4;
        btnBorrow.Text = "Lend Book";
        btnBorrow.UseVisualStyleBackColor = false;
        btnBorrow.Click += btnBorrow_Click;
        // 
        // grpActive
        // 
        grpActive.Controls.Add(dgvActiveLoans);
        grpActive.Controls.Add(btnReturn);
        grpActive.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpActive.Location = new Point(15, 150);
        grpActive.Name = "grpActive";
        grpActive.Size = new Size(860, 380);
        grpActive.TabIndex = 1;
        grpActive.TabStop = false;
        grpActive.Text = "Active Loans";
        // 
        // dgvActiveLoans
        // 
        dgvActiveLoans.AllowUserToAddRows = false;
        dgvActiveLoans.AllowUserToDeleteRows = false;
        dgvActiveLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvActiveLoans.BackgroundColor = Color.White;
        dgvActiveLoans.BorderStyle = BorderStyle.None;
        dgvActiveLoans.Location = new Point(10, 30);
        dgvActiveLoans.MultiSelect = false;
        dgvActiveLoans.Name = "dgvActiveLoans";
        dgvActiveLoans.ReadOnly = true;
        dgvActiveLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvActiveLoans.Size = new Size(840, 295);
        dgvActiveLoans.TabIndex = 0;
        // 
        // btnReturn
        // 
        btnReturn.BackColor = Color.SeaGreen;
        btnReturn.FlatStyle = FlatStyle.Flat;
        btnReturn.ForeColor = Color.White;
        btnReturn.Location = new Point(720, 335);
        btnReturn.Name = "btnReturn";
        btnReturn.Size = new Size(120, 35);
        btnReturn.TabIndex = 1;
        btnReturn.Text = "Return Book";
        btnReturn.UseVisualStyleBackColor = false;
        btnReturn.Click += btnReturn_Click;
        // 
        // LoanManagementForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 560);
        Controls.Add(grpNewLoan);
        Controls.Add(grpActive);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "LoanManagementForm";
        Text = "BibliotecaApp — Loan Management";
        grpNewLoan.ResumeLayout(false);
        grpActive.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvActiveLoans).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.GroupBox grpNewLoan;
    private System.Windows.Forms.Label lblUser;
    private System.Windows.Forms.ComboBox cmbUsers;
    private System.Windows.Forms.Label lblBook;
    private System.Windows.Forms.ComboBox cmbBooks;
    private System.Windows.Forms.Button btnBorrow;
    private System.Windows.Forms.GroupBox grpActive;
    private System.Windows.Forms.DataGridView dgvActiveLoans;
    private System.Windows.Forms.Button btnReturn;
}