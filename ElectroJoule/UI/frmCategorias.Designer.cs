namespace ElectroJoule.UI
{
    partial class frmCategorias
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblNombreCat;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcionCat;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblNombreCat = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcionCat = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();

            // dgvCategorias
            this.dgvCategorias.Location = new System.Drawing.Point(8, 48);
            this.dgvCategorias.Size = new System.Drawing.Size(340, 380);
            this.dgvCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.SelectionChanged += new System.EventHandler(this.dgvCategorias_SelectionChanged);
            var colId = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colId", HeaderText = "Id", DataPropertyName = "Id" };
            var colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colNombre", HeaderText = "Nombre", DataPropertyName = "Nombre" };
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colNombre });

            // grpDatos
            this.grpDatos.Location = new System.Drawing.Point(360, 48);
            this.grpDatos.Size = new System.Drawing.Size(310, 380);
            this.grpDatos.Text = "Datos de la categoría";
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Controls.Add(this.lblNombreCat);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblDescripcionCat);
            this.grpDatos.Controls.Add(this.txtDescripcion);

            // lblNombreCat
            this.lblNombreCat.AutoSize = true;
            this.lblNombreCat.Location = new System.Drawing.Point(8, 24);
            this.lblNombreCat.Name = "lblNombreCat";
            this.lblNombreCat.Text = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(8, 42);
            this.txtNombre.Size = new System.Drawing.Size(286, 23);
            this.txtNombre.Name = "txtNombre";

            // lblDescripcionCat
            this.lblDescripcionCat.AutoSize = true;
            this.lblDescripcionCat.Location = new System.Drawing.Point(8, 74);
            this.lblDescripcionCat.Name = "lblDescripcionCat";
            this.lblDescripcionCat.Text = "Descripción:";

            // txtDescripcion
            this.txtDescripcion.Location = new System.Drawing.Point(8, 92);
            this.txtDescripcion.Size = new System.Drawing.Size(286, 120);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";

            // Botonera
            this.btnNuevo.Location = new System.Drawing.Point(270, 438);
            this.btnNuevo.Size = new System.Drawing.Size(80, 28);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);

            this.btnGuardar.Location = new System.Drawing.Point(358, 438);
            this.btnGuardar.Size = new System.Drawing.Size(80, 28);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.btnEliminar.Location = new System.Drawing.Point(446, 438);
            this.btnEliminar.Size = new System.Drawing.Size(80, 28);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // frmCategorias
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Name = "frmCategorias";
            this.Text = "Gestión de Categorías";

            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
