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
    public partial class FrmEntrega : Form
    {
        //Clses
        ClsBuscar buscar = new ClsBuscar();
        ClsEntrega entrega = new ClsEntrega();
        ClsValidacion validacion = new ClsValidacion();

        //Formularios
        FrmVisualizarProductos verProducto = new FrmVisualizarProductos();
        FrmVisualizarCliente cliente = new FrmVisualizarCliente();
        FrmVisualizarEmpleado empleado = new FrmVisualizarEmpleado();
        FrmVisualizarViajes viaje = new FrmVisualizarViajes();
        

        public FrmEntrega()
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

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            verProducto.ShowDialog();

            if (buscar.NombreProducto is null)
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (buscar.CantProducto != 0)
                {
                    txtCodigoProducto.Text = buscar.CodProducto.ToString();
                    txtNombreProducto.Text = buscar.NombreProducto;
                    nudCantidad.Maximum = buscar.CantProducto;
                }
                else
                {
                    MessageBox.Show("No se encuentra producto en existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnCliente_Click(object sender, EventArgs e)
        {
            cliente.ShowDialog();

            if (buscar.NombreCliente is null)
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtCodigoCliente.Text = buscar.CodCliente.ToString();
                txtNombreCliente.Text = buscar.NombreCliente;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text.Equals("") || txtNombreCliente.Text.Equals("") || txtCodigoProducto.Text.Equals("") ||
                txtNombreProducto.Text.Equals("") || txtIsv.Text.Equals("") || txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = dgvCarrito.Rows.Add();
                dgvCarrito.Rows[index].Cells[0].Value = txtCodigoCliente.Text;
                dgvCarrito.Rows[index].Cells[1].Value = txtNombreCliente.Text;
                dgvCarrito.Rows[index].Cells[2].Value = txtCodigoProducto.Text;
                dgvCarrito.Rows[index].Cells[3].Value = txtNombreProducto.Text;
                dgvCarrito.Rows[index].Cells[4].Value = Convert.ToInt32(Math.Round(nudCantidad.Value, 0)); ;
                dgvCarrito.Rows[index].Cells[5].Value = txtPrecio.Text;

                txtPrecio.Clear();
                txtCodigoProducto.Clear();
                txtNombreProducto.Clear();
                nudCantidad.Value = 1;
                btnCliente.Enabled = false;
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
                btnCliente.Enabled = true;
                btnFinalizar.Enabled = false;
                txtCodigoCliente.Clear();
                txtNombreCliente.Clear();
                txtNombreProducto.Clear();
                txtCodigoProducto.Clear();
                txtEmpleado.Clear();
                txtIsv.Clear();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if(txtViaje.Text.Equals(""))
            {
                MessageBox.Show("Debe de especificar en que viaje se hizo la venta", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEmpleado.Text.Equals(""))
            {
                MessageBox.Show("Debe de especificar en que empleado hizo la venta", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtIsv.Text.Equals(""))
            {
                MessageBox.Show("Debe escribir el porcentaje de iompuesto sobre la venta", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                entrega.CrearTemporal();

                for (int i = 0; i < dgvCarrito.Rows.Count; i++)
                {

                    entrega.CodProducto = Convert.ToInt32(dgvCarrito.Rows[i].Cells[2].Value.ToString());
                    entrega.Cantidad = Convert.ToInt32(dgvCarrito.Rows[i].Cells[4].Value.ToString());
                    entrega.Precio = Convert.ToDouble(dgvCarrito.Rows[i].Cells[5].Value.ToString());

                    entrega.InsertarTemporal();
                }

                entrega.CodViaje = Convert.ToInt32(txtViaje.Text);
                entrega.CodEmpleado = Convert.ToInt32(txtEmpleado.Text);
                entrega.CodCliente = Convert.ToInt32(txtCodigoCliente.Text);
                entrega.Isv = Convert.ToDouble(txtIsv.Text) / 100;

                entrega.InsertarTablas();

                btnEliminar.Enabled = false;
                btnCliente.Enabled = true;
                btnFinalizar.Enabled = false;
                txtCodigoCliente.Clear();
                txtNombreCliente.Clear();
                txtNombreProducto.Clear();
                txtCodigoProducto.Clear();
                txtIsv.Clear();
                txtViaje.Clear();
                txtPrecio.Clear();
                txtEmpleado.Clear();
                dgvCarrito.Rows.Clear();
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            empleado.ShowDialog();

            if (buscar.NombreEmpleado is null)
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (buscar.EsatadoEmpleado == "Activo")
                {
                    txtEmpleado.Text = buscar.CodigoEmpleado.ToString();
                }
            }
        }

        private void btnViaje_Click(object sender, EventArgs e)
        {
            viaje.ShowDialog();

            if (buscar.CodViaje == 0)
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtViaje.Text = buscar.CodViaje.ToString();
            }
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
