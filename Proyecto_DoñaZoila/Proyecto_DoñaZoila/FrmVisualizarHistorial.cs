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
    public partial class FrmVisualizarHistorial : Form
    {
        //Clases
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();

        public FrmVisualizarHistorial()
        {
            InitializeComponent();
            DisplayData();
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvHistorial, "execute [dbo].[CargarVehiculo] 2");
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
