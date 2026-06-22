using System;
using System.Windows.Forms;

namespace ElectroJoule.UI
{
    public partial class frmPedidos : System.Windows.Forms.Form
    {
        public frmPedidos()
        {
            InitializeComponent();
            lblTituloForm.Text = "Gestión de Pedidos";
        }

        private void btnBuscar_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnActualizarEstado_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void dgvPedidos_SelectionChanged(object sender, EventArgs e) { // TODO: conectar con BLL
        }
    }
}
