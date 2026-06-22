namespace ElectroJoule.UI
{
    partial class frmCatalogo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTituloForm;
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
            this.pnlEncabezado.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.pnlResumenCarrito.SuspendLayout();
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
            this.lblTituloForm.Text = "Catálogo";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.txtBuscar);
            this.pnlFiltros.Controls.Add(this.cboCategoria);
            this.pnlFiltros.Controls.Add(this.cboMarca);
            this.pnlFiltros.Controls.Add(this.btnBuscar);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 40);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(984, 48);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(220, 23);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Location = new System.Drawing.Point(240, 13);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(150, 23);
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Location = new System.Drawing.Point(398, 13);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(150, 23);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(556, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 27);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlResumenCarrito
            // 
            this.pnlResumenCarrito.BackColor = System.Drawing.Color.FromArgb(189, 215, 238);
            this.pnlResumenCarrito.Controls.Add(this.lblTituloCarrito);
            this.pnlResumenCarrito.Controls.Add(this.lblCantidadItems);
            this.pnlResumenCarrito.Controls.Add(this.lblSubtotal);
            this.pnlResumenCarrito.Controls.Add(this.btnVerCarrito);
            this.pnlResumenCarrito.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlResumenCarrito.Location = new System.Drawing.Point(764, 88);
            this.pnlResumenCarrito.Name = "pnlResumenCarrito";
            this.pnlResumenCarrito.Size = new System.Drawing.Size(220, 473);
            // 
            // lblTituloCarrito
            // 
            this.lblTituloCarrito.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblTituloCarrito.Location = new System.Drawing.Point(12, 16);
            this.lblTituloCarrito.Name = "lblTituloCarrito";
            this.lblTituloCarrito.Size = new System.Drawing.Size(196, 28);
            this.lblTituloCarrito.Text = "Carrito";
            // 
            // lblCantidadItems
            // 
            this.lblCantidadItems.Location = new System.Drawing.Point(12, 56);
            this.lblCantidadItems.Name = "lblCantidadItems";
            this.lblCantidadItems.Size = new System.Drawing.Size(196, 20);
            this.lblCantidadItems.Text = "0 ítems";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.lblSubtotal.Location = new System.Drawing.Point(12, 86);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(196, 36);
            this.lblSubtotal.Text = "$ 0.00";
            // 
            // btnVerCarrito
            // 
            this.btnVerCarrito.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnVerCarrito.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVerCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCarrito.ForeColor = System.Drawing.Color.White;
            this.btnVerCarrito.Location = new System.Drawing.Point(0, 433);
            this.btnVerCarrito.Name = "btnVerCarrito";
            this.btnVerCarrito.Size = new System.Drawing.Size(220, 40);
            this.btnVerCarrito.Text = "Ver carrito";
            this.btnVerCarrito.UseVisualStyleBackColor = false;
            this.btnVerCarrito.Click += new System.EventHandler(this.btnVerCarrito_Click);
            // 
            // flpProductos
            // 
            this.flpProductos.AutoScroll = true;
            this.flpProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProductos.Location = new System.Drawing.Point(0, 88);
            this.flpProductos.Name = "flpProductos";
            this.flpProductos.Padding = new System.Windows.Forms.Padding(10);
            this.flpProductos.Size = new System.Drawing.Size(764, 473);
            this.flpProductos.WrapContents = true;
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.flpProductos);
            this.Controls.Add(this.pnlResumenCarrito);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmCatalogo";
            this.Text = "Catálogo";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlResumenCarrito.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
