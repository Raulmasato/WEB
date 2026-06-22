namespace ElectroJoule.UI
{
    partial class frmDevoluciones
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlVentaOrigen;
        private System.Windows.Forms.TextBox txtBuscarVenta;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Label lblVentaSeleccionada;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Panel pnlMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnProcesarDevolucion;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlVentaOrigen = new System.Windows.Forms.Panel();
            this.txtBuscarVenta = new System.Windows.Forms.TextBox();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.lblVentaSeleccionada = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.pnlMotivo = new System.Windows.Forms.Panel();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnProcesarDevolucion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlVentaOrigen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnlMotivo.SuspendLayout();
            this.SuspendLayout();

            // pnlVentaOrigen
            this.pnlVentaOrigen.Controls.Add(this.txtBuscarVenta);
            this.pnlVentaOrigen.Controls.Add(this.btnBuscarVenta);
            this.pnlVentaOrigen.Controls.Add(this.lblVentaSeleccionada);
            this.pnlVentaOrigen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVentaOrigen.Height = 56;
            this.pnlVentaOrigen.Padding = new System.Windows.Forms.Padding(8);
            this.pnlVentaOrigen.Name = "pnlVentaOrigen";

            this.txtBuscarVenta.Location = new System.Drawing.Point(8, 16);
            this.txtBuscarVenta.Size = new System.Drawing.Size(200, 24);
            this.txtBuscarVenta.Name = "txtBuscarVenta";

            this.btnBuscarVenta.Location = new System.Drawing.Point(216, 14);
            this.btnBuscarVenta.Size = new System.Drawing.Size(100, 26);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Text = "Buscar venta";
            this.btnBuscarVenta.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E75B6");
            this.btnBuscarVenta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);

            this.lblVentaSeleccionada.AutoSize = true;
            this.lblVentaSeleccionada.Location = new System.Drawing.Point(326, 18);
            this.lblVentaSeleccionada.Name = "lblVentaSeleccionada";
            this.lblVentaSeleccionada.Text = "Venta seleccionada: —";
            this.lblVentaSeleccionada.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1F4E79");

            // dgvItems
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.Name = "dgvItems";
            var colDevolver = new System.Windows.Forms.DataGridViewCheckBoxColumn { Name = "colDevolver", HeaderText = "Devolver", DataPropertyName = "Devolver" };
            var colComp = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colComponente", HeaderText = "Componente", DataPropertyName = "Componente", ReadOnly = true };
            var colCantVend = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCantVendida", HeaderText = "Cant. vendida", DataPropertyName = "CantidadVendida", ReadOnly = true };
            var colCantDev = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCantDevolver", HeaderText = "Cant. a devolver", DataPropertyName = "CantidadDevolver", ReadOnly = false };
            var colSub = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colSubtotal", HeaderText = "Subtotal", DataPropertyName = "Subtotal", ReadOnly = true };
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colDevolver, colComp, colCantVend, colCantDev, colSub });

            // pnlMotivo
            this.pnlMotivo.Controls.Add(this.lblMotivo);
            this.pnlMotivo.Controls.Add(this.txtMotivo);
            this.pnlMotivo.Controls.Add(this.btnProcesarDevolucion);
            this.pnlMotivo.Controls.Add(this.btnCancelar);
            this.pnlMotivo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMotivo.Height = 110;
            this.pnlMotivo.Padding = new System.Windows.Forms.Padding(8);
            this.pnlMotivo.Name = "pnlMotivo";

            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(8, 8);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Text = "Motivo de devolución:";

            this.txtMotivo.Location = new System.Drawing.Point(8, 26);
            this.txtMotivo.Size = new System.Drawing.Size(600, 60);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtMotivo.Name = "txtMotivo";

            this.btnProcesarDevolucion.Location = new System.Drawing.Point(636, 60);
            this.btnProcesarDevolucion.Size = new System.Drawing.Size(130, 30);
            this.btnProcesarDevolucion.Name = "btnProcesarDevolucion";
            this.btnProcesarDevolucion.Text = "Procesar devolución";
            this.btnProcesarDevolucion.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E75B6");
            this.btnProcesarDevolucion.ForeColor = System.Drawing.Color.White;
            this.btnProcesarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesarDevolucion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnProcesarDevolucion.Click += new System.EventHandler(this.btnProcesarDevolucion_Click);

            this.btnCancelar.Location = new System.Drawing.Point(774, 60);
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // frmDevoluciones
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.pnlMotivo);
            this.Controls.Add(this.pnlVentaOrigen);
            this.Name = "frmDevoluciones";
            this.Text = "Devoluciones";

            this.pnlVentaOrigen.ResumeLayout(false);
            this.pnlVentaOrigen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnlMotivo.ResumeLayout(false);
            this.pnlMotivo.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
