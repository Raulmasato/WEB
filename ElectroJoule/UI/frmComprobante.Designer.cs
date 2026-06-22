namespace ElectroJoule.UI
{
    partial class frmComprobante
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlVisor;
        private System.Windows.Forms.Label lblVisorTodo;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Button btnDescargarPdf;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;

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
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colComponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlVisor = new System.Windows.Forms.Panel();
            this.lblVisorTodo = new System.Windows.Forms.Label();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.btnDescargarPdf = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.pnlVisor.SuspendLayout();
            this.pnlBotonera.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.pnlEncabezado.Controls.Add(this.lblTituloForm);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(744, 40);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(0, 0);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTituloForm.Size = new System.Drawing.Size(744, 40);
            this.lblTituloForm.Text = "Comprobante";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.lblNumero);
            this.pnlCabecera.Controls.Add(this.lblFecha);
            this.pnlCabecera.Controls.Add(this.lblCliente);
            this.pnlCabecera.Controls.Add(this.lblAdmin);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 40);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(744, 96);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblNumero.Location = new System.Drawing.Point(12, 12);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(110, 19);
            this.lblNumero.Text = "Comprobante Nº -";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 15);
            this.lblFecha.Text = "Fecha: -";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 58);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(53, 15);
            this.lblCliente.Text = "Cliente: -";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(12, 78);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(70, 15);
            this.lblAdmin.Text = "Atendido por: -";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colComponente,
                this.colCantidad,
                this.colPrecio,
                this.colSubtotal});
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDetalle.Location = new System.Drawing.Point(0, 136);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(744, 200);
            // 
            // colComponente
            // 
            this.colComponente.HeaderText = "Componente";
            this.colComponente.Name = "colComponente";
            this.colComponente.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.lblTotal.Location = new System.Drawing.Point(0, 336);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblTotal.Size = new System.Drawing.Size(744, 30);
            this.lblTotal.Text = "Total: $ 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlVisor
            // 
            this.pnlVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVisor.Controls.Add(this.lblVisorTodo);
            this.pnlVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVisor.Location = new System.Drawing.Point(0, 366);
            this.pnlVisor.Name = "pnlVisor";
            this.pnlVisor.Size = new System.Drawing.Size(744, 195);
            // 
            // lblVisorTodo
            // 
            this.lblVisorTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVisorTodo.ForeColor = System.Drawing.Color.Gray;
            this.lblVisorTodo.Location = new System.Drawing.Point(0, 0);
            this.lblVisorTodo.Name = "lblVisorTodo";
            this.lblVisorTodo.Size = new System.Drawing.Size(742, 193);
            this.lblVisorTodo.Text = "Vista previa del PDF (iTextSharp) - // TODO";
            this.lblVisorTodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.Controls.Add(this.btnDescargarPdf);
            this.pnlBotonera.Controls.Add(this.btnImprimir);
            this.pnlBotonera.Controls.Add(this.btnCerrar);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Location = new System.Drawing.Point(0, 521);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(744, 40);
            // 
            // btnDescargarPdf
            // 
            this.btnDescargarPdf.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDescargarPdf.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnDescargarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargarPdf.ForeColor = System.Drawing.Color.White;
            this.btnDescargarPdf.Location = new System.Drawing.Point(444, 7);
            this.btnDescargarPdf.Name = "btnDescargarPdf";
            this.btnDescargarPdf.Size = new System.Drawing.Size(110, 27);
            this.btnDescargarPdf.Text = "Descargar PDF";
            this.btnDescargarPdf.UseVisualStyleBackColor = false;
            this.btnDescargarPdf.Click += new System.EventHandler(this.btnDescargarPdf_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(562, 7);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 27);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(650, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 27);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(744, 561);
            this.Controls.Add(this.pnlVisor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmComprobante";
            this.Text = "Comprobante";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.pnlVisor.ResumeLayout(false);
            this.pnlBotonera.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
