using System;
using System.Windows.Forms;

namespace ElectroJoule.UI
{
    public partial class frmProveedores : System.Windows.Forms.Form
    {
        public frmProveedores()
        {
            InitializeComponent();
            lblTituloForm.Text = "Gestión de Proveedores";
        }

        private void btnBuscar_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void dgvProveedores_SelectionChanged(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnNuevo_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnGuardar_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnBajaLogica_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
    }
}
