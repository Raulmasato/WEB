using System;
using System.Windows.Forms;

namespace ElectroJoule.UI
{
    public partial class frmDevoluciones : frmBaseHijo
    {
        public frmDevoluciones()
        {
            InitializeComponent();
            lblTituloForm.Text = "Devoluciones";
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnProcesarDevolucion_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnCancelar_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
    }
}
