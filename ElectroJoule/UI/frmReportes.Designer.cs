namespace ElectroJoule.UI
{
    partial class frmReportes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabReportes;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.TabPage tabInventario;
        private System.Windows.Forms.TabPage tabEstadisticas;
        // tabVentas controls
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
        private System.Windows.Forms.Panel pnlBotonesVentas;
        private System.Windows.Forms.Button btnExportarPdfVentas;
        private System.Windows.Forms.Button btnExportarExcelVentas;
        // tabInventario controls
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
        private System.Windows.Forms.Panel pnlBotonesInv;
        private System.Windows.Forms.Button btnExportarPdfInventario;
        private System.Windows.Forms.Button btnExportarExcelInventario;
        // tabEstadisticas controls
        private System.Windows.Forms.Panel pnlKpis;
        private System.Windows.Forms.Label lblVentasMes;
        private System.Windows.Forms.Label lblTicketPromedio;
        private System.Windows.Forms.Label lblStockCritico;
        private System.Windows.Forms.Label lblTotalPedidos;
        private System.Windows.Forms.Panel pnlGraficoPlaceholder;
        private System.Windows.Forms.Label lblGraficoTodo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
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

            this.tabReportes.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.tabInventario.SuspendLayout();
            this.tabEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvMovimientos).BeginInit();
            this.SuspendLayout();

            // tabReportes
            this.tabReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReportes.TabPages.AddRange(new System.Windows.Forms.TabPage[] { this.tabVentas, this.tabInventario, this.tabEstadisticas });

            // ── tabVentas ──
            this.tabVentas.Text = "Ventas por período"; this.tabVentas.Padding = new System.Windows.Forms.Padding(4);

            this.pnlFiltrosVentas.Dock = System.Windows.Forms.DockStyle.Top; this.pnlFiltrosVentas.Height = 48;
            this.lblDesdeVentas.Text = "Desde:"; this.lblDesdeVentas.Location = new System.Drawing.Point(4, 14); this.lblDesdeVentas.AutoSize = true;
            this.dtpDesdeVentas.Location = new System.Drawing.Point(52, 10); this.dtpDesdeVentas.Size = new System.Drawing.Size(120, 23); this.dtpDesdeVentas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblHastaVentas.Text = "Hasta:"; this.lblHastaVentas.Location = new System.Drawing.Point(180, 14); this.lblHastaVentas.AutoSize = true;
            this.dtpHastaVentas.Location = new System.Drawing.Point(224, 10); this.dtpHastaVentas.Size = new System.Drawing.Size(120, 23); this.dtpHastaVentas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblClienteV.Text = "Cliente:"; this.lblClienteV.Location = new System.Drawing.Point(352, 14); this.lblClienteV.AutoSize = true;
            this.cboClienteV.Location = new System.Drawing.Point(400, 10); this.cboClienteV.Size = new System.Drawing.Size(130, 23); this.cboClienteV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblComponenteV.Text = "Componente:"; this.lblComponenteV.Location = new System.Drawing.Point(538, 14); this.lblComponenteV.AutoSize = true;
            this.cboComponenteV.Location = new System.Drawing.Point(620, 10); this.cboComponenteV.Size = new System.Drawing.Size(130, 23); this.cboComponenteV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnGenerarVentas.Text = "Generar"; this.btnGenerarVentas.Location = new System.Drawing.Point(758, 10); this.btnGenerarVentas.Size = new System.Drawing.Size(80, 27);
            this.btnGenerarVentas.BackColor = System.Drawing.Color.FromArgb(46, 117, 182); this.btnGenerarVentas.ForeColor = System.Drawing.Color.White; this.btnGenerarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarVentas.Click += new System.EventHandler(this.btnGenerarVentas_Click);
            this.pnlFiltrosVentas.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblDesdeVentas, this.dtpDesdeVentas, this.lblHastaVentas, this.dtpHastaVentas,
                this.lblClienteV, this.cboClienteV, this.lblComponenteV, this.cboComponenteV, this.btnGenerarVentas });

            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.ReadOnly = true; this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.AllowUserToAddRows = false; this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            System.Windows.Forms.DataGridViewCellStyle dgvVentasAltStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvVentasAltStyle.BackColor = System.Drawing.Color.FromArgb(234, 241, 250);
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dgvVentasAltStyle
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colFecha", HeaderText = "Fecha" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCliente", HeaderText = "Cliente" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colComponentes", HeaderText = "Componentes" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Total" },
            });

            this.pnlBotonesVentas.Dock = System.Windows.Forms.DockStyle.Bottom; this.pnlBotonesVentas.Height = 40;
            this.btnExportarPdfVentas.Text = "Exportar PDF"; this.btnExportarPdfVentas.Size = new System.Drawing.Size(110, 27);
            this.btnExportarPdfVentas.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnExportarPdfVentas.Location = new System.Drawing.Point(640, 6);
            this.btnExportarPdfVentas.BackColor = System.Drawing.Color.FromArgb(46, 117, 182); this.btnExportarPdfVentas.ForeColor = System.Drawing.Color.White; this.btnExportarPdfVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarPdfVentas.Click += new System.EventHandler(this.btnExportarPdfVentas_Click);
            this.btnExportarExcelVentas.Text = "Exportar Excel"; this.btnExportarExcelVentas.Size = new System.Drawing.Size(110, 27);
            this.btnExportarExcelVentas.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnExportarExcelVentas.Location = new System.Drawing.Point(758, 6); this.btnExportarExcelVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcelVentas.Click += new System.EventHandler(this.btnExportarExcelVentas_Click);
            this.pnlBotonesVentas.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnExportarPdfVentas, this.btnExportarExcelVentas });

            this.tabVentas.Controls.Add(this.dgvVentas);
            this.tabVentas.Controls.Add(this.pnlBotonesVentas);
            this.tabVentas.Controls.Add(this.pnlFiltrosVentas);

            // ── tabInventario ──
            this.tabInventario.Text = "Movimientos de inventario"; this.tabInventario.Padding = new System.Windows.Forms.Padding(4);

            this.pnlFiltrosInv.Dock = System.Windows.Forms.DockStyle.Top; this.pnlFiltrosInv.Height = 48;
            this.lblDesdeInv.Text = "Desde:"; this.lblDesdeInv.Location = new System.Drawing.Point(4, 14); this.lblDesdeInv.AutoSize = true;
            this.dtpDesdeInv.Location = new System.Drawing.Point(52, 10); this.dtpDesdeInv.Size = new System.Drawing.Size(120, 23); this.dtpDesdeInv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblHastaInv.Text = "Hasta:"; this.lblHastaInv.Location = new System.Drawing.Point(180, 14); this.lblHastaInv.AutoSize = true;
            this.dtpHastaInv.Location = new System.Drawing.Point(224, 10); this.dtpHastaInv.Size = new System.Drawing.Size(120, 23); this.dtpHastaInv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lblComponenteI.Text = "Componente:"; this.lblComponenteI.Location = new System.Drawing.Point(352, 14); this.lblComponenteI.AutoSize = true;
            this.cboComponenteI.Location = new System.Drawing.Point(440, 10); this.cboComponenteI.Size = new System.Drawing.Size(130, 23); this.cboComponenteI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblTipoMov.Text = "Tipo:"; this.lblTipoMov.Location = new System.Drawing.Point(578, 14); this.lblTipoMov.AutoSize = true;
            this.cboTipoMovimiento.Location = new System.Drawing.Point(610, 10); this.cboTipoMovimiento.Size = new System.Drawing.Size(120, 23); this.cboTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMovimiento.Items.AddRange(new object[] { "entrada", "salida", "ajuste" });
            this.btnGenerarInventario.Text = "Generar"; this.btnGenerarInventario.Location = new System.Drawing.Point(738, 10); this.btnGenerarInventario.Size = new System.Drawing.Size(80, 27);
            this.btnGenerarInventario.BackColor = System.Drawing.Color.FromArgb(46, 117, 182); this.btnGenerarInventario.ForeColor = System.Drawing.Color.White; this.btnGenerarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarInventario.Click += new System.EventHandler(this.btnGenerarInventario_Click);
            this.pnlFiltrosInv.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblDesdeInv, this.dtpDesdeInv, this.lblHastaInv, this.dtpHastaInv,
                this.lblComponenteI, this.cboComponenteI, this.lblTipoMov, this.cboTipoMovimiento, this.btnGenerarInventario });

            this.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovimientos.ReadOnly = true; this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientos.AllowUserToAddRows = false; this.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            System.Windows.Forms.DataGridViewCellStyle dgvMovimientosAltStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvMovimientosAltStyle.BackColor = System.Drawing.Color.FromArgb(234, 241, 250);
            this.dgvMovimientos.AlternatingRowsDefaultCellStyle = dgvMovimientosAltStyle
            this.dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colFecha", HeaderText = "Fecha" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colTipo", HeaderText = "Tipo" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colComponente", HeaderText = "Componente" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colCantidad", HeaderText = "Cantidad" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colStock", HeaderText = "Stock resultante" },
            });

            this.pnlBotonesInv.Dock = System.Windows.Forms.DockStyle.Bottom; this.pnlBotonesInv.Height = 40;
            this.btnExportarPdfInventario.Text = "Exportar PDF"; this.btnExportarPdfInventario.Size = new System.Drawing.Size(110, 27);
            this.btnExportarPdfInventario.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnExportarPdfInventario.Location = new System.Drawing.Point(640, 6);
            this.btnExportarPdfInventario.BackColor = System.Drawing.Color.FromArgb(46, 117, 182); this.btnExportarPdfInventario.ForeColor = System.Drawing.Color.White; this.btnExportarPdfInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarPdfInventario.Click += new System.EventHandler(this.btnExportarPdfInventario_Click);
            this.btnExportarExcelInventario.Text = "Exportar Excel"; this.btnExportarExcelInventario.Size = new System.Drawing.Size(110, 27);
            this.btnExportarExcelInventario.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnExportarExcelInventario.Location = new System.Drawing.Point(758, 6); this.btnExportarExcelInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcelInventario.Click += new System.EventHandler(this.btnExportarExcelInventario_Click);
            this.pnlBotonesInv.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnExportarPdfInventario, this.btnExportarExcelInventario });

            this.tabInventario.Controls.Add(this.dgvMovimientos);
            this.tabInventario.Controls.Add(this.pnlBotonesInv);
            this.tabInventario.Controls.Add(this.pnlFiltrosInv);

            // ── tabEstadisticas ──
            this.tabEstadisticas.Text = "Dashboard"; this.tabEstadisticas.Padding = new System.Windows.Forms.Padding(4);

            this.pnlKpis.Dock = System.Windows.Forms.DockStyle.Top; this.pnlKpis.Height = 80; this.pnlKpis.BackColor = System.Drawing.Color.FromArgb(189, 215, 238);
            this.lblVentasMes.Text = "Ventas del mes: —"; this.lblVentasMes.Location = new System.Drawing.Point(20, 15); this.lblVentasMes.AutoSize = true; this.lblVentasMes.Font = new System.Drawing.Font("Segoe UI Semibold", 11f);
            this.lblTicketPromedio.Text = "Ticket promedio: —"; this.lblTicketPromedio.Location = new System.Drawing.Point(220, 15); this.lblTicketPromedio.AutoSize = true; this.lblTicketPromedio.Font = new System.Drawing.Font("Segoe UI Semibold", 11f);
            this.lblStockCritico.Text = "Stock crítico: —"; this.lblStockCritico.Location = new System.Drawing.Point(440, 15); this.lblStockCritico.AutoSize = true; this.lblStockCritico.Font = new System.Drawing.Font("Segoe UI Semibold", 11f);
            this.lblTotalPedidos.Text = "Total pedidos: —"; this.lblTotalPedidos.Location = new System.Drawing.Point(640, 15); this.lblTotalPedidos.AutoSize = true; this.lblTotalPedidos.Font = new System.Drawing.Font("Segoe UI Semibold", 11f);
            this.pnlKpis.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblVentasMes, this.lblTicketPromedio, this.lblStockCritico, this.lblTotalPedidos });

            this.pnlGraficoPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill; this.pnlGraficoPlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGraficoTodo.Text = "Gráfico de ventas (System.Windows.Forms.DataVisualization.Charting.Chart) — // TODO";
            this.lblGraficoTodo.Dock = System.Windows.Forms.DockStyle.Fill; this.lblGraficoTodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGraficoTodo.Font = new System.Drawing.Font("Segoe UI Semibold", 11f); this.lblGraficoTodo.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.pnlGraficoPlaceholder.Controls.Add(this.lblGraficoTodo);

            this.tabEstadisticas.Controls.Add(this.pnlGraficoPlaceholder);
            this.tabEstadisticas.Controls.Add(this.pnlKpis);

            // frmReportes
            this.Text = "Reportes y Estadísticas"; this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.tabReportes);

            this.tabReportes.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            this.tabInventario.ResumeLayout(false);
            this.tabEstadisticas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dgvMovimientos).EndInit();
            this.ResumeLayout(false);
        }
    }
}
