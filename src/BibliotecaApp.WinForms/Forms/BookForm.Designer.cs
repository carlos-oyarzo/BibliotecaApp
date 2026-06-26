namespace BibliotecaApp.WinForms.Forms;

partial class BookForm
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
        txtTitle = new System.Windows.Forms.TextBox();
        lblAuthor = new System.Windows.Forms.Label();
        txtAuthor = new System.Windows.Forms.TextBox();
        lblISBN = new System.Windows.Forms.Label();
        txtISBN = new System.Windows.Forms.TextBox();
        btnSave = new System.Windows.Forms.Button();
        btnCancel = new System.Windows.Forms.Button();

        SuspendLayout();

        lblTitle.Text = "Título:";
        lblTitle.Location = new System.Drawing.Point(20, 22);
        lblTitle.Size = new System.Drawing.Size(80, 23);

        txtTitle.Location = new System.Drawing.Point(110, 19);
        txtTitle.Size = new System.Drawing.Size(260, 23);
        txtTitle.Name = "txtTitle";

        lblAuthor.Text = "Autor:";
        lblAuthor.Location = new System.Drawing.Point(20, 62);
        lblAuthor.Size = new System.Drawing.Size(80, 23);

        txtAuthor.Location = new System.Drawing.Point(110, 59);
        txtAuthor.Size = new System.Drawing.Size(260, 23);
        txtAuthor.Name = "txtAuthor";

        lblISBN.Text = "ISBN:";
        lblISBN.Location = new System.Drawing.Point(20, 102);
        lblISBN.Size = new System.Drawing.Size(80, 23);

        txtISBN.Location = new System.Drawing.Point(110, 99);
        txtISBN.Size = new System.Drawing.Size(260, 23);
        txtISBN.Name = "txtISBN";

        btnSave.Text = "Guardar";
        btnSave.Location = new System.Drawing.Point(110, 150);
        btnSave.Size = new System.Drawing.Size(100, 35);
        btnSave.BackColor = System.Drawing.Color.SteelBlue;
        btnSave.ForeColor = System.Drawing.Color.White;
        btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSave.Name = "btnSave";
        btnSave.Click += new System.EventHandler(btnSave_Click);

        btnCancel.Text = "Cancelar";
        btnCancel.Location = new System.Drawing.Point(220, 150);
        btnCancel.Size = new System.Drawing.Size(100, 35);
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCancel.Name = "btnCancel";
        btnCancel.Click += new System.EventHandler(btnCancel_Click);

        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 220);
        this.Text = "BibliotecaApp — Libro";
        this.Controls.AddRange(new System.Windows.Forms.Control[]
        {
            lblTitle,  txtTitle,
            lblAuthor, txtAuthor,
            lblISBN,   txtISBN,
            btnSave,   btnCancel
        });

        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TextBox txtTitle;
    private System.Windows.Forms.Label lblAuthor;
    private System.Windows.Forms.TextBox txtAuthor;
    private System.Windows.Forms.Label lblISBN;
    private System.Windows.Forms.TextBox txtISBN;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
}