namespace ElectroJoule.UI
{
    partial class frmBaseHijo
    {
        private System.ComponentModel.IContainer components = null;
        protected System.Windows.Forms.Panel pnlEncabezado;
        protected System.Windows.Forms.Label lblTituloForm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();

            // pnlEncabezado
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Height = 40;
            this.pnlEncabezado.Controls.Add(this.lblTituloForm);

            // lblTituloForm
            this.lblTituloForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI Semibold", 12f);
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloForm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTituloForm.Text = "Título";

            // frmBaseHijo
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.Controls.Add(this.pnlEncabezado);

            this.pnlEncabezado.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
