namespace ElectroJoule.UI
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.CheckBox chkRecordarme;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblError;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.chkRecordarme = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();

            // picLogo
            this.picLogo.Location = new System.Drawing.Point(152, 16);
            this.picLogo.Size = new System.Drawing.Size(96, 96);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabStop = false;
            this.picLogo.Name = "picLogo";

            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(70, 124);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Text = "Usuario:";

            // txtUsuario
            this.txtUsuario.Location = new System.Drawing.Point(70, 142);
            this.txtUsuario.Size = new System.Drawing.Size(260, 23);
            this.txtUsuario.Name = "txtUsuario";

            // lblContrasena
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(70, 178);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Text = "Contraseña:";

            // txtContrasena
            this.txtContrasena.Location = new System.Drawing.Point(70, 196);
            this.txtContrasena.Size = new System.Drawing.Size(260, 23);
            this.txtContrasena.UseSystemPasswordChar = true;
            this.txtContrasena.Name = "txtContrasena";

            // chkRecordarme
            this.chkRecordarme.AutoSize = true;
            this.chkRecordarme.Location = new System.Drawing.Point(70, 232);
            this.chkRecordarme.Name = "chkRecordarme";
            this.chkRecordarme.Text = "Recordarme";
            this.chkRecordarme.CheckedChanged += new System.EventHandler(this.chkRecordarme_CheckedChanged);

            // btnIngresar
            this.btnIngresar.Location = new System.Drawing.Point(70, 258);
            this.btnIngresar.Size = new System.Drawing.Size(260, 32);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);

            // lblError
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(70, 300);
            this.lblError.Name = "lblError";
            this.lblError.Text = "Usuario o contraseña incorrectos.";
            this.lblError.Visible = false;

            // frmLogin
            this.AcceptButton = this.btnIngresar;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(400, 340);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.chkRecordarme);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblError);
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectroJoule — Iniciar sesión";

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
