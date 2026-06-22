namespace ElectroJoule.UI
{
    partial class frmComponentes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.SplitContainer splitPrincipal;
        private System.Windows.Forms.DataGridView dgvComponentes;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label lblCategoriaEdit;
        private System.Windows.Forms.ComboBox cboCategoriaEdit;
        private System.Windows.Forms.Label lblMarcaEdit;
        private System.Windows.Forms.ComboBox cboMarcaEdit;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.splitPrincipal = new System.Windows.Forms.SplitContainer();
            this.dgvComponentes = new System.Windows.Forms.DataGridView();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.lblCategoriaEdit = new System.Windows.Forms.Label();
            this.cboCategoriaEdit = new System.Windows.Forms.ComboBox();
            this.lblMarcaEdit = new System.Windows.Forms.Label();
            this.cboMarcaEdit = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).BeginInit();
            this.splitPrincipal.Panel1.SuspendLayout();
            this.splitPrincipal.Panel2.SuspendLayout();
            this.splitPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).BeginInit();
            this.pnlEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.SuspendLayout();

            // pnlFiltros
            this.pnlFiltros.Controls.Add(this.txtBuscar);
            this.pnlFiltros.Controls.Add(this.cboCategoria);
            this.pnlFiltros.Controls.Add(this.cboMarca);
            this.pnlFiltros.Controls.Add(this.btnBuscar);
            this.pnlFiltros.Controls.Add(this.btnLimpiar);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Height = 48;
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(8);
            this.pnlFiltros.Name = "pnlFiltros";

            // txtBuscar
            this.txtBuscar.Location = new System.Drawing.Point(8, 12);
            this.txtBuscar.Size = new System.Drawing.Size(180, 23);
            this.txtBuscar.Name = "txtBuscar";

            // cboCategoria
            this.cboCategoria.Location = new System.Drawing.Point(196, 12);
            this.cboCategoria.Size = new System.Drawing.Size(160, 23);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // cboMarca
            this.cboMarca.Location = new System.Drawing.Point(364, 12);
            this.cboMarca.Size = new System.Drawing.Size(140, 23);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(512, 10);
            this.btnBuscar.Size = new System.Drawing.Size(80, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // btnLimpiar
            this.btnLimpiar.Location = new System.Drawing.Point(600, 10);
            this.btnLimpiar.Size = new System.Drawing.Size(80, 26);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // splitPrincipal
            this.splitPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitPrincipal.Name = "splitPrincipal";
            this.splitPrincipal.SplitterDistance = 280;

            // dgvComponentes
            this.dgvComponentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComponentes.ReadOnly = true;
            this.dgvComponentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComponentes.AllowUserToAddRows = false;
            this.dgvComponentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComponentes.Name = "dgvComponentes";
            this.dgvComponentes.SelectionChanged += new System.EventHandler(this.dgvComponentes_SelectionChanged);
            var colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCodigo", HeaderText = "Código", DataPropertyName = "Codigo" };
            var colNombreC = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colNombre", HeaderText = "Nombre", DataPropertyName = "Nombre" };
            var colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCategoria", HeaderText = "Categoría", DataPropertyName = "Categoria" };
            var colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colMarca", HeaderText = "Marca", DataPropertyName = "Marca" };
            var colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colPrecio", HeaderText = "Precio", DataPropertyName = "Precio" };
            var colStock = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colStock", HeaderText = "Stock", DataPropertyName = "Stock" };
            this.dgvComponentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colCodigo, colNombreC, colCategoria, colMarca, colPrecio, colStock });

            // pnlEdicion (Panel2 of split)
            this.pnlEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Controls.Add(this.lblCodigo);
            this.pnlEdicion.Controls.Add(this.txtCodigo);
            this.pnlEdicion.Controls.Add(this.lblNombre);
            this.pnlEdicion.Controls.Add(this.txtNombre);
            this.pnlEdicion.Controls.Add(this.lblDescripcion);
            this.pnlEdicion.Controls.Add(this.txtDescripcion);
            this.pnlEdicion.Controls.Add(this.lblPrecio);
            this.pnlEdicion.Controls.Add(this.numPrecio);
            this.pnlEdicion.Controls.Add(this.lblStock);
            this.pnlEdicion.Controls.Add(this.numStock);
            this.pnlEdicion.Controls.Add(this.lblCategoriaEdit);
            this.pnlEdicion.Controls.Add(this.cboCategoriaEdit);
            this.pnlEdicion.Controls.Add(this.lblMarcaEdit);
            this.pnlEdicion.Controls.Add(this.cboMarcaEdit);
            this.pnlEdicion.Controls.Add(this.btnNuevo);
            this.pnlEdicion.Controls.Add(this.btnGuardar);
            this.pnlEdicion.Controls.Add(this.btnEliminar);
            this.pnlEdicion.Controls.Add(this.btnCancelar);

            // Left column controls
            // lblCodigo
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 8);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Text = "Código:";

            // txtCodigo
            this.txtCodigo.Location = new System.Drawing.Point(8, 26);
            this.txtCodigo.Size = new System.Drawing.Size(200, 23);
            this.txtCodigo.Name = "txtCodigo";

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Text = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(8, 74);
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.Name = "txtNombre";

            // lblDescripcion
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(8, 104);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Text = "Descripción:";

            // txtDescripcion
            this.txtDescripcion.Location = new System.Drawing.Point(8, 122);
            this.txtDescripcion.Size = new System.Drawing.Size(200, 60);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";

            // Right column controls
            // lblPrecio
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(220, 8);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Text = "Precio:";

            // numPrecio
            this.numPrecio.Location = new System.Drawing.Point(220, 26);
            this.numPrecio.Size = new System.Drawing.Size(200, 23);
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Maximum = 9999999;
            this.numPrecio.Name = "numPrecio";

            // lblStock
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(220, 56);
            this.lblStock.Name = "lblStock";
            this.lblStock.Text = "Stock:";

            // numStock
            this.numStock.Location = new System.Drawing.Point(220, 74);
            this.numStock.Size = new System.Drawing.Size(200, 23);
            this.numStock.Maximum = 99999;
            this.numStock.Name = "numStock";

            // lblCategoriaEdit
            this.lblCategoriaEdit.AutoSize = true;
            this.lblCategoriaEdit.Location = new System.Drawing.Point(220, 104);
            this.lblCategoriaEdit.Name = "lblCategoriaEdit";
            this.lblCategoriaEdit.Text = "Categoría:";

            // cboCategoriaEdit
            this.cboCategoriaEdit.Location = new System.Drawing.Point(220, 122);
            this.cboCategoriaEdit.Size = new System.Drawing.Size(200, 23);
            this.cboCategoriaEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaEdit.Name = "cboCategoriaEdit";

            // lblMarcaEdit
            this.lblMarcaEdit.AutoSize = true;
            this.lblMarcaEdit.Location = new System.Drawing.Point(220, 152);
            this.lblMarcaEdit.Name = "lblMarcaEdit";
            this.lblMarcaEdit.Text = "Marca:";

            // cboMarcaEdit
            this.cboMarcaEdit.Location = new System.Drawing.Point(220, 170);
            this.cboMarcaEdit.Size = new System.Drawing.Size(200, 23);
            this.cboMarcaEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaEdit.Name = "cboMarcaEdit";

            // Buttons
            this.btnNuevo.Location = new System.Drawing.Point(440, 160);
            this.btnNuevo.Size = new System.Drawing.Size(80, 28);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);

            this.btnGuardar.Location = new System.Drawing.Point(528, 160);
            this.btnGuardar.Size = new System.Drawing.Size(80, 28);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.btnEliminar.Location = new System.Drawing.Point(616, 160);
            this.btnEliminar.Size = new System.Drawing.Size(80, 28);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            this.btnCancelar.Location = new System.Drawing.Point(704, 160);
            this.btnCancelar.Size = new System.Drawing.Size(80, 28);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // Assemble split
            this.splitPrincipal.Panel1.Controls.Add(this.dgvComponentes);
            this.splitPrincipal.Panel2.Controls.Add(this.pnlEdicion);

            // frmComponentes
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.splitPrincipal);
            this.Controls.Add(this.pnlFiltros);
            this.Name = "frmComponentes";
            this.Text = "Gestión de Componentes";

            this.pnlFiltros.ResumeLayout(false);
            this.splitPrincipal.Panel1.ResumeLayout(false);
            this.splitPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPrincipal)).EndInit();
            this.splitPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).EndInit();
            this.pnlEdicion.ResumeLayout(false);
            this.pnlEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
