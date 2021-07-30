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
    public partial class FrmRealizacionProducto : Form
    {
        //Clases
        ClsProductos producto = new ClsProductos();
        ClsBuscar buscar = new ClsBuscar();

        //Formularios
        FrmVisualizarProductos verProducto = new FrmVisualizarProductos();
        FrmVisualizarMateriales verMaterial = new FrmVisualizarMateriales();

        public FrmRealizacionProducto()
        {
            InitializeComponent();

            foreach (DataGridViewColumn column in dgvRealizacionProductos.Columns)
            {
                column.Width = 261;
            }

            foreach (DataGridViewRow row in dgvRealizacionProductos.Rows)
            {
                row.Height = 30;
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Programacion botón buscar producto
        private void btnProducto_Click(object sender, EventArgs e)
        {
            verProducto.ShowDialog();

            if (buscar.NombreProducto is null)
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtCodigoProducto.Text = buscar.CodProducto.ToString();
                txtNombreProducto.Text = buscar.NombreProducto;
            }
        }

        //Programacion botón buscar material
        private void btnMaterial_Click(object sender, EventArgs e)
        {
            verMaterial.ShowDialog();

            if (buscar.NombreMaterial is null)
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (buscar.CantMaterial != 0)
                {
                    txtCodigoMaterial.Text = buscar.CodMaterial.ToString();
                    txtNombreMaterial.Text = buscar.NombreMaterial;
                    nudCantMaterial.Maximum = buscar.CantMaterial;
                }
                else
                {
                    MessageBox.Show("No se encuentra material en existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Programacion botón agregar al carrito
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text.Equals("") || txtNombreProducto.Text.Equals("") || txtCodigoMaterial.Text.Equals("") ||
                txtNombreMaterial.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = dgvRealizacionProductos.Rows.Add();
                dgvRealizacionProductos.Rows[index].Cells[0].Value = txtCodigoMaterial.Text;
                dgvRealizacionProductos.Rows[index].Cells[1].Value = txtNombreMaterial.Text;
                dgvRealizacionProductos.Rows[index].Cells[2].Value = Convert.ToInt32(Math.Round(nudCantMaterial.Value, 0));

                txtNombreMaterial.Clear();
                txtCodigoMaterial.Clear();
                nudCantMaterial.Value = 1;
                btnProducto.Enabled = false;
                btnEliminar.Enabled = true;
                btnFinalizar.Enabled = true;
            }
        }

        //Programacion eliminar una fila del data grid
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvRealizacionProductos.CurrentCell.RowIndex;
            dgvRealizacionProductos.Rows.RemoveAt(rowIndex);

            if (dgvRealizacionProductos.Rows.Count == 0)
            {
                btnEliminar.Enabled = false;
                btnProducto.Enabled = true;
                btnFinalizar.Enabled = false;
                txtCodigoProducto.Clear();
                txtNombreProducto.Clear();
                txtCodigoMaterial.Clear();
                txtNombreMaterial.Clear();
            }
        }

        //Programacion para finalizar y registrar todos los materiales utilizados al igual que productos realizados
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            producto.CodProducto = Convert.ToInt32(txtCodigoProducto.Text);
            producto.ProductoNuevo = Convert.ToInt32(Math.Round(nudCantProducto.Value, 0));

            for (int i = 0; i < dgvRealizacionProductos.Rows.Count; i++)
            {

                producto.CodMaterial = Convert.ToInt32(dgvRealizacionProductos.Rows[i].Cells[0].Value.ToString());
                producto.MaterialUtilizado = Convert.ToInt32(dgvRealizacionProductos.Rows[i].Cells[2].Value.ToString());

                producto.RealizacionProducto();
            }

            producto.NuevoProducto();

            btnEliminar.Enabled = false;
            btnProducto.Enabled = true;
            btnFinalizar.Enabled = false;
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtCodigoMaterial.Clear();
            txtNombreMaterial.Clear();
            dgvRealizacionProductos.Rows.Clear();
            nudCantProducto.Value = 1;
            nudCantMaterial.Value = 1;
        }
    }
}
