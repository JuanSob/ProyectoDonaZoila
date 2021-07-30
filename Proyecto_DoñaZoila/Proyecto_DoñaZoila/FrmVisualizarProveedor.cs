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
    public partial class FrmVisualizarProveedor : Form
    {
        //Clases
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsBuscar buscar = new ClsBuscar();

        public FrmVisualizarProveedor()
        {
            InitializeComponent();
        }

        private void FrmVisualizarProveedor_Load(object sender, EventArgs e)
        {
            DisplayData();

            foreach (DataGridViewColumn column in dgvProveedor.Columns)
            {
                column.Width = 140;
            }

            foreach (DataGridViewRow row in dgvProveedor.Rows)
            {
                row.Height = 30;
            }
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvProveedor, "execute  [dbo].[cargarProveedores]");
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProveedor_DoubleClick(object sender, EventArgs e)
        {
            buscar.CodProveedor = Convert.ToInt32(dgvProveedor.CurrentRow.Cells[0].Value.ToString());
            buscar.NombreProveedor = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
            buscar.Estado = dgvProveedor.CurrentRow.Cells[6].Value.ToString();
            this.Close();
        }
    }
}
