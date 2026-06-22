namespace ElectroJoule.UI
{
    partial class frmPago
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMontoTitulo;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMetodoLabel;
        private System.Windows.Forms.ComboBox cboMetodo;
        private System.Windows.Forms.GroupBox grpDatosMetodo;
        // Efectivo sub-panel
        private System.Windows.Forms.Panel pnlEfectivo;
        private System.Windows.Forms.Label lblRecibido;
        private System.Windows.Forms.NumericUpDown numRecibido;
        private System.Windows.Forms.Label lblVuelto;
        // Transferencia sub-panel
        private System.Windows.Forms.Panel pnlTransferencia;
        private System.Windows.Forms.Label lblCbu;
        private System.Windows.Forms.TextBox txtCbu;
        private System.Windows.Forms.Label lblComprobante;
        private System.Windows.Forms.TextBox txtComprobante;
        // Tarjeta sub-panel
        private System.Windows.Forms.Panel pnlTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.ComboBox cboCuotas;
        // Fecha
        private System.Windows.Forms.Label lblFechaLabel;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        // Botones
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarPago;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMontoTitulo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblMetodoLabel = new System.Windows.Forms.Label();
            this.cboMetodo = new System.Windows.Forms.ComboBox();
            this.grpDatosMetodo = new System.Windows.Forms.GroupBox();
            this.pnlEfectivo = new System.Windows.Forms.Panel();
            this.lblRecibido = new System.Windows.Forms.Label();
            this.numRecibido = new System.Windows.Forms.NumericUpDown();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.pnlTransferencia = new System.Windows.Forms.Panel();
            this.lblCbu = new System.Windows.Forms.Label();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.lblComprobante = new System.Windows.Forms.Label();
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.pnlTarjeta = new System.Windows.Forms.Panel();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.lblFechaLabel = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarPago = new System.Windows.Forms.Button();
            this.grpDatosMetodo.SuspendLayout();
            this.pnlEfectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecibido)).BeginInit();
            this.pnlTransferencia.SuspendLayout();
            this.pnlTarjeta.SuspendLayout();
            this.SuspendLayout();

            // lblMontoTitulo
            this.lblMontoTitulo.AutoSize = true;
            this.lblMontoTitulo.Location = new System.Drawing.Point(16, 16);
            this.lblMontoTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11f);
            this.lblMontoTitulo.Name = "lblMontoTitulo";
            this.lblMontoTitulo.Text = "Monto a pagar";

            // lblMonto
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(16, 40);
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 16f);
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Text = "$ 0.00";

            // lblMetodoLabel
            this.lblMetodoLabel.AutoSize = true;
            this.lblMetodoLabel.Location = new System.Drawing.Point(16, 80);
            this.lblMetodoLabel.Name = "lblMetodoLabel";
            this.lblMetodoLabel.Text = "Método de pago:";

            // cboMetodo
            this.cboMetodo.Location = new System.Drawing.Point(16, 98);
            this.cboMetodo.Size = new System.Drawing.Size(200, 23);
            this.cboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodo.Items.AddRange(new object[] { "efectivo", "transferencia", "tarjeta" });
            this.cboMetodo.SelectedIndex = 0;
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.SelectedIndexChanged += new System.EventHandler(this.cboMetodo_SelectedIndexChanged);

            // grpDatosMetodo
            this.grpDatosMetodo.Location = new System.Drawing.Point(16, 130);
            this.grpDatosMetodo.Size = new System.Drawing.Size(420, 160);
            this.grpDatosMetodo.Text = "Datos del método";
            this.grpDatosMetodo.Name = "grpDatosMetodo";
            this.grpDatosMetodo.Controls.Add(this.pnlEfectivo);
            this.grpDatosMetodo.Controls.Add(this.pnlTransferencia);
            this.grpDatosMetodo.Controls.Add(this.pnlTarjeta);

            // pnlEfectivo
            this.pnlEfectivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEfectivo.Name = "pnlEfectivo";
            this.pnlEfectivo.Visible = true;
            this.pnlEfectivo.Controls.Add(this.lblRecibido);
            this.pnlEfectivo.Controls.Add(this.numRecibido);
            this.pnlEfectivo.Controls.Add(this.lblVuelto);

            this.lblRecibido.AutoSize = true;
            this.lblRecibido.Location = new System.Drawing.Point(8, 16);
            this.lblRecibido.Name = "lblRecibido";
            this.lblRecibido.Text = "Monto recibido:";

            this.numRecibido.Location = new System.Drawing.Point(8, 34);
            this.numRecibido.Size = new System.Drawing.Size(200, 23);
            this.numRecibido.DecimalPlaces = 2;
            this.numRecibido.Maximum = 9999999;
            this.numRecibido.Name = "numRecibido";

            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Location = new System.Drawing.Point(8, 64);
            this.lblVuelto.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Text = "Vuelto: $ 0.00";

            // pnlTransferencia
            this.pnlTransferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransferencia.Name = "pnlTransferencia";
            this.pnlTransferencia.Visible = false;
            this.pnlTransferencia.Controls.Add(this.lblCbu);
            this.pnlTransferencia.Controls.Add(this.txtCbu);
            this.pnlTransferencia.Controls.Add(this.lblComprobante);
            this.pnlTransferencia.Controls.Add(this.txtComprobante);

            this.lblCbu.AutoSize = true;
            this.lblCbu.Location = new System.Drawing.Point(8, 16);
            this.lblCbu.Name = "lblCbu";
            this.lblCbu.Text = "CBU / CVU:";

            this.txtCbu.Location = new System.Drawing.Point(8, 34);
            this.txtCbu.Size = new System.Drawing.Size(390, 23);
            this.txtCbu.Name = "txtCbu";

            this.lblComprobante.AutoSize = true;
            this.lblComprobante.Location = new System.Drawing.Point(8, 64);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Text = "N° comprobante:";

            this.txtComprobante.Location = new System.Drawing.Point(8, 82);
            this.txtComprobante.Size = new System.Drawing.Size(390, 23);
            this.txtComprobante.Name = "txtComprobante";

            // pnlTarjeta
            this.pnlTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTarjeta.Name = "pnlTarjeta";
            this.pnlTarjeta.Visible = false;
            this.pnlTarjeta.Controls.Add(this.lblTarjeta);
            this.pnlTarjeta.Controls.Add(this.txtTarjeta);
            this.pnlTarjeta.Controls.Add(this.lblCuotas);
            this.pnlTarjeta.Controls.Add(this.cboCuotas);

            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(8, 16);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Text = "Nº de tarjeta (últimos 4 dígitos):";

            this.txtTarjeta.Location = new System.Drawing.Point(8, 34);
            this.txtTarjeta.Size = new System.Drawing.Size(200, 23);
            this.txtTarjeta.Name = "txtTarjeta";

            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(8, 64);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Text = "Cuotas:";

            this.cboCuotas.Location = new System.Drawing.Point(8, 82);
            this.cboCuotas.Size = new System.Drawing.Size(120, 23);
            this.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuotas.Items.AddRange(new object[] { "1", "3", "6", "12" });
            this.cboCuotas.SelectedIndex = 0;
            this.cboCuotas.Name = "cboCuotas";

            // lblFechaLabel
            this.lblFechaLabel.AutoSize = true;
            this.lblFechaLabel.Location = new System.Drawing.Point(16, 300);
            this.lblFechaLabel.Name = "lblFechaLabel";
            this.lblFechaLabel.Text = "Fecha:";

            // dtpFecha
            this.dtpFecha.Location = new System.Drawing.Point(16, 318);
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Name = "dtpFecha";

            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(262, 362);
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // btnConfirmarPago
            this.btnConfirmarPago.Location = new System.Drawing.Point(350, 362);
            this.btnConfirmarPago.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmarPago.Name = "btnConfirmarPago";
            this.btnConfirmarPago.Text = "Confirmar pago";
            this.btnConfirmarPago.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnConfirmarPago.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarPago.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnConfirmarPago.Click += new System.EventHandler(this.btnConfirmarPago_Click);

            // frmPago
            this.AcceptButton = this.btnConfirmarPago;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(460, 420);
            this.Controls.Add(this.lblMontoTitulo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblMetodoLabel);
            this.Controls.Add(this.cboMetodo);
            this.Controls.Add(this.grpDatosMetodo);
            this.Controls.Add(this.lblFechaLabel);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarPago);
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Pago";

            this.grpDatosMetodo.ResumeLayout(false);
            this.pnlEfectivo.ResumeLayout(false);
            this.pnlEfectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecibido)).EndInit();
            this.pnlTransferencia.ResumeLayout(false);
            this.pnlTransferencia.PerformLayout();
            this.pnlTarjeta.ResumeLayout(false);
            this.pnlTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
