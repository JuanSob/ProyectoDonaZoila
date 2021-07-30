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
    public partial class FrmReporteEntregas : Form
    {
        public FrmReporteEntregas()
        {
            InitializeComponent();
        }

        private void FrmReporteEntregas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetEntregas.View_ReporteEntregas' Puede moverla o quitarla según sea necesario.
            this.View_ReporteEntregasTableAdapter.Fill(this.DataSetEntregas.View_ReporteEntregas);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
