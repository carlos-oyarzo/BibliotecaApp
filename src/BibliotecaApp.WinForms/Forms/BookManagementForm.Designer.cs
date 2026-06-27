// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Diseño generado por el diseñador de Windows Forms para BookManagementForm (auto-generado).

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManagementForm));
        lblTitle = new Label();
        txtSearch = new TextBox();
        btnSearch = new Button();
        btnAdd = new Button();
        btnEdit = new Button();
        btnDelete = new Button();
        dgvBooks = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = SystemColors.ActiveCaptionText;
        lblTitle.Location = new Point(20, 15);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(350, 35);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Book Management";
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(20, 65);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search by title or author...";
        txtSearch.Size = new Size(300, 23);
        txtSearch.TabIndex = 1;
        // 
        // btnSearch
        // 
        btnSearch.FlatStyle = FlatStyle.Flat;
        btnSearch.Location = new Point(330, 63);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(80, 27);
        btnSearch.TabIndex = 2;
        btnSearch.Text = "Search";
        btnSearch.Click += btnSearch_Click;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.SteelBlue;
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(690, 63);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(90, 27);
        btnAdd.TabIndex = 3;
        btnAdd.Text = "Add New";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnEdit
        // 
        btnEdit.FlatStyle = FlatStyle.Flat;
        btnEdit.Location = new Point(790, 63);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(90, 27);
        btnEdit.TabIndex = 4;
        btnEdit.Text = "Edit";
        btnEdit.Click += btnEdit_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.Firebrick;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.ForeColor = Color.White;
        btnDelete.Location = new Point(690, 500);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(90, 27);
        btnDelete.TabIndex = 5;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // dgvBooks
        // 
        dgvBooks.AllowUserToAddRows = false;
        dgvBooks.AllowUserToDeleteRows = false;
        dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvBooks.BackgroundColor = Color.White;
        dgvBooks.BorderStyle = BorderStyle.None;
        dgvBooks.Location = new Point(20, 105);
        dgvBooks.MultiSelect = false;
        dgvBooks.Name = "dgvBooks";
        dgvBooks.ReadOnly = true;
        dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvBooks.Size = new Size(860, 380);
        dgvBooks.TabIndex = 6;
        // 
        // BookManagementForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 550);
        Controls.Add(lblTitle);
        Controls.Add(txtSearch);
        Controls.Add(btnSearch);
        Controls.Add(btnAdd);
        Controls.Add(btnEdit);
        Controls.Add(btnDelete);
        Controls.Add(dgvBooks);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "BookManagementForm";
        Text = "BibliotecaApp — Book Management";
        ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
        ResumeLayout(false);
        PerformLayout();
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