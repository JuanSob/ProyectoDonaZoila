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
    public partial class FrmVisualizarViajes : Form
    {
        //Clases
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsBuscar buscar = new ClsBuscar();

        public FrmVisualizarViajes()
        {
            InitializeComponent();
            DisplayData();
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvViajes, "execute Viaje 1");
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvViajes_DoubleClick(object sender, EventArgs e)
        {
            buscar.CodViaje = Convert.ToInt32(dgvViajes.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }
    }
}
