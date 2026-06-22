namespace ElectroJoule.UI
{
    partial class frmClientes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.ComboBox cboCondicionImpositiva;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBajaLogica;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.cboCondicionImpositiva = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBajaLogica = new System.Windows.Forms.Button();

            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvClientes).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();

            // pnlFiltros
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Height = 48;
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBuscar.Location = new System.Drawing.Point(6, 12); this.txtBuscar.Size = new System.Drawing.Size(240, 23); this.txtBuscar.PlaceholderText = "Nombre o CUIT";
            this.btnBuscar.Location = new System.Drawing.Point(254, 10); this.btnBuscar.Size = new System.Drawing.Size(80, 27); this.btnBuscar.Text = "Buscar";
            this.btnBuscar.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E75B6"); this.btnBuscar.ForeColor = System.Drawing.Color.White; this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnLimpiar.Location = new System.Drawing.Point(342, 10); this.btnLimpiar.Size = new System.Drawing.Size(80, 27); this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.pnlFiltros.Controls.AddRange(new System.Windows.Forms.Control[] { this.txtBuscar, this.btnBuscar, this.btnLimpiar });

            // dgvClientes
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.ReadOnly = true; this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.AllowUserToAddRows = false; this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.MultiSelect = false; this.dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#EAF1FA");
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colId", HeaderText = "Id" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colNombre", HeaderText = "Nombre" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCuit", HeaderText = "CUIT" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colContacto", HeaderText = "Contacto" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCondicion", HeaderText = "Condición" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colEstado", HeaderText = "Estado" },
            });
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);

            // grpDatos
            this.grpDatos.Text = "Datos del cliente"; this.grpDatos.Dock = System.Windows.Forms.DockStyle.Right; this.grpDatos.Width = 300;
            this.grpDatos.Padding = new System.Windows.Forms.Padding(10);
            this.lblNombre.Text = "Nombre:"; this.lblNombre.Location = new System.Drawing.Point(10, 25); this.lblNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(10, 42); this.txtNombre.Size = new System.Drawing.Size(270, 23);
            this.lblCuit.Text = "CUIT:"; this.lblCuit.Location = new System.Drawing.Point(10, 72); this.lblCuit.AutoSize = true;
            this.txtCuit.Location = new System.Drawing.Point(10, 89); this.txtCuit.Size = new System.Drawing.Size(270, 23);
            this.lblContacto.Text = "Contacto:"; this.lblContacto.Location = new System.Drawing.Point(10, 119); this.lblContacto.AutoSize = true;
            this.txtContacto.Location = new System.Drawing.Point(10, 136); this.txtContacto.Size = new System.Drawing.Size(270, 23);
            this.lblCondicion.Text = "Condición impositiva:"; this.lblCondicion.Location = new System.Drawing.Point(10, 166); this.lblCondicion.AutoSize = true;
            this.cboCondicionImpositiva.Location = new System.Drawing.Point(10, 183); this.cboCondicionImpositiva.Size = new System.Drawing.Size(270, 23);
            this.cboCondicionImpositiva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondicionImpositiva.Items.AddRange(new object[] { "Responsable Inscripto", "Monotributo", "Exento", "Consumidor Final" });
            this.grpDatos.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblNombre, this.txtNombre, this.lblCuit, this.txtCuit,
                this.lblContacto, this.txtContacto, this.lblCondicion, this.cboCondicionImpositiva });

            // Botonera
            this.btnNuevo.Text = "Nuevo"; this.btnNuevo.Size = new System.Drawing.Size(90, 27);
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnNuevo.Location = new System.Drawing.Point(490, 505); this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);

            this.btnGuardar.Text = "Guardar"; this.btnGuardar.Size = new System.Drawing.Size(90, 27);
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.Location = new System.Drawing.Point(588, 505);
            this.btnGuardar.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E75B6"); this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.btnBajaLogica.Text = "Baja lógica"; this.btnBajaLogica.Size = new System.Drawing.Size(90, 27);
            this.btnBajaLogica.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnBajaLogica.Location = new System.Drawing.Point(686, 505); this.btnBajaLogica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaLogica.Click += new System.EventHandler(this.btnBajaLogica_Click);

            // frmClientes
            this.Text = "Clientes"; this.ClientSize = new System.Drawing.Size(880, 560);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBajaLogica);

            this.pnlFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dgvClientes).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
