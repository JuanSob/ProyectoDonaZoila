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
    public partial class FrmVisualizarEmpleado : Form
    {
        //Clases
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsBuscar buscar = new ClsBuscar();

        public FrmVisualizarEmpleado()
        {
            InitializeComponent();
        }

        //Programación ejecutada cuando el form carga
        private void FrmVisualizar_Load(object sender, EventArgs e)
        {
            DisplayData();

            foreach (DataGridViewColumn column in dgvEmpleados.Columns)
            {
                column.Width = 100;
            }

            foreach (DataGridViewRow row in dgvEmpleados.Rows)
            {
                row.Height = 30;
            }
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvEmpleados, "execute [dbo].[CargarEmpleado]1");
        }

        //Programación boton para retornar
        private void btnRetornar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo para pasar datos a los atributos
        private void dgvEmpleados_DoubleClick(object sender, EventArgs e)
        {
            buscar.CodigoEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value.ToString());
            string nombre = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            nombre = nombre + " " + dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            buscar.NombreEmpleado = nombre;
            buscar.EsatadoEmpleado = dgvEmpleados.CurrentRow.Cells[11].Value.ToString();
            this.Close();
        }
    }
}
