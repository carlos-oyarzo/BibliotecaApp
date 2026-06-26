namespace BibliotecaApp.WinForms.Forms;

partial class BookManagementForm
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
        lblTitle = new System.Windows.Forms.Label();
        txtSearch = new System.Windows.Forms.TextBox();
        btnSearch = new System.Windows.Forms.Button();
        btnAdd = new System.Windows.Forms.Button();
        btnEdit = new System.Windows.Forms.Button();
        btnDelete = new System.Windows.Forms.Button();
        dgvBooks = new System.Windows.Forms.DataGridView();

        ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
        SuspendLayout();

        lblTitle.Text = "Gestión de Libros";
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F,
                                System.Drawing.FontStyle.Bold);
        lblTitle.Location = new System.Drawing.Point(20, 15);
        lblTitle.Size = new System.Drawing.Size(350, 35);
        lblTitle.Name = "lblTitle";

        txtSearch.Location = new System.Drawing.Point(20, 65);
        txtSearch.Size = new System.Drawing.Size(300, 23);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Buscar por título o autor...";

        btnSearch.Text = "Buscar";
        btnSearch.Location = new System.Drawing.Point(330, 63);
        btnSearch.Size = new System.Drawing.Size(80, 27);
        btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSearch.Name = "btnSearch";
        btnSearch.Click += new System.EventHandler(btnSearch_Click);

        btnAdd.Text = "Agregar";
        btnAdd.Location = new System.Drawing.Point(690, 63);
        btnAdd.Size = new System.Drawing.Size(90, 27);
        btnAdd.BackColor = System.Drawing.Color.SteelBlue;
        btnAdd.ForeColor = System.Drawing.Color.White;
        btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAdd.Name = "btnAdd";
        btnAdd.Click += new System.EventHandler(btnAdd_Click);

        btnEdit.Text = "Editar";
        btnEdit.Location = new System.Drawing.Point(790, 63);
        btnEdit.Size = new System.Drawing.Size(90, 27);
        btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEdit.Name = "btnEdit";
        btnEdit.Click += new System.EventHandler(btnEdit_Click);

        btnDelete.Text = "Eliminar";
        btnDelete.Location = new System.Drawing.Point(690, 500);
        btnDelete.Size = new System.Drawing.Size(90, 27);
        btnDelete.BackColor = System.Drawing.Color.Firebrick;
        btnDelete.ForeColor = System.Drawing.Color.White;
        btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDelete.Name = "btnDelete";
        btnDelete.Click += new System.EventHandler(btnDelete_Click);

        dgvBooks.Location = new System.Drawing.Point(20, 105);
        dgvBooks.Size = new System.Drawing.Size(860, 380);
        dgvBooks.Name = "dgvBooks";
        dgvBooks.AllowUserToAddRows = false;
        dgvBooks.AllowUserToDeleteRows = false;
        dgvBooks.ReadOnly = true;
        dgvBooks.SelectionMode =
            System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvBooks.MultiSelect = false;
        dgvBooks.AutoSizeColumnsMode =
            System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvBooks.BackgroundColor = System.Drawing.Color.White;
        dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;

        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 550);
        this.Text = "BiblioSys — Gestión de Libros";
        this.Controls.AddRange(new System.Windows.Forms.Control[]
        {
            lblTitle, txtSearch, btnSearch,
            btnAdd, btnEdit, btnDelete,
            dgvBooks
        });

        ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.DataGridView dgvBooks;
}