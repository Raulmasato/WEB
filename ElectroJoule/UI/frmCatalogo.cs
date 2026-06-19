using System;
using System.Windows.Forms;

namespace ElectroJoule.UI
{
    public partial class frmCatalogo : frmBaseHijo
    {
        public frmCatalogo()
        {
            InitializeComponent();
            lblTituloForm.Text = "Catálogo de Componentes";
        }

        private void btnBuscar_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnVerCarrito_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
    }
}
