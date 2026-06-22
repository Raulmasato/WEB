namespace ElectroJoule.UI
{
    partial class frmDevoluciones
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Panel pnlVentaOrigen;
        private System.Windows.Forms.TextBox txtBuscarVenta;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Label lblVentaSeleccionada;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDevolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantDevolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Panel pnlMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnProcesarDevolucion;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnlVentaOrigen = new System.Windows.Forms.Panel();
            this.txtBuscarVenta = new System.Windows.Forms.TextBox();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.lblVentaSeleccionada = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colDevolver = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colComponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantDevolver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMotivo = new System.Windows.Forms.Panel();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnProcesarDevolucion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.pnlVentaOrigen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnlMotivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.pnlEncabezado.Controls.Add(this.lblTituloForm);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(864, 40);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(0, 0);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTituloForm.Size = new System.Drawing.Size(864, 40);
            this.lblTituloForm.Text = "Devoluciones";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlVentaOrigen
            // 
            this.pnlVentaOrigen.Controls.Add(this.txtBuscarVenta);
            this.pnlVentaOrigen.Controls.Add(this.btnBuscarVenta);
            this.pnlVentaOrigen.Controls.Add(this.lblVentaSeleccionada);
            this.pnlVentaOrigen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVentaOrigen.Location = new System.Drawing.Point(0, 40);
            this.pnlVentaOrigen.Name = "pnlVentaOrigen";
            this.pnlVentaOrigen.Size = new System.Drawing.Size(864, 56);
            // 
            // txtBuscarVenta
            // 
            this.txtBuscarVenta.Location = new System.Drawing.Point(12, 16);
            this.txtBuscarVenta.Name = "txtBuscarVenta";
            this.txtBuscarVenta.Size = new System.Drawing.Size(200, 23);
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVenta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVenta.Location = new System.Drawing.Point(220, 14);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(120, 27);
            this.btnBuscarVenta.Text = "Buscar venta";
            this.btnBuscarVenta.UseVisualStyleBackColor = false;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // lblVentaSeleccionada
            // 
            this.lblVentaSeleccionada.AutoSize = true;
            this.lblVentaSeleccionada.Location = new System.Drawing.Point(356, 20);
            this.lblVentaSeleccionada.Name = "lblVentaSeleccionada";
            this.lblVentaSeleccionada.Size = new System.Drawing.Size(120, 15);
            this.lblVentaSeleccionada.Text = "Ninguna venta seleccionada";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDevolver,
                this.colComponente,
                this.colCantVendida,
                this.colCantDevolver,
                this.colSubtotal});
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(0, 96);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(864, 355);
            // 
            // colDevolver
            // 
            this.colDevolver.HeaderText = "Devolver";
            this.colDevolver.Name = "colDevolver";
            // 
            // colComponente
            // 
            this.colComponente.HeaderText = "Componente";
            this.colComponente.Name = "colComponente";
            this.colComponente.ReadOnly = true;
            // 
            // colCantVendida
            // 
            this.colCantVendida.HeaderText = "Cant. vendida";
            this.colCantVendida.Name = "colCantVendida";
            this.colCantVendida.ReadOnly = true;
            // 
            // colCantDevolver
            // 
            this.colCantDevolver.HeaderText = "Cant. a devolver";
            this.colCantDevolver.Name = "colCantDevolver";
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // pnlMotivo
            // 
            this.pnlMotivo.Controls.Add(this.lblMotivo);
            this.pnlMotivo.Controls.Add(this.txtMotivo);
            this.pnlMotivo.Controls.Add(this.btnProcesarDevolucion);
            this.pnlMotivo.Controls.Add(this.btnCancelar);
            this.pnlMotivo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMotivo.Location = new System.Drawing.Point(0, 451);
            this.pnlMotivo.Name = "pnlMotivo";
            this.pnlMotivo.Size = new System.Drawing.Size(864, 110);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(12, 12);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(50, 15);
            this.lblMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(12, 30);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(500, 68);
            // 
            // btnProcesarDevolucion
            // 
            this.btnProcesarDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcesarDevolucion.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnProcesarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesarDevolucion.ForeColor = System.Drawing.Color.White;
            this.btnProcesarDevolucion.Location = new System.Drawing.Point(620, 60);
            this.btnProcesarDevolucion.Name = "btnProcesarDevolucion";
            this.btnProcesarDevolucion.Size = new System.Drawing.Size(150, 30);
            this.btnProcesarDevolucion.Text = "Procesar devolución";
            this.btnProcesarDevolucion.UseVisualStyleBackColor = false;
            this.btnProcesarDevolucion.Click += new System.EventHandler(this.btnProcesarDevolucion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(778, 60);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.pnlMotivo);
            this.Controls.Add(this.pnlVentaOrigen);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmDevoluciones";
            this.Text = "Devoluciones";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlVentaOrigen.ResumeLayout(false);
            this.pnlVentaOrigen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnlMotivo.ResumeLayout(false);
            this.pnlMotivo.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
