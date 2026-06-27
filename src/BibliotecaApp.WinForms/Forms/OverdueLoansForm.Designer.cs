// ─── Responsable: Deisy Jaramillo — Rol 2 (frontend) ───
// Diseño generado por el diseñador de Windows Forms para OverdueLoansForm (auto-generado).

namespace BibliotecaApp.WinForms.Forms;

partial class OverdueLoansForm
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
        lblCount = new System.Windows.Forms.Label();
        dgvOverdue = new System.Windows.Forms.DataGridView();
        btnRefresh = new System.Windows.Forms.Button();

        ((System.ComponentModel.ISupportInitialize)dgvOverdue).BeginInit();
        SuspendLayout();

        lblTitle.Text = "Overdue Loans";
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F,
                                System.Drawing.FontStyle.Bold);
        lblTitle.Location = new System.Drawing.Point(20, 15);
        lblTitle.Size = new System.Drawing.Size(300, 35);
        lblTitle.Name = "lblTitle";

        lblCount.Text = "";
        lblCount.Font = new System.Drawing.Font("Segoe UI", 10F);
        lblCount.ForeColor = System.Drawing.Color.Firebrick;
        lblCount.Location = new System.Drawing.Point(20, 55);
        lblCount.Size = new System.Drawing.Size(400, 25);
        lblCount.Name = "lblCount";

        dgvOverdue.Location = new System.Drawing.Point(20, 90);
        dgvOverdue.Size = new System.Drawing.Size(860, 390);
        dgvOverdue.Name = "dgvOverdue";
        dgvOverdue.AllowUserToAddRows = false;
        dgvOverdue.AllowUserToDeleteRows = false;
        dgvOverdue.ReadOnly = true;
        dgvOverdue.SelectionMode =
            System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvOverdue.AutoSizeColumnsMode =
            System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvOverdue.BackgroundColor = System.Drawing.Color.White;
        dgvOverdue.BorderStyle = System.Windows.Forms.BorderStyle.None;

        btnRefresh.Text = "Refresh";
        btnRefresh.Location = new System.Drawing.Point(760, 50);
        btnRefresh.Size = new System.Drawing.Size(120, 30);
        btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Click += new System.EventHandler(btnRefresh_Click);

        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(900, 520);
        this.Text = "BibliotecaApp — Overdue Loans";
        this.Controls.AddRange(new System.Windows.Forms.Control[]
            { lblTitle, lblCount, dgvOverdue, btnRefresh });

        ((System.ComponentModel.ISupportInitialize)dgvOverdue).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblCount;
    private System.Windows.Forms.DataGridView dgvOverdue;
    private System.Windows.Forms.Button btnRefresh;
}