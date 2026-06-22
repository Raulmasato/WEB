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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
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
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.Color.White;
            this.picImagen.Location = new System.Drawing.Point(10, 10);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(180, 120);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblNombre.Location = new System.Drawing.Point(10, 136);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(180, 36);
            this.lblNombre.Text = "Nombre del producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.lblPrecio.Location = new System.Drawing.Point(10, 172);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(180, 24);
            this.lblPrecio.Text = "$ 0.00";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(10, 204);
            this.numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(50, 23);
            this.numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(66, 203);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 26);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ucProductoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
