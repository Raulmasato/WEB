namespace ElectroJoule.UI
{
    partial class ucProductoCard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnAgregar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();

            // picImagen
            this.picImagen.Location = new System.Drawing.Point(8, 8);
            this.picImagen.Size = new System.Drawing.Size(184, 120);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabStop = false;
            this.picImagen.Name = "picImagen";
            this.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblNombre
            this.lblNombre.Location = new System.Drawing.Point(8, 136);
            this.lblNombre.Size = new System.Drawing.Size(184, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Text = "Nombre del producto";

            // lblPrecio
            this.lblPrecio.Location = new System.Drawing.Point(8, 170);
            this.lblPrecio.Size = new System.Drawing.Size(184, 20);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Text = "$ 0.00";
            this.lblPrecio.ForeColor = Estilos.Primario;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);

            // numCantidad
            this.numCantidad.Location = new System.Drawing.Point(8, 196);
            this.numCantidad.Size = new System.Drawing.Size(80, 24);
            this.numCantidad.Minimum = 1;
            this.numCantidad.Maximum = 999;
            this.numCantidad.Value = 1;
            this.numCantidad.Name = "numCantidad";

            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(96, 194);
            this.btnAgregar.Size = new System.Drawing.Size(96, 26);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Text = "Agregar al carrito";
            this.btnAgregar.BackColor = Estilos.Primario;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // ucProductoCard
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.btnAgregar);
            this.Name = "ucProductoCard";
            this.Size = new System.Drawing.Size(200, 240);

            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
