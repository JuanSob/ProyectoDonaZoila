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
    public partial class FrmVisualizarMateriales : Form
    {
        //Clases
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsBuscar buscar = new ClsBuscar();

        public FrmVisualizarMateriales()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMateriales_Load(object sender, EventArgs e)
        {
            DisplayData(1);

            foreach (DataGridViewColumn column in dgvMateriales.Columns)
            {
                column.Width = 225;
            }

            foreach (DataGridViewRow row in dgvMateriales.Rows)
            {
                row.Height = 30;
            }
        }

        //Metodo para traer datos al data grid view
        private void DisplayData(int num)
        {
            if (num == 1)
            {
                cargar.Abrir();
                cargar.cargaDatos(dgvMateriales, "execute cargarMaterial 1");
            }
            else
            if (num == 2)
            {
                cargar.Abrir();
                cargar.cargaDatos(dgvMateriales, "execute cargarMaterial 2");
            }
            else
            {
                cargar.Abrir();
                cargar.cargaDatos(dgvMateriales, "execute cargarMaterial 3");
            }
        }

        private void dgvMateriales_DoubleClick(object sender, EventArgs e)
        {
            buscar.CodMaterial = Convert.ToInt32(dgvMateriales.CurrentRow.Cells[0].Value.ToString());
            buscar.CantMaterial = Convert.ToInt32(dgvMateriales.CurrentRow.Cells[2].Value.ToString());
            buscar.NombreMaterial = dgvMateriales.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void cbDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDescripcion.SelectedItem.Equals("Todos"))
                    DisplayData(1);
            else
                if (cbDescripcion.SelectedItem.Equals("Insumo"))
                    DisplayData(2);
            else
                if (cbDescripcion.SelectedItem.Equals("Materia Prima"))
                    DisplayData(3);
        }
    }
}
