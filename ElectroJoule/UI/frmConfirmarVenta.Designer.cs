namespace ElectroJoule.UI
{
    partial class frmConfirmarVenta
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConfirmar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.pnlPie.SuspendLayout();
            this.SuspendLayout();

            // pnlCliente
            this.pnlCliente.Controls.Add(this.lblCliente);
            this.pnlCliente.Controls.Add(this.lblFecha);
            this.pnlCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCliente.Height = 64;
            this.pnlCliente.BackColor = Estilos.FondoForm;
            this.pnlCliente.Padding = new System.Windows.Forms.Padding(8);
            this.pnlCliente.Name = "pnlCliente";

            // lblCliente
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(8, 8);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Text = "Cliente: —";

            // lblFecha
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(8, 30);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Text = "Fecha: " + System.DateTime.Now.ToShortDateString();

            // dgvDetalle
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.Name = "dgvDetalle";
            var colComp = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colComponente", HeaderText = "Componente", DataPropertyName = "Componente" };
            var colCant = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCantidad", HeaderText = "Cantidad", DataPropertyName = "Cantidad" };
            var colPrecUnit = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colPrecioUnit", HeaderText = "Precio unit.", DataPropertyName = "PrecioUnitario" };
            var colSub = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colSubtotal", HeaderText = "Subtotal", DataPropertyName = "Subtotal" };
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colComp, colCant, colPrecUnit, colSub });

            // pnlPie
            this.pnlPie.Controls.Add(this.lblTotal);
            this.pnlPie.Controls.Add(this.btnVolver);
            this.pnlPie.Controls.Add(this.btnConfirmar);
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Height = 80;
            this.pnlPie.BackColor = System.Drawing.Color.White;
            this.pnlPie.Name = "pnlPie";

            // lblTotal
            this.lblTotal.Text = "Total: $ 0.00";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(8, 20);
            this.lblTotal.AutoSize = true;
            this.lblTotal.Name = "lblTotal";

            // btnVolver
            this.btnVolver.Location = new System.Drawing.Point(448, 24);
            this.btnVolver.Size = new System.Drawing.Size(90, 30);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Text = "Volver";
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            // btnConfirmar
            this.btnConfirmar.Location = new System.Drawing.Point(546, 24);
            this.btnConfirmar.Size = new System.Drawing.Size(90, 30);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.BackColor = Estilos.Primario;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);

            // frmConfirmarVenta
            this.AcceptButton = this.btnConfirmar;
            this.BackColor = Estilos.FondoForm;
            this.ClientSize = new System.Drawing.Size(640, 520);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.pnlCliente);
            this.Font = Estilos.FuenteGeneral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmConfirmarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmar Venta";

            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.pnlPie.ResumeLayout(false);
            this.pnlPie.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
