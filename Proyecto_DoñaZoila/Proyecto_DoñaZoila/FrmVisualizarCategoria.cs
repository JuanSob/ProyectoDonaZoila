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
    public partial class FrmVisualizarCategoria : Form
    {
        //Clases
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsBuscar buscar = new ClsBuscar();

        public FrmVisualizarCategoria()
        {
            InitializeComponent();
            DisplayData();

            foreach (DataGridViewColumn column in dgvCategoría.Columns)
            {
                column.Width = 338;
            }

            foreach (DataGridViewRow row in dgvCategoría.Rows)
            {
                row.Height = 30;
            }
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvCategoría, "execute ProcedimientoCategoría 1");
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo para pasar datos a los atributos
        private void dgvCategoría_DoubleClick(object sender, EventArgs e)
        {
            buscar.CodCategoria = Convert.ToInt32(dgvCategoría.CurrentRow.Cells[0].Value.ToString());
            buscar.NombreCategoria = dgvCategoría.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}
