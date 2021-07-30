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
    public partial class FrmReporteCostos : Form
    {
        public FrmReporteCostos()
        {
            InitializeComponent();
        }

        private void FrmReporteCostos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetCostos.View_ReporteCostos' Puede moverla o quitarla según sea necesario.
            this.View_ReporteCostosTableAdapter.Fill(this.DataSetCostos.View_ReporteCostos);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
