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
    public partial class FrmVisualizarProductos : Form
    {
        //Clases
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsBuscar buscar = new ClsBuscar();

        public FrmVisualizarProductos()
        {
            InitializeComponent();
            DisplayData();

            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                column.Width = 176;
            }

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                row.Height = 30;
            }
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvProductos, "execute procedimientoProductos 1");
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            buscar.CodProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString());
            buscar.CantProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[3].Value.ToString());
            buscar.NombreProducto = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}
