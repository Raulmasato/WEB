using System;
using System.Windows.Forms;

namespace ElectroJoule.UI
{
    public partial class frmReportes : frmBaseHijo
    {
        public frmReportes()
        {
            InitializeComponent();
            lblTituloForm.Text = "Reportes y Estadísticas";
        }

        private void btnGenerarVentas_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnGenerarInventario_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnExportarPdfVentas_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnExportarExcelVentas_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnExportarPdfInventario_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
        private void btnExportarExcelInventario_Click(object sender, EventArgs e) { // TODO: conectar con BLL
        }
    }
}
