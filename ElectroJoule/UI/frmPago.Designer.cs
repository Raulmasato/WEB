namespace ElectroJoule.UI
{
    partial class frmPago
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMontoTitulo;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.ComboBox cboMetodo;
        private System.Windows.Forms.GroupBox grpDatosMetodo;
        private System.Windows.Forms.Label lblRecibido;
        private System.Windows.Forms.NumericUpDown numRecibido;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Label lblCbu;
        private System.Windows.Forms.TextBox txtCbu;
        private System.Windows.Forms.Label lblComprobante;
        private System.Windows.Forms.TextBox txtComprobante;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarPago;

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
            this.lblMontoTitulo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cboMetodo = new System.Windows.Forms.ComboBox();
            this.grpDatosMetodo = new System.Windows.Forms.GroupBox();
            this.lblRecibido = new System.Windows.Forms.Label();
            this.numRecibido = new System.Windows.Forms.NumericUpDown();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.lblCbu = new System.Windows.Forms.Label();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.lblComprobante = new System.Windows.Forms.Label();
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarPago = new System.Windows.Forms.Button();
            this.grpDatosMetodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecibido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMontoTitulo
            // 
            this.lblMontoTitulo.AutoSize = true;
            this.lblMontoTitulo.Location = new System.Drawing.Point(12, 16);
            this.lblMontoTitulo.Name = "lblMontoTitulo";
            this.lblMontoTitulo.Size = new System.Drawing.Size(89, 15);
            this.lblMontoTitulo.Text = "Monto a pagar";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.lblMonto.Location = new System.Drawing.Point(12, 34);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(95, 32);
            this.lblMonto.Text = "$ 0.00";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(12, 80);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(89, 15);
            this.lblMetodo.Text = "Método de pago:";
            // 
            // cboMetodo
            // 
            this.cboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodo.Items.AddRange(new object[] { "efectivo", "transferencia", "tarjeta"});
            this.cboMetodo.Location = new System.Drawing.Point(12, 98);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(200, 23);
            this.cboMetodo.SelectedIndexChanged += new System.EventHandler(this.cboMetodo_SelectedIndexChanged);
            // 
            // grpDatosMetodo
            // 
            this.grpDatosMetodo.Controls.Add(this.lblRecibido);
            this.grpDatosMetodo.Controls.Add(this.numRecibido);
            this.grpDatosMetodo.Controls.Add(this.lblVuelto);
            this.grpDatosMetodo.Controls.Add(this.lblCbu);
            this.grpDatosMetodo.Controls.Add(this.txtCbu);
            this.grpDatosMetodo.Controls.Add(this.lblComprobante);
            this.grpDatosMetodo.Controls.Add(this.txtComprobante);
            this.grpDatosMetodo.Controls.Add(this.lblTarjeta);
            this.grpDatosMetodo.Controls.Add(this.txtTarjeta);
            this.grpDatosMetodo.Controls.Add(this.lblCuotas);
            this.grpDatosMetodo.Controls.Add(this.cboCuotas);
            this.grpDatosMetodo.Location = new System.Drawing.Point(12, 132);
            this.grpDatosMetodo.Name = "grpDatosMetodo";
            this.grpDatosMetodo.Size = new System.Drawing.Size(420, 160);
            this.grpDatosMetodo.TabStop = false;
            this.grpDatosMetodo.Text = "Datos del método";
            // 
            // lblRecibido
            // 
            this.lblRecibido.AutoSize = true;
            this.lblRecibido.Location = new System.Drawing.Point(12, 28);
            this.lblRecibido.Name = "lblRecibido";
            this.lblRecibido.Size = new System.Drawing.Size(58, 15);
            this.lblRecibido.Text = "Recibido:";
            // 
            // numRecibido
            // 
            this.numRecibido.DecimalPlaces = 2;
            this.numRecibido.Location = new System.Drawing.Point(120, 26);
            this.numRecibido.Maximum = new decimal(new int[] { 9999999, 0, 0, 0});
            this.numRecibido.Name = "numRecibido";
            this.numRecibido.Size = new System.Drawing.Size(120, 23);
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Location = new System.Drawing.Point(12, 58);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(70, 15);
            this.lblVuelto.Text = "Vuelto: $ 0.00";
            // 
            // lblCbu
            // 
            this.lblCbu.AutoSize = true;
            this.lblCbu.Location = new System.Drawing.Point(12, 28);
            this.lblCbu.Name = "lblCbu";
            this.lblCbu.Size = new System.Drawing.Size(35, 15);
            this.lblCbu.Text = "CBU:";
            this.lblCbu.Visible = false;
            // 
            // txtCbu
            // 
            this.txtCbu.Location = new System.Drawing.Point(120, 25);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(200, 23);
            this.txtCbu.Visible = false;
            // 
            // lblComprobante
            // 
            this.lblComprobante.AutoSize = true;
            this.lblComprobante.Location = new System.Drawing.Point(12, 60);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(85, 15);
            this.lblComprobante.Text = "Comprobante:";
            this.lblComprobante.Visible = false;
            // 
            // txtComprobante
            // 
            this.txtComprobante.Location = new System.Drawing.Point(120, 57);
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.Size = new System.Drawing.Size(200, 23);
            this.txtComprobante.Visible = false;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(12, 28);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(50, 15);
            this.lblTarjeta.Text = "Tarjeta:";
            this.lblTarjeta.Visible = false;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(120, 25);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(200, 23);
            this.txtTarjeta.Visible = false;
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(12, 60);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(48, 15);
            this.lblCuotas.Text = "Cuotas:";
            this.lblCuotas.Visible = false;
            // 
            // cboCuotas
            // 
            this.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuotas.Items.AddRange(new object[] { "1", "3", "6", "12"});
            this.cboCuotas.Location = new System.Drawing.Point(120, 57);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(100, 23);
            this.cboCuotas.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 304);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 15);
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(120, 301);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(120, 23);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(228, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmarPago
            // 
            this.btnConfirmarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarPago.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnConfirmarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarPago.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarPago.Location = new System.Drawing.Point(324, 340);
            this.btnConfirmarPago.Name = "btnConfirmarPago";
            this.btnConfirmarPago.Size = new System.Drawing.Size(108, 30);
            this.btnConfirmarPago.Text = "Confirmar";
            this.btnConfirmarPago.UseVisualStyleBackColor = false;
            this.btnConfirmarPago.Click += new System.EventHandler(this.btnConfirmarPago_Click);
            // 
            // frmPago
            // 
            this.AcceptButton = this.btnConfirmarPago;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(444, 382);
            this.Controls.Add(this.lblMontoTitulo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.cboMetodo);
            this.Controls.Add(this.grpDatosMetodo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarPago);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar pago";
            this.grpDatosMetodo.ResumeLayout(false);
            this.grpDatosMetodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecibido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
