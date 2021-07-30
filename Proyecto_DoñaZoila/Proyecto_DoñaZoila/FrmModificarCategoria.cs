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
    public partial class FrmModificarCategoria : Form
    {
        //Clases
        ClsCategoríaProducto categoria = new ClsCategoríaProducto();
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();

        public FrmModificarCategoria()
        {
            InitializeComponent();
            DisplayData();

            foreach (DataGridViewColumn column in dgvCategoría.Columns)
            {
                column.Width = 214;
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

        //Se capturan los atribustos a utilizar
        public void CapturarDatos()
        {
            categoria.NombreCategoria = txtDescripcion.Text;
            categoria.CodCategoria = Convert.ToInt32(txtCodigoCategoria.Text);
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtDescripcion.Clear();
            txtCodigoCategoria.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCategoria.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();
                if (categoria.ModificarCategoria() == 1)
                {
                    DisplayData();
                    LimpiarCampos();
                }
            }
        }

        private void dgvCategoría_SelectionChanged(object sender, EventArgs e)
        {
            txtCodigoCategoria.Text = dgvCategoría.Rows[dgvCategoría.CurrentRow.Index].Cells[0].Value.ToString();
            txtDescripcion.Text = dgvCategoría.Rows[dgvCategoría.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
