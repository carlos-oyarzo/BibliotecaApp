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
        grpNewLoan = new System.Windows.Forms.GroupBox();
        lblUser = new System.Windows.Forms.Label();
        cmbUsers = new System.Windows.Forms.ComboBox();
        lblBook = new System.Windows.Forms.Label();
        cmbBooks = new System.Windows.Forms.ComboBox();
        btnBorrow = new System.Windows.Forms.Button();
        grpActive = new System.Windows.Forms.GroupBox();
        dgvActiveLoans = new System.Windows.Forms.DataGridView();
        btnReturn = new System.Windows.Forms.Button();

        ((System.ComponentModel.ISupportInitialize)dgvActiveLoans).BeginInit();
        grpNewLoan.SuspendLayout();
        grpActive.SuspendLayout();
        SuspendLayout();

        grpNewLoan.Text = "Nuevo Préstamo";
        grpNewLoan.Font = new System.Drawing.Font("Segoe UI", 10F,
                                  System.Drawing.FontStyle.Bold);
        grpNewLoan.Location = new System.Drawing.Point(15, 15);
        grpNewLoan.Size = new System.Drawing.Size(860, 120);
        grpNewLoan.Controls.AddRange(new System.Windows.Forms.Control[]
            { lblUser, cmbUsers, lblBook, cmbBooks, btnBorrow });

        lblUser.Text = "Usuario:";
        lblUser.Location = new System.Drawing.Point(15, 35);
        lblUser.Size = new System.Drawing.Size(60, 23);

        cmbUsers.Location = new System.Drawing.Point(80, 32);
        cmbUsers.Size = new System.Drawing.Size(280, 23);
        cmbUsers.Name = "cmbUsers";
        cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        lblBook.Text = "Libro:";
        lblBook.Location = new System.Drawing.Point(380, 35);
        lblBook.Location = new System.Drawing.Point(370, 35);
        lblBook.Size = new System.Drawing.Size(50, 23);

        cmbBooks.Location = new System.Drawing.Point(425, 32);
        cmbBooks.Size = new System.Drawing.Size(280, 23);
        cmbBooks.Name = "cmbBooks";
        cmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        btnBorrow.Text = "Prestar";
        btnBorrow.Location = new System.Drawing.Point(720, 28);
        btnBorrow.Size = new System.Drawing.Size(120, 35);
        btnBorrow.BackColor = System.Drawing.Color.SteelBlue;
        btnBorrow.ForeColor = System.Drawing.Color.White;
        btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBorrow.Name = "btnBorrow";
        btnBorrow.Click += new System.EventHandler(btnBorrow_Click);

        grpActive.Text = "Préstamos Activos";
        grpActive.Font = new System.Drawing.Font("Segoe UI", 10F,
                                 System.Drawing.FontStyle.Bold);
        grpActive.Location = new System.Drawing.Point(15, 150);
        grpActive.Size = new System.Drawing.Size(860, 380);
        grpActive.Controls.AddRange(new System.Windows.Forms.Control[]
            { dgvActiveLoans, btnReturn });

        dgvActiveLoans.Location = new System.Drawing.Point(10, 30);
        dgvActiveLoans.Size = new System.Drawing.Size(840, 295);
        dgvActiveLoans.Name = "dgvActiveLoans";
        dgvActiveLoans.AllowUserToAddRows = false;
        dgvActiveLoans.AllowUserToDeleteRows = false;
        dgvActiveLoans.ReadOnly = true;
        dgvActiveLoans.SelectionMode =
            System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvActiveLoans.MultiSelect = false;
        dgvActiveLoans.AutoSizeColumnsMode =
            System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvActiveLoans.BackgroundColor = System.Drawing.Color.White;
        dgvActiveLoans.BorderStyle = System.Windows.Forms.BorderStyle.None;

        btnReturn.Text = "Devolver";
        btnReturn.Location = new System.Drawing.Point(720, 335);
        btnReturn.Size = new System.Drawing.Size(120, 35);
        btnReturn.BackColor = System.Drawing.Color.SeaGreen;
        btnReturn.ForeColor = System.Drawing.Color.White;
        btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnReturn.Name = "btnReturn";
        btnReturn.Click += new System.EventHandler(btnReturn_Click);

        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 560);
        this.Text = "BiblioSys — Gestión de Préstamos";
        this.Controls.AddRange(new System.Windows.Forms.Control[]
            { grpNewLoan, grpActive });

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