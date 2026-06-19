namespace ElectroJoule.UI
{
    partial class frmComprobante
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblClienteComp;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlVisor;
        private System.Windows.Forms.Label lblVisorTodo;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Button btnDescargarPdf;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblClienteComp = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlVisor = new System.Windows.Forms.Panel();
            this.lblVisorTodo = new System.Windows.Forms.Label();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.btnDescargarPdf = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.pnlVisor.SuspendLayout();
            this.pnlBotonera.SuspendLayout();
            this.SuspendLayout();

            // pnlCabecera
            this.pnlCabecera.Controls.Add(this.lblNumero);
            this.pnlCabecera.Controls.Add(this.lblFecha);
            this.pnlCabecera.Controls.Add(this.lblClienteComp);
            this.pnlCabecera.Controls.Add(this.lblAdmin);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Height = 96;
            this.pnlCabecera.BackColor = System.Drawing.Color.White;
            this.pnlCabecera.Padding = new System.Windows.Forms.Padding(8);
            this.pnlCabecera.Name = "pnlCabecera";

            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(8, 8);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Text = "N°: —";

            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(8, 28);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Text = "Fecha: —";

            this.lblClienteComp.AutoSize = true;
            this.lblClienteComp.Location = new System.Drawing.Point(8, 48);
            this.lblClienteComp.Name = "lblClienteComp";
            this.lblClienteComp.Text = "Cliente: —";

            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(8, 68);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Text = "Administrador: —";

            // dgvDetalle
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDetalle.Height = 220;
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.Name = "dgvDetalle";
            var colComp = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colComponente", HeaderText = "Componente", DataPropertyName = "Componente" };
            var colCant = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCantidad", HeaderText = "Cantidad", DataPropertyName = "Cantidad" };
            var colPrec = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colPrecio", HeaderText = "Precio", DataPropertyName = "Precio" };
            var colSub = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colSubtotal", HeaderText = "Subtotal", DataPropertyName = "Subtotal" };
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colComp, colCant, colPrec, colSub });

            // lblTotal
            this.lblTotal.Text = "Total: $ 0.00";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12f);
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.Location = new System.Drawing.Point(600, 320);
            this.lblTotal.AutoSize = true;
            this.lblTotal.Name = "lblTotal";

            // pnlVisor
            this.pnlVisor.Controls.Add(this.lblVisorTodo);
            this.pnlVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVisor.BackColor = System.Drawing.Color.White;
            this.pnlVisor.Name = "pnlVisor";

            this.lblVisorTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVisorTodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVisorTodo.Text = "Vista previa del PDF (iTextSharp) — // TODO";
            this.lblVisorTodo.Name = "lblVisorTodo";
            this.lblVisorTodo.ForeColor = System.Drawing.Color.Gray;

            // pnlBotonera
            this.pnlBotonera.Controls.Add(this.btnDescargarPdf);
            this.pnlBotonera.Controls.Add(this.btnImprimir);
            this.pnlBotonera.Controls.Add(this.btnCerrar);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Height = 44;
            this.pnlBotonera.Name = "pnlBotonera";

            this.btnDescargarPdf.Location = new System.Drawing.Point(484, 8);
            this.btnDescargarPdf.Size = new System.Drawing.Size(120, 28);
            this.btnDescargarPdf.Name = "btnDescargarPdf";
            this.btnDescargarPdf.Text = "Descargar PDF";
            this.btnDescargarPdf.BackColor = Estilos.Primario;
            this.btnDescargarPdf.ForeColor = System.Drawing.Color.White;
            this.btnDescargarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargarPdf.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnDescargarPdf.Click += new System.EventHandler(this.btnDescargarPdf_Click);

            this.btnImprimir.Location = new System.Drawing.Point(612, 8);
            this.btnImprimir.Size = new System.Drawing.Size(80, 28);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);

            this.btnCerrar.Location = new System.Drawing.Point(700, 8);
            this.btnCerrar.Size = new System.Drawing.Size(52, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // frmComprobante
            this.ClientSize = new System.Drawing.Size(760, 640);
            this.Controls.Add(this.pnlVisor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlBotonera);
            this.Name = "frmComprobante";
            this.Text = "Comprobante de Venta";

            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.pnlVisor.ResumeLayout(false);
            this.pnlBotonera.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
