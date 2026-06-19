namespace ElectroJoule.UI
{
    partial class frmProveedores
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox txtContacto;
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
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBajaLogica = new System.Windows.Forms.Button();

            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvProveedores).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();

            // pnlFiltros
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top; this.pnlFiltros.Height = 48;
            this.txtBuscar.Location = new System.Drawing.Point(6, 12); this.txtBuscar.Size = new System.Drawing.Size(240, 23); this.txtBuscar.PlaceholderText = "Nombre o CUIT";
            this.btnBuscar.Location = new System.Drawing.Point(254, 10); this.btnBuscar.Size = new System.Drawing.Size(80, 27); this.btnBuscar.Text = "Buscar";
            this.btnBuscar.BackColor = Estilos.Primario; this.btnBuscar.ForeColor = System.Drawing.Color.White; this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.pnlFiltros.Controls.AddRange(new System.Windows.Forms.Control[] { this.txtBuscar, this.btnBuscar });

            // dgvProveedores
            this.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedores.ReadOnly = true; this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.AllowUserToAddRows = false; this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.MultiSelect = false; this.dgvProveedores.AlternatingRowsDefaultCellStyle.BackColor = Estilos.FilaAlterna;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colId", HeaderText = "Id" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colNombre", HeaderText = "Nombre" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCuit", HeaderText = "CUIT" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colContacto", HeaderText = "Contacto" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colEstado", HeaderText = "Estado" },
            });
            this.dgvProveedores.SelectionChanged += new System.EventHandler(this.dgvProveedores_SelectionChanged);

            // grpDatos
            this.grpDatos.Text = "Datos del proveedor"; this.grpDatos.Dock = System.Windows.Forms.DockStyle.Right; this.grpDatos.Width = 280;
            this.lblNombre.Text = "Nombre:"; this.lblNombre.Location = new System.Drawing.Point(10, 25); this.lblNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(10, 42); this.txtNombre.Size = new System.Drawing.Size(250, 23);
            this.lblCuit.Text = "CUIT:"; this.lblCuit.Location = new System.Drawing.Point(10, 72); this.lblCuit.AutoSize = true;
            this.txtCuit.Location = new System.Drawing.Point(10, 89); this.txtCuit.Size = new System.Drawing.Size(250, 23);
            this.lblContacto.Text = "Contacto:"; this.lblContacto.Location = new System.Drawing.Point(10, 119); this.lblContacto.AutoSize = true;
            this.txtContacto.Location = new System.Drawing.Point(10, 136); this.txtContacto.Size = new System.Drawing.Size(250, 23);
            this.grpDatos.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblNombre, this.txtNombre, this.lblCuit, this.txtCuit, this.lblContacto, this.txtContacto });

            // Botonera
            this.btnNuevo.Text = "Nuevo"; this.btnNuevo.Size = new System.Drawing.Size(90, 27);
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnNuevo.Location = new System.Drawing.Point(480, 488); this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);

            this.btnGuardar.Text = "Guardar"; this.btnGuardar.Size = new System.Drawing.Size(90, 27);
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.Location = new System.Drawing.Point(578, 488);
            this.btnGuardar.BackColor = Estilos.Primario; this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.btnBajaLogica.Text = "Baja lógica"; this.btnBajaLogica.Size = new System.Drawing.Size(90, 27);
            this.btnBajaLogica.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnBajaLogica.Location = new System.Drawing.Point(676, 488); this.btnBajaLogica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaLogica.Click += new System.EventHandler(this.btnBajaLogica_Click);

            // frmProveedores
            this.Text = "Proveedores"; this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBajaLogica);

            this.pnlFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dgvProveedores).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
