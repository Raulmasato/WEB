using System;
using System.Windows.Forms;

namespace ElectroJoule.UI
{
    public partial class frmMarcas : System.Windows.Forms.Form
    {
        public frmMarcas()
        {
            InitializeComponent();
            lblTituloForm.Text = "Gestión de Marcas";
        }

        private void btnNuevo_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnGuardar_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnEliminar_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void dgvMarcas_SelectionChanged(object sender, EventArgs e) { // TODO: conectar con BLL
        }
    }
}
