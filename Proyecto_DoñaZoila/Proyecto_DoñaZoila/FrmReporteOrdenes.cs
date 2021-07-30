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
    public partial class FrmReporteOrdenes : Form
    {
        public FrmReporteOrdenes()
        {
            InitializeComponent();
        }

        private void FrmReporteOrdenes_Load(object sender, EventArgs e)
        {
            
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            

            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.View_ReporteOrdenes' Puede moverla o quitarla según sea necesario.
            this.View_ReporteOrdenesTableAdapter.Fill(this.DataSetReportes.View_ReporteOrdenes);

            this.reportViewer1.RefreshReport();

            
        }
    }
}
