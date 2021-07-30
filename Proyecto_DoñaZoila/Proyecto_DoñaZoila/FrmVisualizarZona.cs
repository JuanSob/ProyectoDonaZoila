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
    public partial class FrmVisualizarZona : Form
    {
        //Clases
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsBuscar buscar = new ClsBuscar();

        public FrmVisualizarZona()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVisualizarZona_Load(object sender, EventArgs e)
        {
            DisplayData();
            foreach (DataGridViewColumn column in dgvZona.Columns)
            {
                column.Width = 346;
            }

            foreach (DataGridViewRow row in dgvZona.Rows)
            {
                row.Height = 30;
            }
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvZona, "execute zona 1");
        }

        private void dgvZona_DoubleClick(object sender, EventArgs e)
        {
            buscar.CodZona = Convert.ToInt32(dgvZona.CurrentRow.Cells[0].Value.ToString());
            buscar.NombreZona = dgvZona.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}
