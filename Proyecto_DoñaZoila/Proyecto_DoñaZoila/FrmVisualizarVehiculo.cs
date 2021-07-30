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
    public partial class FrmVisualizarVehiculo : Form
    {
        //Clases
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsBuscar buscar = new ClsBuscar();

        public FrmVisualizarVehiculo()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvHistorial, "execute CargarVehiculo 1");
        }

        private void FrmVisualizarVehiculo_Load(object sender, EventArgs e)
        {
            DisplayData();

            foreach (DataGridViewColumn column in dgvHistorial.Columns)
            {
                column.Width = 140;
            }

            foreach (DataGridViewRow row in dgvHistorial.Rows)
            {
                row.Height = 30;
            }
        }

        private void dgvVehiculo_DoubleClick(object sender, EventArgs e)
        {
            buscar.CodVehiculo = Convert.ToInt32(dgvHistorial.CurrentRow.Cells[0].Value.ToString());
            buscar.PlacaVehiculo = dgvHistorial.CurrentRow.Cells[3].Value.ToString();
            buscar.EstadoVehiculo = dgvHistorial.CurrentRow.Cells[4].Value.ToString();
            this.Close();
        }
    }
}
