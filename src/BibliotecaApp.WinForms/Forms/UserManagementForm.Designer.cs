namespace BibliotecaApp.WinForms.Forms;

partial class UserManagementForm
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
        dgvUsers = new System.Windows.Forms.DataGridView();
        btnAdd = new System.Windows.Forms.Button();
        btnEdit = new System.Windows.Forms.Button();
        btnDelete = new System.Windows.Forms.Button();

        ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
        SuspendLayout();

        lblTitle.Text = "User Management";
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F,
                                System.Drawing.FontStyle.Bold);
        lblTitle.Location = new System.Drawing.Point(20, 15);
        lblTitle.Size = new System.Drawing.Size(300, 35);
        lblTitle.Name = "lblTitle";

        dgvUsers.Location = new System.Drawing.Point(20, 65);
        dgvUsers.Size = new System.Drawing.Size(860, 400);
        dgvUsers.Name = "dgvUsers";
        dgvUsers.AllowUserToAddRows = false;
        dgvUsers.AllowUserToDeleteRows = false;
        dgvUsers.ReadOnly = true;
        dgvUsers.SelectionMode =
            System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvUsers.MultiSelect = false;
        dgvUsers.AutoSizeColumnsMode =
            System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvUsers.BackgroundColor = System.Drawing.Color.White;
        dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;

        btnAdd.Text = "Add User";
        btnAdd.Location = new System.Drawing.Point(20, 480);
        btnAdd.Size = new System.Drawing.Size(110, 35);
        btnAdd.BackColor = System.Drawing.Color.SteelBlue;
        btnAdd.ForeColor = System.Drawing.Color.White;
        btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAdd.Name = "btnAdd";
        btnAdd.Click += new System.EventHandler(btnAdd_Click);

        btnEdit.Text = "Edit User";
        btnEdit.Location = new System.Drawing.Point(140, 480);
        btnEdit.Size = new System.Drawing.Size(110, 35);
        btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEdit.Name = "btnEdit";
        btnEdit.Click += new System.EventHandler(btnEdit_Click);

        btnDelete.Text = "Delete User";
        btnDelete.Location = new System.Drawing.Point(770, 480);
        btnDelete.Size = new System.Drawing.Size(110, 35);
        btnDelete.BackColor = System.Drawing.Color.Firebrick;
        btnDelete.ForeColor = System.Drawing.Color.White;
        btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDelete.Name = "btnDelete";
        btnDelete.Click += new System.EventHandler(btnDelete_Click);

        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 540);
        this.Text = "BibliotecaApp — User Management";
        this.Controls.AddRange(new System.Windows.Forms.Control[]
            { lblTitle, dgvUsers, btnAdd, btnEdit, btnDelete });

        ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.DataGridView dgvUsers;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnDelete;
}