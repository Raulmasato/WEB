namespace ElectroJoule.UI
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiCatalogo;
        private System.Windows.Forms.ToolStripMenuItem tsmiComponentes;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategorias;
        private System.Windows.Forms.ToolStripMenuItem tsmiMarcas;
        private System.Windows.Forms.ToolStripMenuItem tsmiVentas;
        private System.Windows.Forms.ToolStripMenuItem tsmiCatalogoCompra;
        private System.Windows.Forms.ToolStripMenuItem tsmiCarrito;
        private System.Windows.Forms.ToolStripMenuItem tsmiComprobantes;
        private System.Windows.Forms.ToolStripMenuItem tsmiPedidos;
        private System.Windows.Forms.ToolStripMenuItem tsmiGestionarPedidos;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistrarPago;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonas;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiProveedores;
        private System.Windows.Forms.ToolStripMenuItem tsmiOperaciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiDevoluciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportesMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportes;
        private System.Windows.Forms.ToolStripMenuItem tsmiSesion;
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
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiCatalogo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComponentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCatalogoCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCarrito = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComprobantes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGestionarPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistrarPago = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDevoluciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSesion = new System.Windows.Forms.ToolStripMenuItem();
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

            // msPrincipal
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiCatalogo,
                this.tsmiVentas,
                this.tsmiPedidos,
                this.tsmiPersonas,
                this.tsmiOperaciones,
                this.tsmiReportesMenu,
                this.tsmiSesion
            });
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1280, 24);
            this.msPrincipal.Text = "msPrincipal";

            // tsmiCatalogo
            this.tsmiCatalogo.Name = "tsmiCatalogo";
            this.tsmiCatalogo.Text = "Catálogo";
            this.tsmiCatalogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiComponentes, this.tsmiCategorias, this.tsmiMarcas
            });

            // tsmiComponentes
            this.tsmiComponentes.Name = "tsmiComponentes";
            this.tsmiComponentes.Text = "Componentes";
            this.tsmiComponentes.Click += new System.EventHandler(this.tsmiComponentes_Click);

            // tsmiCategorias
            this.tsmiCategorias.Name = "tsmiCategorias";
            this.tsmiCategorias.Text = "Categorías";
            this.tsmiCategorias.Click += new System.EventHandler(this.tsmiCategorias_Click);

            // tsmiMarcas
            this.tsmiMarcas.Name = "tsmiMarcas";
            this.tsmiMarcas.Text = "Marcas";
            this.tsmiMarcas.Click += new System.EventHandler(this.tsmiMarcas_Click);

            // tsmiVentas
            this.tsmiVentas.Name = "tsmiVentas";
            this.tsmiVentas.Text = "Ventas";
            this.tsmiVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiCatalogoCompra, this.tsmiCarrito, this.tsmiComprobantes
            });

            // tsmiCatalogoCompra
            this.tsmiCatalogoCompra.Name = "tsmiCatalogoCompra";
            this.tsmiCatalogoCompra.Text = "Catálogo de compra";
            this.tsmiCatalogoCompra.Click += new System.EventHandler(this.tsmiCatalogoCompra_Click);

            // tsmiCarrito
            this.tsmiCarrito.Name = "tsmiCarrito";
            this.tsmiCarrito.Text = "Carrito";
            this.tsmiCarrito.Click += new System.EventHandler(this.tsmiCarrito_Click);

            // tsmiComprobantes
            this.tsmiComprobantes.Name = "tsmiComprobantes";
            this.tsmiComprobantes.Text = "Comprobantes";
            this.tsmiComprobantes.Click += new System.EventHandler(this.tsmiComprobantes_Click);

            // tsmiPedidos
            this.tsmiPedidos.Name = "tsmiPedidos";
            this.tsmiPedidos.Text = "Pedidos";
            this.tsmiPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiGestionarPedidos, this.tsmiRegistrarPago
            });

            // tsmiGestionarPedidos
            this.tsmiGestionarPedidos.Name = "tsmiGestionarPedidos";
            this.tsmiGestionarPedidos.Text = "Gestionar pedidos";
            this.tsmiGestionarPedidos.Click += new System.EventHandler(this.tsmiGestionarPedidos_Click);

            // tsmiRegistrarPago
            this.tsmiRegistrarPago.Name = "tsmiRegistrarPago";
            this.tsmiRegistrarPago.Text = "Registrar pago";
            this.tsmiRegistrarPago.Click += new System.EventHandler(this.tsmiRegistrarPago_Click);

            // tsmiPersonas
            this.tsmiPersonas.Name = "tsmiPersonas";
            this.tsmiPersonas.Text = "Personas";
            this.tsmiPersonas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiClientes, this.tsmiProveedores
            });

            // tsmiClientes
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Text = "Clientes";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);

            // tsmiProveedores
            this.tsmiProveedores.Name = "tsmiProveedores";
            this.tsmiProveedores.Text = "Proveedores";
            this.tsmiProveedores.Click += new System.EventHandler(this.tsmiProveedores_Click);

            // tsmiOperaciones
            this.tsmiOperaciones.Name = "tsmiOperaciones";
            this.tsmiOperaciones.Text = "Operaciones";
            this.tsmiOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiDevoluciones
            });

            // tsmiDevoluciones
            this.tsmiDevoluciones.Name = "tsmiDevoluciones";
            this.tsmiDevoluciones.Text = "Devoluciones";
            this.tsmiDevoluciones.Click += new System.EventHandler(this.tsmiDevoluciones_Click);

            // tsmiReportesMenu
            this.tsmiReportesMenu.Name = "tsmiReportesMenu";
            this.tsmiReportesMenu.Text = "Reportes";
            this.tsmiReportesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiReportes
            });

            // tsmiReportes
            this.tsmiReportes.Name = "tsmiReportes";
            this.tsmiReportes.Text = "Reportes y estadísticas";
            this.tsmiReportes.Click += new System.EventHandler(this.tsmiReportes_Click);

            // tsmiSesion
            this.tsmiSesion.Name = "tsmiSesion";
            this.tsmiSesion.Text = "Sesión";
            this.tsmiSesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiCerrarSesion, this.tsmiSalir
            });

            // tsmiCerrarSesion
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Text = "Cerrar sesión";
            this.tsmiCerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);

            // tsmiSalir
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);

            // tsPrincipal
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsbComponentes, this.tsbCarrito, this.tsbPedidos, this.tsbClientes, this.tsbReportes
            });
            this.tsPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(1280, 25);
            this.tsPrincipal.Text = "tsPrincipal";

            // tsbComponentes
            this.tsbComponentes.Name = "tsbComponentes";
            this.tsbComponentes.Text = "Componentes";
            this.tsbComponentes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbComponentes.Click += new System.EventHandler(this.tsbComponentes_Click);

            // tsbCarrito
            this.tsbCarrito.Name = "tsbCarrito";
            this.tsbCarrito.Text = "Carrito";
            this.tsbCarrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCarrito.Click += new System.EventHandler(this.tsbCarrito_Click);

            // tsbPedidos
            this.tsbPedidos.Name = "tsbPedidos";
            this.tsbPedidos.Text = "Pedidos";
            this.tsbPedidos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPedidos.Click += new System.EventHandler(this.tsbPedidos_Click);

            // tsbClientes
            this.tsbClientes.Name = "tsbClientes";
            this.tsbClientes.Text = "Clientes";
            this.tsbClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClientes.Click += new System.EventHandler(this.tsbClientes_Click);

            // tsbReportes
            this.tsbReportes.Name = "tsbReportes";
            this.tsbReportes.Text = "Reportes";
            this.tsbReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReportes.Click += new System.EventHandler(this.tsbReportes_Click);

            // ssPrincipal
            this.ssPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tslUsuario, this.tslSpring, this.tslFecha, this.tslEstadoConexion
            });
            this.ssPrincipal.Location = new System.Drawing.Point(0, 698);
            this.ssPrincipal.Name = "ssPrincipal";
            this.ssPrincipal.Size = new System.Drawing.Size(1280, 22);
            this.ssPrincipal.Text = "ssPrincipal";

            // tslUsuario
            this.tslUsuario.Name = "tslUsuario";
            this.tslUsuario.Text = "Usuario: —";

            // tslSpring
            this.tslSpring.Name = "tslSpring";
            this.tslSpring.Spring = true;

            // tslFecha
            this.tslFecha.Name = "tslFecha";
            this.tslFecha.Text = System.DateTime.Now.ToShortDateString();

            // tslEstadoConexion
            this.tslEstadoConexion.Name = "tslEstadoConexion";
            this.tslEstadoConexion.Text = "Conectado";

            // frmPrincipal
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.msPrincipal);
            this.Controls.Add(this.tsPrincipal);
            this.Controls.Add(this.ssPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "frmPrincipal";
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
