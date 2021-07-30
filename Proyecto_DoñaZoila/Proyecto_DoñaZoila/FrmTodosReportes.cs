using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DoñaZoila
{
    public partial class FrmTodosReportes : Form
    {
        public FrmTodosReportes()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporteOrdenes_Click(object sender, EventArgs e)
        {
            FrmReporteOrdenes mostrar = new FrmReporteOrdenes();

            mostrar.ShowDialog();
        }

        private void btnReporteEntregas_Click(object sender, EventArgs e)
        {
            FrmReporteEntregas mostrar = new FrmReporteEntregas();

            mostrar.ShowDialog();
        }

        private void btnReporteCostos_Click(object sender, EventArgs e)
        {
            FrmReporteCostos mostrar = new FrmReporteCostos();

            mostrar.ShowDialog();
        }

        private void btnReporteCostos_Click_1(object sender, EventArgs e)
        {
            FrmReporteCostos mostrar = new FrmReporteCostos();

            mostrar.ShowDialog();
        }

        private void btnReporteEntregas_Click_1(object sender, EventArgs e)
        {
            FrmReporteEntregas mostrar = new FrmReporteEntregas();

            mostrar.ShowDialog();
        }

        private void btnReporteOrdenes_Click_1(object sender, EventArgs e)
        {
            FrmReporteOrdenes mostrar = new FrmReporteOrdenes();

            mostrar.ShowDialog();
        }

        private void btnRetornar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
