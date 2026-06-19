using System;
using System.Windows.Forms;

namespace ElectroJoule.UI
{
    public partial class frmCarrito : frmBaseHijo
    {
        public frmCarrito()
        {
            InitializeComponent();
            lblTituloForm.Text = "Carrito de Compras";
        }

        private void btnSeguirComprando_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnVaciar_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnConfirmarCompra_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void dgvCarrito_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) { // TODO: conectar con BLL
        }
    }
}
