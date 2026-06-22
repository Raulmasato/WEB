using System;
using System.Windows.Forms;

namespace ElectroJoule.UI
{
    public partial class frmComprobante : System.Windows.Forms.Form
    {
        public frmComprobante()
        {
            InitializeComponent();
            lblTituloForm.Text = "Comprobante de Venta";
        }

        private void btnDescargarPdf_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnImprimir_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnCerrar_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
    }
}
