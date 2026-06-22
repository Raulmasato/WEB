namespace ElectroJoule.UI
{
    partial class frmCatalogo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlResumenCarrito;
        private System.Windows.Forms.Label lblTituloCarrito;
        private System.Windows.Forms.Label lblCantidadItems;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnVerCarrito;
        private System.Windows.Forms.FlowLayoutPanel flpProductos;

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
            this.pnlResumenCarrito = new System.Windows.Forms.Panel();
            this.lblTituloCarrito = new System.Windows.Forms.Label();
            this.lblCantidadItems = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnVerCarrito = new System.Windows.Forms.Button();
            this.flpProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFiltros.SuspendLayout();
            this.pnlResumenCarrito.SuspendLayout();
            this.SuspendLayout();

            // pnlFiltros
            this.pnlFiltros.Controls.Add(this.txtBuscar);
            this.pnlFiltros.Controls.Add(this.cboCategoria);
            this.pnlFiltros.Controls.Add(this.cboMarca);
            this.pnlFiltros.Controls.Add(this.btnBuscar);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Height = 48;
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(8);
            this.pnlFiltros.Name = "pnlFiltros";

            // txtBuscar
            this.txtBuscar.Location = new System.Drawing.Point(8, 12);
            this.txtBuscar.Size = new System.Drawing.Size(200, 23);
            this.txtBuscar.Name = "txtBuscar";

            // cboCategoria
            this.cboCategoria.Location = new System.Drawing.Point(216, 12);
            this.cboCategoria.Size = new System.Drawing.Size(160, 23);
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Name = "cboCategoria";

            // cboMarca
            this.cboMarca.Location = new System.Drawing.Point(384, 12);
            this.cboMarca.Size = new System.Drawing.Size(140, 23);
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Name = "cboMarca";

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(532, 10);
            this.btnBuscar.Size = new System.Drawing.Size(80, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E75B6");
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // pnlResumenCarrito
            this.pnlResumenCarrito.Controls.Add(this.lblTituloCarrito);
            this.pnlResumenCarrito.Controls.Add(this.lblCantidadItems);
            this.pnlResumenCarrito.Controls.Add(this.lblSubtotal);
            this.pnlResumenCarrito.Controls.Add(this.btnVerCarrito);
            this.pnlResumenCarrito.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlResumenCarrito.Width = 220;
            this.pnlResumenCarrito.BackColor = System.Drawing.Color.White;
            this.pnlResumenCarrito.Name = "pnlResumenCarrito";
            this.pnlResumenCarrito.Padding = new System.Windows.Forms.Padding(8);

            // lblTituloCarrito
            this.lblTituloCarrito.Text = "Carrito";
            this.lblTituloCarrito.Font = new System.Drawing.Font("Segoe UI Semibold", 11f);
            this.lblTituloCarrito.Location = new System.Drawing.Point(8, 8);
            this.lblTituloCarrito.Size = new System.Drawing.Size(200, 24);
            this.lblTituloCarrito.Name = "lblTituloCarrito";

            // lblCantidadItems
            this.lblCantidadItems.Text = "0 items";
            this.lblCantidadItems.Location = new System.Drawing.Point(8, 38);
            this.lblCantidadItems.Size = new System.Drawing.Size(200, 20);
            this.lblCantidadItems.Name = "lblCantidadItems";

            // lblSubtotal
            this.lblSubtotal.Text = "$ 0.00";
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2E75B6");
            this.lblSubtotal.Location = new System.Drawing.Point(8, 64);
            this.lblSubtotal.Size = new System.Drawing.Size(200, 30);
            this.lblSubtotal.Name = "lblSubtotal";

            // btnVerCarrito
            this.btnVerCarrito.Text = "Ver carrito";
            this.btnVerCarrito.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVerCarrito.Height = 36;
            this.btnVerCarrito.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E75B6");
            this.btnVerCarrito.ForeColor = System.Drawing.Color.White;
            this.btnVerCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCarrito.Name = "btnVerCarrito";
            this.btnVerCarrito.Click += new System.EventHandler(this.btnVerCarrito_Click);

            // flpProductos
            this.flpProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProductos.AutoScroll = true;
            this.flpProductos.WrapContents = true;
            this.flpProductos.Name = "flpProductos";
            this.flpProductos.BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F7FA");

            // frmCatalogo
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.flpProductos);
            this.Controls.Add(this.pnlResumenCarrito);
            this.Controls.Add(this.pnlFiltros);
            this.Name = "frmCatalogo";
            this.Text = "Catálogo de Componentes";

            this.pnlFiltros.ResumeLayout(false);
            this.pnlResumenCarrito.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
