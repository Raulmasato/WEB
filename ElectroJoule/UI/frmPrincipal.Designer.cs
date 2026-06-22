namespace ElectroJoule.UI
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalogo;
        private System.Windows.Forms.ToolStripMenuItem tsmiComponentes;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategorias;
        private System.Windows.Forms.ToolStripMenuItem tsmiMarcas;
        private System.Windows.Forms.ToolStripMenuItem mnuVentas;
        private System.Windows.Forms.ToolStripMenuItem tsmiCatalogoCompra;
        private System.Windows.Forms.ToolStripMenuItem tsmiCarrito;
        private System.Windows.Forms.ToolStripMenuItem tsmiComprobantes;
        private System.Windows.Forms.ToolStripMenuItem mnuPedidos;
        private System.Windows.Forms.ToolStripMenuItem tsmiGestionarPedidos;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistrarPago;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonas;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuOperaciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiDevoluciones;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportes;
        private System.Windows.Forms.ToolStripMenuItem mnuSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsbComponentes;
        private System.Windows.Forms.ToolStripButton tsbCarrito;
        private System.Windows.Forms.ToolStripButton tsbPedidos;
        private System.Windows.Forms.ToolStripButton tsbClientes;
        private System.Windows.Forms.ToolStripButton tsbReportes;
        private System.Windows.Forms.StatusStrip ssPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel tslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tslSpring;
        private System.Windows.Forms.ToolStripStatusLabel tslFecha;
        private System.Windows.Forms.ToolStripStatusLabel tslEstadoConexion;

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
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuCatalogo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComponentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCatalogoCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCarrito = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComprobantes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGestionarPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistrarPago = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDevoluciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsbComponentes = new System.Windows.Forms.ToolStripButton();
            this.tsbCarrito = new System.Windows.Forms.ToolStripButton();
            this.tsbPedidos = new System.Windows.Forms.ToolStripButton();
            this.tsbClientes = new System.Windows.Forms.ToolStripButton();
            this.tsbReportes = new System.Windows.Forms.ToolStripButton();
            this.ssPrincipal = new System.Windows.Forms.StatusStrip();
            this.tslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.msPrincipal.SuspendLayout();
            this.tsPrincipal.SuspendLayout();
            this.ssPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuCatalogo,
                this.mnuVentas,
                this.mnuPedidos,
                this.mnuPersonas,
                this.mnuOperaciones,
                this.mnuReportes,
                this.mnuSesion});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1264, 24);
            this.msPrincipal.Text = "msPrincipal";
            // 
            // mnuCatalogo
            // 
            this.mnuCatalogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiComponentes,
                this.tsmiCategorias,
                this.tsmiMarcas});
            this.mnuCatalogo.Name = "mnuCatalogo";
            this.mnuCatalogo.Size = new System.Drawing.Size(67, 20);
            this.mnuCatalogo.Text = "Catálogo";
            // 
            // tsmiComponentes
            // 
            this.tsmiComponentes.Name = "tsmiComponentes";
            this.tsmiComponentes.Size = new System.Drawing.Size(180, 22);
            this.tsmiComponentes.Text = "Componentes";
            this.tsmiComponentes.Click += new System.EventHandler(this.tsmiComponentes_Click);
            // 
            // tsmiCategorias
            // 
            this.tsmiCategorias.Name = "tsmiCategorias";
            this.tsmiCategorias.Size = new System.Drawing.Size(180, 22);
            this.tsmiCategorias.Text = "Categorías";
            this.tsmiCategorias.Click += new System.EventHandler(this.tsmiCategorias_Click);
            // 
            // tsmiMarcas
            // 
            this.tsmiMarcas.Name = "tsmiMarcas";
            this.tsmiMarcas.Size = new System.Drawing.Size(180, 22);
            this.tsmiMarcas.Text = "Marcas";
            this.tsmiMarcas.Click += new System.EventHandler(this.tsmiMarcas_Click);
            // 
            // mnuVentas
            // 
            this.mnuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiCatalogoCompra,
                this.tsmiCarrito,
                this.tsmiComprobantes});
            this.mnuVentas.Name = "mnuVentas";
            this.mnuVentas.Size = new System.Drawing.Size(55, 20);
            this.mnuVentas.Text = "Ventas";
            // 
            // tsmiCatalogoCompra
            // 
            this.tsmiCatalogoCompra.Name = "tsmiCatalogoCompra";
            this.tsmiCatalogoCompra.Size = new System.Drawing.Size(180, 22);
            this.tsmiCatalogoCompra.Text = "Catálogo de compra";
            this.tsmiCatalogoCompra.Click += new System.EventHandler(this.tsmiCatalogoCompra_Click);
            // 
            // tsmiCarrito
            // 
            this.tsmiCarrito.Name = "tsmiCarrito";
            this.tsmiCarrito.Size = new System.Drawing.Size(180, 22);
            this.tsmiCarrito.Text = "Carrito";
            this.tsmiCarrito.Click += new System.EventHandler(this.tsmiCarrito_Click);
            // 
            // tsmiComprobantes
            // 
            this.tsmiComprobantes.Name = "tsmiComprobantes";
            this.tsmiComprobantes.Size = new System.Drawing.Size(180, 22);
            this.tsmiComprobantes.Text = "Comprobantes";
            this.tsmiComprobantes.Click += new System.EventHandler(this.tsmiComprobantes_Click);
            // 
            // mnuPedidos
            // 
            this.mnuPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiGestionarPedidos,
                this.tsmiRegistrarPago});
            this.mnuPedidos.Name = "mnuPedidos";
            this.mnuPedidos.Size = new System.Drawing.Size(59, 20);
            this.mnuPedidos.Text = "Pedidos";
            // 
            // tsmiGestionarPedidos
            // 
            this.tsmiGestionarPedidos.Name = "tsmiGestionarPedidos";
            this.tsmiGestionarPedidos.Size = new System.Drawing.Size(180, 22);
            this.tsmiGestionarPedidos.Text = "Gestionar pedidos";
            this.tsmiGestionarPedidos.Click += new System.EventHandler(this.tsmiGestionarPedidos_Click);
            // 
            // tsmiRegistrarPago
            // 
            this.tsmiRegistrarPago.Name = "tsmiRegistrarPago";
            this.tsmiRegistrarPago.Size = new System.Drawing.Size(180, 22);
            this.tsmiRegistrarPago.Text = "Registrar pago";
            this.tsmiRegistrarPago.Click += new System.EventHandler(this.tsmiRegistrarPago_Click);
            // 
            // mnuPersonas
            // 
            this.mnuPersonas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiClientes,
                this.tsmiProveedores});
            this.mnuPersonas.Name = "mnuPersonas";
            this.mnuPersonas.Size = new System.Drawing.Size(64, 20);
            this.mnuPersonas.Text = "Personas";
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(180, 22);
            this.tsmiClientes.Text = "Clientes";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            // 
            // tsmiProveedores
            // 
            this.tsmiProveedores.Name = "tsmiProveedores";
            this.tsmiProveedores.Size = new System.Drawing.Size(180, 22);
            this.tsmiProveedores.Text = "Proveedores";
            this.tsmiProveedores.Click += new System.EventHandler(this.tsmiProveedores_Click);
            // 
            // mnuOperaciones
            // 
            this.mnuOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiDevoluciones});
            this.mnuOperaciones.Name = "mnuOperaciones";
            this.mnuOperaciones.Size = new System.Drawing.Size(82, 20);
            this.mnuOperaciones.Text = "Operaciones";
            // 
            // tsmiDevoluciones
            // 
            this.tsmiDevoluciones.Name = "tsmiDevoluciones";
            this.tsmiDevoluciones.Size = new System.Drawing.Size(180, 22);
            this.tsmiDevoluciones.Text = "Devoluciones";
            this.tsmiDevoluciones.Click += new System.EventHandler(this.tsmiDevoluciones_Click);
            // 
            // mnuReportes
            // 
            this.mnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiReportes});
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(62, 20);
            this.mnuReportes.Text = "Reportes";
            // 
            // tsmiReportes
            // 
            this.tsmiReportes.Name = "tsmiReportes";
            this.tsmiReportes.Size = new System.Drawing.Size(200, 22);
            this.tsmiReportes.Text = "Reportes y estadísticas";
            this.tsmiReportes.Click += new System.EventHandler(this.tsmiReportes_Click);
            // 
            // mnuSesion
            // 
            this.mnuSesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiCerrarSesion,
                this.tsmiSalir});
            this.mnuSesion.Name = "mnuSesion";
            this.mnuSesion.Size = new System.Drawing.Size(53, 20);
            this.mnuSesion.Text = "Sesión";
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(180, 22);
            this.tsmiCerrarSesion.Text = "Cerrar sesión";
            this.tsmiCerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(180, 22);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsbComponentes,
                this.tsbCarrito,
                this.tsbPedidos,
                this.tsbClientes,
                this.tsbReportes});
            this.tsPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(1264, 25);
            this.tsPrincipal.Text = "tsPrincipal";
            // 
            // tsbComponentes
            // 
            this.tsbComponentes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbComponentes.Name = "tsbComponentes";
            this.tsbComponentes.Size = new System.Drawing.Size(89, 22);
            this.tsbComponentes.Text = "Componentes";
            this.tsbComponentes.Click += new System.EventHandler(this.tsbComponentes_Click);
            // 
            // tsbCarrito
            // 
            this.tsbCarrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCarrito.Name = "tsbCarrito";
            this.tsbCarrito.Size = new System.Drawing.Size(48, 22);
            this.tsbCarrito.Text = "Carrito";
            this.tsbCarrito.Click += new System.EventHandler(this.tsbCarrito_Click);
            // 
            // tsbPedidos
            // 
            this.tsbPedidos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPedidos.Name = "tsbPedidos";
            this.tsbPedidos.Size = new System.Drawing.Size(53, 22);
            this.tsbPedidos.Text = "Pedidos";
            this.tsbPedidos.Click += new System.EventHandler(this.tsbPedidos_Click);
            // 
            // tsbClientes
            // 
            this.tsbClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClientes.Name = "tsbClientes";
            this.tsbClientes.Size = new System.Drawing.Size(54, 22);
            this.tsbClientes.Text = "Clientes";
            this.tsbClientes.Click += new System.EventHandler(this.tsbClientes_Click);
            // 
            // tsbReportes
            // 
            this.tsbReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReportes.Name = "tsbReportes";
            this.tsbReportes.Size = new System.Drawing.Size(61, 22);
            this.tsbReportes.Text = "Reportes";
            this.tsbReportes.Click += new System.EventHandler(this.tsbReportes_Click);
            // 
            // ssPrincipal
            // 
            this.ssPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tslUsuario,
                this.tslSpring,
                this.tslFecha,
                this.tslEstadoConexion});
            this.ssPrincipal.Location = new System.Drawing.Point(0, 659);
            this.ssPrincipal.Name = "ssPrincipal";
            this.ssPrincipal.Size = new System.Drawing.Size(1264, 22);
            this.ssPrincipal.Text = "ssPrincipal";
            // 
            // tslUsuario
            // 
            this.tslUsuario.Name = "tslUsuario";
            this.tslUsuario.Size = new System.Drawing.Size(58, 17);
            this.tslUsuario.Text = "Usuario: -";
            // 
            // tslSpring
            // 
            this.tslSpring.Name = "tslSpring";
            this.tslSpring.Size = new System.Drawing.Size(1009, 17);
            this.tslSpring.Spring = true;
            // 
            // tslFecha
            // 
            this.tslFecha.Name = "tslFecha";
            this.tslFecha.Size = new System.Drawing.Size(42, 17);
            this.tslFecha.Text = "Fecha";
            // 
            // tslEstadoConexion
            // 
            this.tslEstadoConexion.Name = "tslEstadoConexion";
            this.tslEstadoConexion.Size = new System.Drawing.Size(118, 17);
            this.tslEstadoConexion.Text = "Conectado";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tsPrincipal);
            this.Controls.Add(this.ssPrincipal);
            this.Controls.Add(this.msPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroJoule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.ssPrincipal.ResumeLayout(false);
            this.ssPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
