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
    public partial class FrmModificarProducto : Form
    {
        //Clases
        ClsProductos productos = new ClsProductos();
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsBuscar buscar = new ClsBuscar();
        ClsValidacion validacion = new ClsValidacion();

        //Formularios
        FrmVisualizarCategoria categoria = new FrmVisualizarCategoria();

        public FrmModificarProducto()
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

        //Se capturan los atribustos a utilizar
        public void CapturarDatos()
        {
            productos.CodProducto = Convert.ToInt32(txtCodigoProducto.Text);
            productos.NombreProducto = txtNombreProducto.Text;
            productos.CodigoBarra = txtCodigoBarra.Text;
            productos.CodCategoria = Convert.ToInt32(txtCodigoCategoria.Text);
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtCodigoProducto.Clear();
            txtNombreCategoria.Clear();
            txtNombreProducto.Clear();
            txtCodigoCategoria.Clear();
            txtCodigoBarra.Clear();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            categoria.ShowDialog();

            if (buscar.NombreCategoria is null)
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtNombreCategoria.Text = buscar.NombreCategoria;
                txtCodigoCategoria.Text = buscar.CodCategoria.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "" || txtCodigoBarra.Text == "" || txtCodigoCategoria.Text == "" || txtNombreCategoria.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();

                if (productos.ModificarProducto() == 1)
                {
                    DisplayData();
                    LimpiarCampos();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            txtCodigoProducto.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombreProducto.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1].Value.ToString();
            txtCodigoBarra.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[2].Value.ToString();
            txtCodigoCategoria.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[4].Value.ToString();
            txtNombreCategoria.Text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[5].Value.ToString();
        }

        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }
    }
}
