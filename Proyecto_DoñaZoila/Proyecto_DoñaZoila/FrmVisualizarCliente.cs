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
    public partial class FrmVisualizarCliente : Form
    {
        //Clases
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsBuscar buscar = new ClsBuscar();

        public FrmVisualizarCliente()
        {
            InitializeComponent();
            DisplayData();

            foreach (DataGridViewColumn column in dgvCliente.Columns)
            {
                column.Width = 140;
            }

            foreach (DataGridViewRow row in dgvCliente.Rows)
            {
                row.Height = 30;
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvCliente, "execute [dbo].[Cliente] 2");
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            buscar.CodCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value.ToString());
            buscar.NombreCliente = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}
