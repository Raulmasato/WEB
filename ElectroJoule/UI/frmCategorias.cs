using System;
using System.Windows.Forms;

namespace ElectroJoule.UI
{
    public partial class frmCategorias : System.Windows.Forms.Form
    {
        public frmCategorias()
        {
            InitializeComponent();
            lblTituloForm.Text = "Gestión de Categorías";
        }

        private void btnNuevo_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnGuardar_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnEliminar_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void dgvCategorias_SelectionChanged(object sender, EventArgs e) { // TODO: conectar con BLL
        }
    }
}
