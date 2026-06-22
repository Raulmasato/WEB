namespace ElectroJoule.UI
{
    partial class frmPedidos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.SplitContainer splitPedidos;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.DataGridView dgvDetallePedido;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.ComboBox cboNuevoEstado;
        private System.Windows.Forms.Button btnActualizarEstado;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.splitPedidos = new System.Windows.Forms.SplitContainer();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.dgvDetallePedido = new System.Windows.Forms.DataGridView();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.cboNuevoEstado = new System.Windows.Forms.ComboBox();
            this.btnActualizarEstado = new System.Windows.Forms.Button();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPedidos)).BeginInit();
            this.splitPedidos.Panel1.SuspendLayout();
            this.splitPedidos.Panel2.SuspendLayout();
            this.splitPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedido)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();

            // pnlEncabezado
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Height = 40;
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Controls.Add(this.lblTituloForm);

            // lblTituloForm
            this.lblTituloForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI Semibold", 12f);
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloForm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTituloForm.Text = "Gestión de Pedidos";
            this.lblTituloForm.Name = "lblTituloForm";

            // pnlFiltros
            this.pnlFiltros.Controls.Add(this.cboEstado);
            this.pnlFiltros.Controls.Add(this.lblDesde);
            this.pnlFiltros.Controls.Add(this.dtpDesde);
            this.pnlFiltros.Controls.Add(this.lblHasta);
            this.pnlFiltros.Controls.Add(this.dtpHasta);
            this.pnlFiltros.Controls.Add(this.txtBuscarCliente);
            this.pnlFiltros.Controls.Add(this.btnBuscar);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Height = 48;
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(8);
            this.pnlFiltros.Name = "pnlFiltros";

            this.cboEstado.Location = new System.Drawing.Point(8, 12);
            this.cboEstado.Size = new System.Drawing.Size(130, 23);
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Items.AddRange(new object[] { "Todos", "pendiente", "en proceso", "entregado", "cancelado" });
            this.cboEstado.SelectedIndex = 0;
            this.cboEstado.Name = "cboEstado";

            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(146, 15);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Text = "Desde:";

            this.dtpDesde.Location = new System.Drawing.Point(196, 12);
            this.dtpDesde.Size = new System.Drawing.Size(120, 23);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Name = "dtpDesde";

            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(322, 15);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Text = "Hasta:";

            this.dtpHasta.Location = new System.Drawing.Point(366, 12);
            this.dtpHasta.Size = new System.Drawing.Size(120, 23);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Name = "dtpHasta";

            this.txtBuscarCliente.Location = new System.Drawing.Point(494, 12);
            this.txtBuscarCliente.Size = new System.Drawing.Size(160, 23);
            this.txtBuscarCliente.Name = "txtBuscarCliente";

            this.btnBuscar.Location = new System.Drawing.Point(662, 10);
            this.btnBuscar.Size = new System.Drawing.Size(80, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // splitPedidos
            this.splitPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPedidos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitPedidos.Name = "splitPedidos";
            this.splitPedidos.SplitterDistance = 320;

            // dgvPedidos
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.SelectionChanged += new System.EventHandler(this.dgvPedidos_SelectionChanged);
            System.Windows.Forms.DataGridViewTextBoxColumn colNum = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colNum", HeaderText = "Nº", DataPropertyName = "Numero" };
            System.Windows.Forms.DataGridViewTextBoxColumn colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colFecha", HeaderText = "Fecha", DataPropertyName = "Fecha" };
            System.Windows.Forms.DataGridViewTextBoxColumn colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCliente", HeaderText = "Cliente", DataPropertyName = "Cliente" };
            System.Windows.Forms.DataGridViewTextBoxColumn colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colEstado", HeaderText = "Estado", DataPropertyName = "Estado" };
            System.Windows.Forms.DataGridViewTextBoxColumn colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Total", DataPropertyName = "Total" };
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colNum, colFecha, colCliente, colEstado, colTotal });

            // grpDetalle
            this.grpDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetalle.Text = "Detalle del pedido";
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Controls.Add(this.dgvDetallePedido);

            // dgvDetallePedido
            this.dgvDetallePedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetallePedido.ReadOnly = true;
            this.dgvDetallePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallePedido.AllowUserToAddRows = false;
            this.dgvDetallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallePedido.Name = "dgvDetallePedido";
            System.Windows.Forms.DataGridViewTextBoxColumn colCompDet = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colComponente", HeaderText = "Componente", DataPropertyName = "Componente" };
            System.Windows.Forms.DataGridViewTextBoxColumn colCantDet = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCantidad", HeaderText = "Cantidad", DataPropertyName = "Cantidad" };
            System.Windows.Forms.DataGridViewTextBoxColumn colSubDet = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colSubtotal", HeaderText = "Subtotal", DataPropertyName = "Subtotal" };
            this.dgvDetallePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colCompDet, colCantDet, colSubDet });

            // pnlAcciones
            this.pnlAcciones.Controls.Add(this.cboNuevoEstado);
            this.pnlAcciones.Controls.Add(this.btnActualizarEstado);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAcciones.Height = 44;
            this.pnlAcciones.Name = "pnlAcciones";

            this.cboNuevoEstado.Location = new System.Drawing.Point(8, 10);
            this.cboNuevoEstado.Size = new System.Drawing.Size(160, 23);
            this.cboNuevoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNuevoEstado.Items.AddRange(new object[] { "pendiente", "en proceso", "entregado", "cancelado" });
            this.cboNuevoEstado.Name = "cboNuevoEstado";

            this.btnActualizarEstado.Location = new System.Drawing.Point(176, 8);
            this.btnActualizarEstado.Size = new System.Drawing.Size(130, 28);
            this.btnActualizarEstado.Name = "btnActualizarEstado";
            this.btnActualizarEstado.Text = "Actualizar estado";
            this.btnActualizarEstado.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnActualizarEstado.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEstado.Click += new System.EventHandler(this.btnActualizarEstado_Click);

            // Assemble split
            this.splitPedidos.Panel1.Controls.Add(this.dgvPedidos);
            this.splitPedidos.Panel2.Controls.Add(this.grpDetalle);

            // frmPedidos
            this.ClientSize = new System.Drawing.Size(950, 620);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.splitPedidos);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlAcciones);
            this.Name = "frmPedidos";
            this.Text = "Gestión de Pedidos";

            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.splitPedidos.Panel1.ResumeLayout(false);
            this.splitPedidos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPedidos)).EndInit();
            this.splitPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.grpDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedido)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlEncabezado.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
