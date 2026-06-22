namespace ElectroJoule.UI
{
    partial class frmMarcas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblNombreMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox txtOrigen;
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblNombreMarca = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.grpDatos.SuspendLayout();
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
            this.lblTituloForm.Text = "Gestión de Marcas";
            this.lblTituloForm.Name = "lblTituloForm";

            // dgvMarcas
            this.dgvMarcas.Location = new System.Drawing.Point(8, 48);
            this.dgvMarcas.Size = new System.Drawing.Size(340, 360);
            this.dgvMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.SelectionChanged += new System.EventHandler(this.dgvMarcas_SelectionChanged);
            System.Windows.Forms.DataGridViewTextBoxColumn colId = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colId", HeaderText = "Id", DataPropertyName = "Id" };
            System.Windows.Forms.DataGridViewTextBoxColumn colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colNombre", HeaderText = "Nombre", DataPropertyName = "Nombre" };
            System.Windows.Forms.DataGridViewTextBoxColumn colOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "colOrigen", HeaderText = "Origen", DataPropertyName = "Origen" };
            this.dgvMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colNombre, colOrigen });

            // grpDatos
            this.grpDatos.Location = new System.Drawing.Point(360, 48);
            this.grpDatos.Size = new System.Drawing.Size(310, 360);
            this.grpDatos.Text = "Datos de la marca";
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Controls.Add(this.lblNombreMarca);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblOrigen);
            this.grpDatos.Controls.Add(this.txtOrigen);

            // lblNombreMarca
            this.lblNombreMarca.AutoSize = true;
            this.lblNombreMarca.Location = new System.Drawing.Point(8, 24);
            this.lblNombreMarca.Name = "lblNombreMarca";
            this.lblNombreMarca.Text = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(8, 42);
            this.txtNombre.Size = new System.Drawing.Size(286, 23);
            this.txtNombre.Name = "txtNombre";

            // lblOrigen
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(8, 74);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Text = "Origen:";

            // txtOrigen
            this.txtOrigen.Location = new System.Drawing.Point(8, 92);
            this.txtOrigen.Size = new System.Drawing.Size(286, 23);
            this.txtOrigen.Name = "txtOrigen";

            // Botonera
            this.btnNuevo.Location = new System.Drawing.Point(258, 418);
            this.btnNuevo.Size = new System.Drawing.Size(80, 28);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);

            this.btnGuardar.Location = new System.Drawing.Point(346, 418);
            this.btnGuardar.Size = new System.Drawing.Size(80, 28);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.btnEliminar.Location = new System.Drawing.Point(434, 418);
            this.btnEliminar.Size = new System.Drawing.Size(80, 28);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // frmMarcas
            this.ClientSize = new System.Drawing.Size(700, 460);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Name = "frmMarcas";
            this.Text = "Gestión de Marcas";

            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
