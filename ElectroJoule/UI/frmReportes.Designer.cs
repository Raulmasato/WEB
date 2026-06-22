namespace ElectroJoule.UI
{
    partial class frmReportes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.TabControl tabReportes;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.TabPage tabInventario;
        private System.Windows.Forms.TabPage tabEstadisticas;
        private System.Windows.Forms.Panel pnlFiltrosVentas;
        private System.Windows.Forms.Label lblDesdeVentas;
        private System.Windows.Forms.DateTimePicker dtpDesdeVentas;
        private System.Windows.Forms.Label lblHastaVentas;
        private System.Windows.Forms.DateTimePicker dtpHastaVentas;
        private System.Windows.Forms.Label lblClienteV;
        private System.Windows.Forms.ComboBox cboClienteV;
        private System.Windows.Forms.Label lblComponenteV;
        private System.Windows.Forms.ComboBox cboComponenteV;
        private System.Windows.Forms.Button btnGenerarVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVComponentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVTotal;
        private System.Windows.Forms.Panel pnlBotonesVentas;
        private System.Windows.Forms.Button btnExportarPdfVentas;
        private System.Windows.Forms.Button btnExportarExcelVentas;
        private System.Windows.Forms.Panel pnlFiltrosInv;
        private System.Windows.Forms.Label lblDesdeInv;
        private System.Windows.Forms.DateTimePicker dtpDesdeInv;
        private System.Windows.Forms.Label lblHastaInv;
        private System.Windows.Forms.DateTimePicker dtpHastaInv;
        private System.Windows.Forms.Label lblComponenteI;
        private System.Windows.Forms.ComboBox cboComponenteI;
        private System.Windows.Forms.Label lblTipoMov;
        private System.Windows.Forms.ComboBox cboTipoMovimiento;
        private System.Windows.Forms.Button btnGenerarInventario;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colITipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colICantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIStock;
        private System.Windows.Forms.Panel pnlBotonesInv;
        private System.Windows.Forms.Button btnExportarPdfInventario;
        private System.Windows.Forms.Button btnExportarExcelInventario;
        private System.Windows.Forms.Panel pnlKpis;
        private System.Windows.Forms.Label lblVentasMes;
        private System.Windows.Forms.Label lblTicketPromedio;
        private System.Windows.Forms.Label lblStockCritico;
        private System.Windows.Forms.Label lblTotalPedidos;
        private System.Windows.Forms.Panel pnlGraficoPlaceholder;
        private System.Windows.Forms.Label lblGraficoTodo;

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
            this.tabReportes = new System.Windows.Forms.TabControl();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.tabInventario = new System.Windows.Forms.TabPage();
            this.tabEstadisticas = new System.Windows.Forms.TabPage();
            this.pnlFiltrosVentas = new System.Windows.Forms.Panel();
            this.lblDesdeVentas = new System.Windows.Forms.Label();
            this.dtpDesdeVentas = new System.Windows.Forms.DateTimePicker();
            this.lblHastaVentas = new System.Windows.Forms.Label();
            this.dtpHastaVentas = new System.Windows.Forms.DateTimePicker();
            this.lblClienteV = new System.Windows.Forms.Label();
            this.cboClienteV = new System.Windows.Forms.ComboBox();
            this.lblComponenteV = new System.Windows.Forms.Label();
            this.cboComponenteV = new System.Windows.Forms.ComboBox();
            this.btnGenerarVentas = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.colVFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVComponentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotonesVentas = new System.Windows.Forms.Panel();
            this.btnExportarPdfVentas = new System.Windows.Forms.Button();
            this.btnExportarExcelVentas = new System.Windows.Forms.Button();
            this.pnlFiltrosInv = new System.Windows.Forms.Panel();
            this.lblDesdeInv = new System.Windows.Forms.Label();
            this.dtpDesdeInv = new System.Windows.Forms.DateTimePicker();
            this.lblHastaInv = new System.Windows.Forms.Label();
            this.dtpHastaInv = new System.Windows.Forms.DateTimePicker();
            this.lblComponenteI = new System.Windows.Forms.Label();
            this.cboComponenteI = new System.Windows.Forms.ComboBox();
            this.lblTipoMov = new System.Windows.Forms.Label();
            this.cboTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.btnGenerarInventario = new System.Windows.Forms.Button();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.colIFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colITipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIComponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colICantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotonesInv = new System.Windows.Forms.Panel();
            this.btnExportarPdfInventario = new System.Windows.Forms.Button();
            this.btnExportarExcelInventario = new System.Windows.Forms.Button();
            this.pnlKpis = new System.Windows.Forms.Panel();
            this.lblVentasMes = new System.Windows.Forms.Label();
            this.lblTicketPromedio = new System.Windows.Forms.Label();
            this.lblStockCritico = new System.Windows.Forms.Label();
            this.lblTotalPedidos = new System.Windows.Forms.Label();
            this.pnlGraficoPlaceholder = new System.Windows.Forms.Panel();
            this.lblGraficoTodo = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.tabReportes.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.tabInventario.SuspendLayout();
            this.tabEstadisticas.SuspendLayout();
            this.pnlFiltrosVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.pnlBotonesVentas.SuspendLayout();
            this.pnlFiltrosInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.pnlBotonesInv.SuspendLayout();
            this.pnlKpis.SuspendLayout();
            this.pnlGraficoPlaceholder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.pnlEncabezado.Controls.Add(this.lblTituloForm);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(984, 40);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(0, 0);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTituloForm.Size = new System.Drawing.Size(984, 40);
            this.lblTituloForm.Text = "Reportes";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.tabVentas);
            this.tabReportes.Controls.Add(this.tabInventario);
            this.tabReportes.Controls.Add(this.tabEstadisticas);
            this.tabReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReportes.Location = new System.Drawing.Point(0, 40);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.SelectedIndex = 0;
            this.tabReportes.Size = new System.Drawing.Size(984, 521);
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.dgvVentas);
            this.tabVentas.Controls.Add(this.pnlBotonesVentas);
            this.tabVentas.Controls.Add(this.pnlFiltrosVentas);
            this.tabVentas.Location = new System.Drawing.Point(4, 24);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(976, 493);
            this.tabVentas.Text = "Ventas por período";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // pnlFiltrosVentas
            // 
            this.pnlFiltrosVentas.Controls.Add(this.lblDesdeVentas);
            this.pnlFiltrosVentas.Controls.Add(this.dtpDesdeVentas);
            this.pnlFiltrosVentas.Controls.Add(this.lblHastaVentas);
            this.pnlFiltrosVentas.Controls.Add(this.dtpHastaVentas);
            this.pnlFiltrosVentas.Controls.Add(this.lblClienteV);
            this.pnlFiltrosVentas.Controls.Add(this.cboClienteV);
            this.pnlFiltrosVentas.Controls.Add(this.lblComponenteV);
            this.pnlFiltrosVentas.Controls.Add(this.cboComponenteV);
            this.pnlFiltrosVentas.Controls.Add(this.btnGenerarVentas);
            this.pnlFiltrosVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltrosVentas.Location = new System.Drawing.Point(3, 3);
            this.pnlFiltrosVentas.Name = "pnlFiltrosVentas";
            this.pnlFiltrosVentas.Size = new System.Drawing.Size(970, 48);
            // 
            // lblDesdeVentas
            // 
            this.lblDesdeVentas.AutoSize = true;
            this.lblDesdeVentas.Location = new System.Drawing.Point(4, 16);
            this.lblDesdeVentas.Name = "lblDesdeVentas";
            this.lblDesdeVentas.Size = new System.Drawing.Size(44, 15);
            this.lblDesdeVentas.Text = "Desde:";
            // 
            // dtpDesdeVentas
            // 
            this.dtpDesdeVentas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeVentas.Location = new System.Drawing.Point(54, 13);
            this.dtpDesdeVentas.Name = "dtpDesdeVentas";
            this.dtpDesdeVentas.Size = new System.Drawing.Size(110, 23);
            // 
            // lblHastaVentas
            // 
            this.lblHastaVentas.AutoSize = true;
            this.lblHastaVentas.Location = new System.Drawing.Point(170, 16);
            this.lblHastaVentas.Name = "lblHastaVentas";
            this.lblHastaVentas.Size = new System.Drawing.Size(40, 15);
            this.lblHastaVentas.Text = "Hasta:";
            // 
            // dtpHastaVentas
            // 
            this.dtpHastaVentas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaVentas.Location = new System.Drawing.Point(216, 13);
            this.dtpHastaVentas.Name = "dtpHastaVentas";
            this.dtpHastaVentas.Size = new System.Drawing.Size(110, 23);
            // 
            // lblClienteV
            // 
            this.lblClienteV.AutoSize = true;
            this.lblClienteV.Location = new System.Drawing.Point(334, 16);
            this.lblClienteV.Name = "lblClienteV";
            this.lblClienteV.Size = new System.Drawing.Size(48, 15);
            this.lblClienteV.Text = "Cliente:";
            // 
            // cboClienteV
            // 
            this.cboClienteV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClienteV.Location = new System.Drawing.Point(388, 13);
            this.cboClienteV.Name = "cboClienteV";
            this.cboClienteV.Size = new System.Drawing.Size(140, 23);
            // 
            // lblComponenteV
            // 
            this.lblComponenteV.AutoSize = true;
            this.lblComponenteV.Location = new System.Drawing.Point(536, 16);
            this.lblComponenteV.Name = "lblComponenteV";
            this.lblComponenteV.Size = new System.Drawing.Size(80, 15);
            this.lblComponenteV.Text = "Componente:";
            // 
            // cboComponenteV
            // 
            this.cboComponenteV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComponenteV.Location = new System.Drawing.Point(622, 13);
            this.cboComponenteV.Name = "cboComponenteV";
            this.cboComponenteV.Size = new System.Drawing.Size(140, 23);
            // 
            // btnGenerarVentas
            // 
            this.btnGenerarVentas.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnGenerarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarVentas.ForeColor = System.Drawing.Color.White;
            this.btnGenerarVentas.Location = new System.Drawing.Point(770, 11);
            this.btnGenerarVentas.Name = "btnGenerarVentas";
            this.btnGenerarVentas.Size = new System.Drawing.Size(90, 27);
            this.btnGenerarVentas.Text = "Generar";
            this.btnGenerarVentas.UseVisualStyleBackColor = false;
            this.btnGenerarVentas.Click += new System.EventHandler(this.btnGenerarVentas_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colVFecha,
                this.colVCliente,
                this.colVComponentes,
                this.colVTotal});
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.Location = new System.Drawing.Point(3, 51);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(970, 399);
            // 
            // colVFecha
            // 
            this.colVFecha.HeaderText = "Fecha";
            this.colVFecha.Name = "colVFecha";
            this.colVFecha.ReadOnly = true;
            // 
            // colVCliente
            // 
            this.colVCliente.HeaderText = "Cliente";
            this.colVCliente.Name = "colVCliente";
            this.colVCliente.ReadOnly = true;
            // 
            // colVComponentes
            // 
            this.colVComponentes.HeaderText = "Componentes";
            this.colVComponentes.Name = "colVComponentes";
            this.colVComponentes.ReadOnly = true;
            // 
            // colVTotal
            // 
            this.colVTotal.HeaderText = "Total";
            this.colVTotal.Name = "colVTotal";
            this.colVTotal.ReadOnly = true;
            // 
            // pnlBotonesVentas
            // 
            this.pnlBotonesVentas.Controls.Add(this.btnExportarPdfVentas);
            this.pnlBotonesVentas.Controls.Add(this.btnExportarExcelVentas);
            this.pnlBotonesVentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonesVentas.Location = new System.Drawing.Point(3, 450);
            this.pnlBotonesVentas.Name = "pnlBotonesVentas";
            this.pnlBotonesVentas.Size = new System.Drawing.Size(970, 40);
            // 
            // btnExportarPdfVentas
            // 
            this.btnExportarPdfVentas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExportarPdfVentas.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnExportarPdfVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarPdfVentas.ForeColor = System.Drawing.Color.White;
            this.btnExportarPdfVentas.Location = new System.Drawing.Point(744, 7);
            this.btnExportarPdfVentas.Name = "btnExportarPdfVentas";
            this.btnExportarPdfVentas.Size = new System.Drawing.Size(110, 27);
            this.btnExportarPdfVentas.Text = "Exportar PDF";
            this.btnExportarPdfVentas.UseVisualStyleBackColor = false;
            this.btnExportarPdfVentas.Click += new System.EventHandler(this.btnExportarPdfVentas_Click);
            // 
            // btnExportarExcelVentas
            // 
            this.btnExportarExcelVentas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExportarExcelVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcelVentas.Location = new System.Drawing.Point(862, 7);
            this.btnExportarExcelVentas.Name = "btnExportarExcelVentas";
            this.btnExportarExcelVentas.Size = new System.Drawing.Size(110, 27);
            this.btnExportarExcelVentas.Text = "Exportar Excel";
            this.btnExportarExcelVentas.Click += new System.EventHandler(this.btnExportarExcelVentas_Click);
            // 
            // tabInventario
            // 
            this.tabInventario.Controls.Add(this.dgvMovimientos);
            this.tabInventario.Controls.Add(this.pnlBotonesInv);
            this.tabInventario.Controls.Add(this.pnlFiltrosInv);
            this.tabInventario.Location = new System.Drawing.Point(4, 24);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventario.Size = new System.Drawing.Size(976, 493);
            this.tabInventario.Text = "Movimientos de inventario";
            this.tabInventario.UseVisualStyleBackColor = true;
            // 
            // pnlFiltrosInv
            // 
            this.pnlFiltrosInv.Controls.Add(this.lblDesdeInv);
            this.pnlFiltrosInv.Controls.Add(this.dtpDesdeInv);
            this.pnlFiltrosInv.Controls.Add(this.lblHastaInv);
            this.pnlFiltrosInv.Controls.Add(this.dtpHastaInv);
            this.pnlFiltrosInv.Controls.Add(this.lblComponenteI);
            this.pnlFiltrosInv.Controls.Add(this.cboComponenteI);
            this.pnlFiltrosInv.Controls.Add(this.lblTipoMov);
            this.pnlFiltrosInv.Controls.Add(this.cboTipoMovimiento);
            this.pnlFiltrosInv.Controls.Add(this.btnGenerarInventario);
            this.pnlFiltrosInv.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltrosInv.Location = new System.Drawing.Point(3, 3);
            this.pnlFiltrosInv.Name = "pnlFiltrosInv";
            this.pnlFiltrosInv.Size = new System.Drawing.Size(970, 48);
            // 
            // lblDesdeInv
            // 
            this.lblDesdeInv.AutoSize = true;
            this.lblDesdeInv.Location = new System.Drawing.Point(4, 16);
            this.lblDesdeInv.Name = "lblDesdeInv";
            this.lblDesdeInv.Size = new System.Drawing.Size(44, 15);
            this.lblDesdeInv.Text = "Desde:";
            // 
            // dtpDesdeInv
            // 
            this.dtpDesdeInv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeInv.Location = new System.Drawing.Point(54, 13);
            this.dtpDesdeInv.Name = "dtpDesdeInv";
            this.dtpDesdeInv.Size = new System.Drawing.Size(110, 23);
            // 
            // lblHastaInv
            // 
            this.lblHastaInv.AutoSize = true;
            this.lblHastaInv.Location = new System.Drawing.Point(170, 16);
            this.lblHastaInv.Name = "lblHastaInv";
            this.lblHastaInv.Size = new System.Drawing.Size(40, 15);
            this.lblHastaInv.Text = "Hasta:";
            // 
            // dtpHastaInv
            // 
            this.dtpHastaInv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaInv.Location = new System.Drawing.Point(216, 13);
            this.dtpHastaInv.Name = "dtpHastaInv";
            this.dtpHastaInv.Size = new System.Drawing.Size(110, 23);
            // 
            // lblComponenteI
            // 
            this.lblComponenteI.AutoSize = true;
            this.lblComponenteI.Location = new System.Drawing.Point(334, 16);
            this.lblComponenteI.Name = "lblComponenteI";
            this.lblComponenteI.Size = new System.Drawing.Size(80, 15);
            this.lblComponenteI.Text = "Componente:";
            // 
            // cboComponenteI
            // 
            this.cboComponenteI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComponenteI.Location = new System.Drawing.Point(420, 13);
            this.cboComponenteI.Name = "cboComponenteI";
            this.cboComponenteI.Size = new System.Drawing.Size(140, 23);
            // 
            // lblTipoMov
            // 
            this.lblTipoMov.AutoSize = true;
            this.lblTipoMov.Location = new System.Drawing.Point(568, 16);
            this.lblTipoMov.Name = "lblTipoMov";
            this.lblTipoMov.Size = new System.Drawing.Size(34, 15);
            this.lblTipoMov.Text = "Tipo:";
            // 
            // cboTipoMovimiento
            // 
            this.cboTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMovimiento.Items.AddRange(new object[] { "entrada", "salida", "ajuste"});
            this.cboTipoMovimiento.Location = new System.Drawing.Point(608, 13);
            this.cboTipoMovimiento.Name = "cboTipoMovimiento";
            this.cboTipoMovimiento.Size = new System.Drawing.Size(120, 23);
            // 
            // btnGenerarInventario
            // 
            this.btnGenerarInventario.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnGenerarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarInventario.ForeColor = System.Drawing.Color.White;
            this.btnGenerarInventario.Location = new System.Drawing.Point(736, 11);
            this.btnGenerarInventario.Name = "btnGenerarInventario";
            this.btnGenerarInventario.Size = new System.Drawing.Size(90, 27);
            this.btnGenerarInventario.Text = "Generar";
            this.btnGenerarInventario.UseVisualStyleBackColor = false;
            this.btnGenerarInventario.Click += new System.EventHandler(this.btnGenerarInventario_Click);
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.AllowUserToAddRows = false;
            this.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colIFecha,
                this.colITipo,
                this.colIComponente,
                this.colICantidad,
                this.colIStock});
            this.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovimientos.Location = new System.Drawing.Point(3, 51);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.ReadOnly = true;
            this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientos.Size = new System.Drawing.Size(970, 399);
            // 
            // colIFecha
            // 
            this.colIFecha.HeaderText = "Fecha";
            this.colIFecha.Name = "colIFecha";
            this.colIFecha.ReadOnly = true;
            // 
            // colITipo
            // 
            this.colITipo.HeaderText = "Tipo";
            this.colITipo.Name = "colITipo";
            this.colITipo.ReadOnly = true;
            // 
            // colIComponente
            // 
            this.colIComponente.HeaderText = "Componente";
            this.colIComponente.Name = "colIComponente";
            this.colIComponente.ReadOnly = true;
            // 
            // colICantidad
            // 
            this.colICantidad.HeaderText = "Cantidad";
            this.colICantidad.Name = "colICantidad";
            this.colICantidad.ReadOnly = true;
            // 
            // colIStock
            // 
            this.colIStock.HeaderText = "Stock resultante";
            this.colIStock.Name = "colIStock";
            this.colIStock.ReadOnly = true;
            // 
            // pnlBotonesInv
            // 
            this.pnlBotonesInv.Controls.Add(this.btnExportarPdfInventario);
            this.pnlBotonesInv.Controls.Add(this.btnExportarExcelInventario);
            this.pnlBotonesInv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonesInv.Location = new System.Drawing.Point(3, 450);
            this.pnlBotonesInv.Name = "pnlBotonesInv";
            this.pnlBotonesInv.Size = new System.Drawing.Size(970, 40);
            // 
            // btnExportarPdfInventario
            // 
            this.btnExportarPdfInventario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExportarPdfInventario.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnExportarPdfInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarPdfInventario.ForeColor = System.Drawing.Color.White;
            this.btnExportarPdfInventario.Location = new System.Drawing.Point(744, 7);
            this.btnExportarPdfInventario.Name = "btnExportarPdfInventario";
            this.btnExportarPdfInventario.Size = new System.Drawing.Size(110, 27);
            this.btnExportarPdfInventario.Text = "Exportar PDF";
            this.btnExportarPdfInventario.UseVisualStyleBackColor = false;
            this.btnExportarPdfInventario.Click += new System.EventHandler(this.btnExportarPdfInventario_Click);
            // 
            // btnExportarExcelInventario
            // 
            this.btnExportarExcelInventario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExportarExcelInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcelInventario.Location = new System.Drawing.Point(862, 7);
            this.btnExportarExcelInventario.Name = "btnExportarExcelInventario";
            this.btnExportarExcelInventario.Size = new System.Drawing.Size(110, 27);
            this.btnExportarExcelInventario.Text = "Exportar Excel";
            this.btnExportarExcelInventario.Click += new System.EventHandler(this.btnExportarExcelInventario_Click);
            // 
            // tabEstadisticas
            // 
            this.tabEstadisticas.Controls.Add(this.pnlGraficoPlaceholder);
            this.tabEstadisticas.Controls.Add(this.pnlKpis);
            this.tabEstadisticas.Location = new System.Drawing.Point(4, 24);
            this.tabEstadisticas.Name = "tabEstadisticas";
            this.tabEstadisticas.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstadisticas.Size = new System.Drawing.Size(976, 493);
            this.tabEstadisticas.Text = "Dashboard";
            this.tabEstadisticas.UseVisualStyleBackColor = true;
            // 
            // pnlKpis
            // 
            this.pnlKpis.BackColor = System.Drawing.Color.FromArgb(189, 215, 238);
            this.pnlKpis.Controls.Add(this.lblVentasMes);
            this.pnlKpis.Controls.Add(this.lblTicketPromedio);
            this.pnlKpis.Controls.Add(this.lblStockCritico);
            this.pnlKpis.Controls.Add(this.lblTotalPedidos);
            this.pnlKpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpis.Location = new System.Drawing.Point(3, 3);
            this.pnlKpis.Name = "pnlKpis";
            this.pnlKpis.Size = new System.Drawing.Size(970, 80);
            // 
            // lblVentasMes
            // 
            this.lblVentasMes.AutoSize = true;
            this.lblVentasMes.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblVentasMes.Location = new System.Drawing.Point(20, 28);
            this.lblVentasMes.Name = "lblVentasMes";
            this.lblVentasMes.Size = new System.Drawing.Size(140, 20);
            this.lblVentasMes.Text = "Ventas del mes: -";
            // 
            // lblTicketPromedio
            // 
            this.lblTicketPromedio.AutoSize = true;
            this.lblTicketPromedio.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblTicketPromedio.Location = new System.Drawing.Point(240, 28);
            this.lblTicketPromedio.Name = "lblTicketPromedio";
            this.lblTicketPromedio.Size = new System.Drawing.Size(150, 20);
            this.lblTicketPromedio.Text = "Ticket promedio: -";
            // 
            // lblStockCritico
            // 
            this.lblStockCritico.AutoSize = true;
            this.lblStockCritico.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblStockCritico.Location = new System.Drawing.Point(470, 28);
            this.lblStockCritico.Name = "lblStockCritico";
            this.lblStockCritico.Size = new System.Drawing.Size(120, 20);
            this.lblStockCritico.Text = "Stock crítico: -";
            // 
            // lblTotalPedidos
            // 
            this.lblTotalPedidos.AutoSize = true;
            this.lblTotalPedidos.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblTotalPedidos.Location = new System.Drawing.Point(680, 28);
            this.lblTotalPedidos.Name = "lblTotalPedidos";
            this.lblTotalPedidos.Size = new System.Drawing.Size(130, 20);
            this.lblTotalPedidos.Text = "Total pedidos: -";
            // 
            // pnlGraficoPlaceholder
            // 
            this.pnlGraficoPlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraficoPlaceholder.Controls.Add(this.lblGraficoTodo);
            this.pnlGraficoPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGraficoPlaceholder.Location = new System.Drawing.Point(3, 83);
            this.pnlGraficoPlaceholder.Name = "pnlGraficoPlaceholder";
            this.pnlGraficoPlaceholder.Size = new System.Drawing.Size(970, 407);
            // 
            // lblGraficoTodo
            // 
            this.lblGraficoTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGraficoTodo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblGraficoTodo.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblGraficoTodo.Location = new System.Drawing.Point(0, 0);
            this.lblGraficoTodo.Name = "lblGraficoTodo";
            this.lblGraficoTodo.Size = new System.Drawing.Size(968, 405);
            this.lblGraficoTodo.Text = "Gráfico de ventas (Chart) - // TODO";
            this.lblGraficoTodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabReportes);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmReportes";
            this.Text = "Reportes";
            this.pnlEncabezado.ResumeLayout(false);
            this.tabReportes.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            this.tabInventario.ResumeLayout(false);
            this.tabEstadisticas.ResumeLayout(false);
            this.pnlFiltrosVentas.ResumeLayout(false);
            this.pnlFiltrosVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.pnlBotonesVentas.ResumeLayout(false);
            this.pnlFiltrosInv.ResumeLayout(false);
            this.pnlFiltrosInv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.pnlBotonesInv.ResumeLayout(false);
            this.pnlKpis.ResumeLayout(false);
            this.pnlKpis.PerformLayout();
            this.pnlGraficoPlaceholder.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
