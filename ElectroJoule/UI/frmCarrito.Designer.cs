namespace ElectroJoule.UI
{
    partial class frmCarrito
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Panel pnlTotales;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSeguirComprando;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnConfirmarCompra;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.pnlTotales = new System.Windows.Forms.Panel();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSeguirComprando = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.pnlTotales.SuspendLayout();
            this.SuspendLayout();

            // dgvCarrito
            this.dgvCarrito.Location = new System.Drawing.Point(0, 40);
            this.dgvCarrito.Size = new System.Drawing.Size(820, 360);
            this.dgvCarrito.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrito_CellClick);
            var colComponente = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colComponente", HeaderText = "Componente", DataPropertyName = "Componente", ReadOnly = true };
            var colPrecioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colPrecioUnit", HeaderText = "Precio unit.", DataPropertyName = "PrecioUnitario", ReadOnly = true };
            var colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCantidad", HeaderText = "Cantidad", DataPropertyName = "Cantidad", ReadOnly = false };
            var colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colSubtotal", HeaderText = "Subtotal", DataPropertyName = "Subtotal", ReadOnly = true };
            var colQuitar = new System.Windows.Forms.DataGridViewButtonColumn { Name = "colQuitar", HeaderText = "Quitar", Text = "X", UseColumnTextForButtonValue = true };
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colComponente, colPrecioUnit, colCantidad, colSubtotal, colQuitar });

            // pnlTotales
            this.pnlTotales.Controls.Add(this.lblTotalLabel);
            this.pnlTotales.Controls.Add(this.lblTotal);
            this.pnlTotales.Controls.Add(this.btnSeguirComprando);
            this.pnlTotales.Controls.Add(this.btnVaciar);
            this.pnlTotales.Controls.Add(this.btnConfirmarCompra);
            this.pnlTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotales.Height = 90;
            this.pnlTotales.BackColor = System.Drawing.Color.White;
            this.pnlTotales.Name = "pnlTotales";

            // lblTotalLabel
            this.lblTotalLabel.Text = "Total:";
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14f);
            this.lblTotalLabel.Location = new System.Drawing.Point(8, 20);
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Name = "lblTotalLabel";

            // lblTotal
            this.lblTotal.Text = "$ 0.00";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = Estilos.Primario;
            this.lblTotal.Location = new System.Drawing.Point(80, 16);
            this.lblTotal.AutoSize = true;
            this.lblTotal.Name = "lblTotal";

            // Buttons (Anchor Bottom,Right)
            this.btnSeguirComprando.Location = new System.Drawing.Point(420, 30);
            this.btnSeguirComprando.Size = new System.Drawing.Size(120, 30);
            this.btnSeguirComprando.Name = "btnSeguirComprando";
            this.btnSeguirComprando.Text = "Seguir comprando";
            this.btnSeguirComprando.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnSeguirComprando.Click += new System.EventHandler(this.btnSeguirComprando_Click);

            this.btnVaciar.Location = new System.Drawing.Point(548, 30);
            this.btnVaciar.Size = new System.Drawing.Size(100, 30);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Text = "Vaciar carrito";
            this.btnVaciar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);

            this.btnConfirmarCompra.Location = new System.Drawing.Point(656, 30);
            this.btnConfirmarCompra.Size = new System.Drawing.Size(140, 30);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Text = "Confirmar compra";
            this.btnConfirmarCompra.BackColor = Estilos.Primario;
            this.btnConfirmarCompra.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarCompra.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);

            // frmCarrito
            this.ClientSize = new System.Drawing.Size(820, 560);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.pnlTotales);
            this.Name = "frmCarrito";
            this.Text = "Carrito de Compras";

            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.pnlTotales.ResumeLayout(false);
            this.pnlTotales.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
