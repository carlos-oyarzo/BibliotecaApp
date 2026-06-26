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
        lblWelcome = new System.Windows.Forms.Label();
        lblUserName = new System.Windows.Forms.Label();
        btnBooks = new System.Windows.Forms.Button();
        btnUsers = new System.Windows.Forms.Button();
        btnLoans = new System.Windows.Forms.Button();
        btnOverdue = new System.Windows.Forms.Button();

        SuspendLayout();

        lblWelcome.Text = "Bienvenido a BiblioSys";
        lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F,
                                  System.Drawing.FontStyle.Bold);
        lblWelcome.Location = new System.Drawing.Point(40, 30);
        lblWelcome.Size = new System.Drawing.Size(520, 40);
        lblWelcome.Name = "lblWelcome";

        lblUserName.Text = "";
        lblUserName.Font = new System.Drawing.Font("Segoe UI", 11F);
        lblUserName.ForeColor = System.Drawing.Color.Gray;
        lblUserName.Location = new System.Drawing.Point(40, 75);
        lblUserName.Size = new System.Drawing.Size(520, 25);
        lblUserName.Name = "lblUserName";

        btnBooks.Text = "Gestión de Libros";
        btnBooks.Location = new System.Drawing.Point(40, 130);
        btnBooks.Size = new System.Drawing.Size(240, 70);
        btnBooks.Font = new System.Drawing.Font("Segoe UI", 12F);
        btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBooks.BackColor = System.Drawing.Color.SteelBlue;
        btnBooks.ForeColor = System.Drawing.Color.White;
        btnBooks.Name = "btnBooks";
        btnBooks.Click += new System.EventHandler(btnBooks_Click);

        btnUsers.Text = "Gestión de Usuarios";
        btnUsers.Location = new System.Drawing.Point(310, 130);
        btnUsers.Size = new System.Drawing.Size(240, 70);
        btnUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
        btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnUsers.BackColor = System.Drawing.Color.SeaGreen;
        btnUsers.ForeColor = System.Drawing.Color.White;
        btnUsers.Name = "btnUsers";
        btnUsers.Click += new System.EventHandler(btnUsers_Click);

        btnLoans.Text = "Préstamos";
        btnLoans.Location = new System.Drawing.Point(40, 230);
        btnLoans.Size = new System.Drawing.Size(240, 70);
        btnLoans.Font = new System.Drawing.Font("Segoe UI", 12F);
        btnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLoans.BackColor = System.Drawing.Color.DarkOrange;
        btnLoans.ForeColor = System.Drawing.Color.White;
        btnLoans.Name = "btnLoans";
        btnLoans.Click += new System.EventHandler(btnLoans_Click);

        btnOverdue.Text = "Préstamos Vencidos";
        btnOverdue.Location = new System.Drawing.Point(310, 230);
        btnOverdue.Size = new System.Drawing.Size(240, 70);
        btnOverdue.Font = new System.Drawing.Font("Segoe UI", 12F);
        btnOverdue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOverdue.BackColor = System.Drawing.Color.Firebrick;
        btnOverdue.ForeColor = System.Drawing.Color.White;
        btnOverdue.Name = "btnOverdue";
        btnOverdue.Click += new System.EventHandler(btnOverdue_Click);

        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(600, 360);
        this.Text = "BiblioSys — Panel Principal";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Controls.AddRange(new System.Windows.Forms.Control[]
        {
            lblWelcome, lblUserName,
            btnBooks, btnUsers, btnLoans, btnOverdue
        });

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