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
    public partial class FrmOrdenes : Form
    {
        //Clases
        ClsBuscar buscar = new ClsBuscar();
        ClsOrden orden = new ClsOrden();
        ClsValidacion validacion = new ClsValidacion();

        //Formularios
        FrmVisualizarProveedor vProveedor = new FrmVisualizarProveedor();
        FrmVisualizarMateriales vMateriales = new FrmVisualizarMateriales();

        public FrmOrdenes()
        {
            InitializeComponent();

            foreach (DataGridViewColumn column in dgvCarrito.Columns)
            {
                column.Width = 130;
            }

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                row.Height = 30;
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            vProveedor.ShowDialog();

            if (buscar.NombreProveedor is null)
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (buscar.Estado != "Activo")
                    MessageBox.Show("El proveedor que ha elegido está inactivo","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    txtCodigoProveedor.Text = buscar.CodProveedor.ToString();
                    txtNombreProveedor.Text = buscar.NombreProveedor;
                }
                
            }
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            vMateriales.ShowDialog();

            if (buscar.NombreMaterial is null)
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtCodigoMaterial.Text = buscar.CodMaterial.ToString();
                txtNombreMaterial.Text = buscar.NombreMaterial;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProveedor.Text.Equals("") || txtNombreProveedor.Text.Equals("") || txtCodigoMaterial.Text.Equals("") ||
                txtNombreMaterial.Text.Equals("") || txtIsv.Text.Equals("") || txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = dgvCarrito.Rows.Add();
                dgvCarrito.Rows[index].Cells[0].Value = txtCodigoProveedor.Text;
                dgvCarrito.Rows[index].Cells[1].Value = txtNombreProveedor.Text;
                dgvCarrito.Rows[index].Cells[2].Value = txtCodigoMaterial.Text;
                dgvCarrito.Rows[index].Cells[3].Value = txtNombreMaterial.Text;
                dgvCarrito.Rows[index].Cells[4].Value = Convert.ToInt32(Math.Round(nudCantidad.Value, 0)); ;
                dgvCarrito.Rows[index].Cells[5].Value = txtPrecio.Text;
                
                txtPrecio.Clear();
                txtNombreMaterial.Clear();
                txtCodigoMaterial.Clear();
                nudCantidad.Value = 1;
                btnProveedor.Enabled = false;
                btnEliminar.Enabled = true;
                btnFinalizar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvCarrito.CurrentCell.RowIndex;
            dgvCarrito.Rows.RemoveAt(rowIndex);

            if (dgvCarrito.Rows.Count == 0)
            {
                btnEliminar.Enabled = false;
                btnProveedor.Enabled = true;
                btnFinalizar.Enabled = false;
                txtCodigoProveedor.Clear();
                txtNombreProveedor.Clear();
                txtCodigoMaterial.Clear();
                txtNombreMaterial.Clear();
                txtIsv.Clear();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
           orden.CrearTemporal();

            for (int i = 0; i < dgvCarrito.Rows.Count; i++)
            {

                orden.CodMaterial = Convert.ToInt32(dgvCarrito.Rows[i].Cells[2].Value.ToString());
                orden.Cantidad = Convert.ToInt32(dgvCarrito.Rows[i].Cells[4].Value.ToString());
                orden.Costo = Convert.ToDouble(dgvCarrito.Rows[i].Cells[5].Value.ToString());

                orden.InsertarTemporal();
            }

            orden.CodProveedor = Convert.ToInt32(txtCodigoProveedor.Text);
            orden.Isv = Convert.ToDouble(txtIsv.Text)/100;

            orden.InsertarTablas();

            btnEliminar.Enabled = false;
            btnProveedor.Enabled = true;
            btnFinalizar.Enabled = false;
            txtCodigoProveedor.Clear();
            txtNombreProveedor.Clear();
            txtCodigoMaterial.Clear();
            txtNombreMaterial.Clear();
            txtIsv.Clear();
            dgvCarrito.Rows.Clear();
        }

        private void txtIsv_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.NumerosDecimales(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.NumerosDecimales(e);
        }
    }
}
