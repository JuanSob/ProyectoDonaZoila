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
    public partial class FrmModificarVehiculo : Form
    {
        //Clases
        ClsVehiculo vehiculo = new ClsVehiculo();
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsValidacion validacion = new ClsValidacion();

        //Form
        FrmVisualizarEmpleado empleado = new FrmVisualizarEmpleado();

        public FrmModificarVehiculo()
        {
            InitializeComponent();
            DisplayData();
            LimpiarCampos();

            foreach (DataGridViewColumn column in dgvVehiculo.Columns)
            {
                column.Width = 140;
            }

            foreach (DataGridViewRow row in dgvVehiculo.Rows)
            {
                row.Height = 30;
            }
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvVehiculo, "execute CargarVehiculo 1");
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Se capturan los atribustos a utilizar
        public void CapturarDatos()
        {
            vehiculo.CodVehiculo = Convert.ToInt32(txtCodigo.Text);
            vehiculo.PlacaCarro = txtPlaca.Text;
            vehiculo.Marca = txtMarca.Text;
            vehiculo.Descripcion = txtDescripcion.Text;
            vehiculo.Estado = cbEstado.GetItemText(this.cbEstado.SelectedItem);
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtPlaca.Clear();
            txtMarca.Clear();
            txtDescripcion.Clear();
            cbEstado.SelectedItem = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvVehiculo_SelectionChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = dgvVehiculo.Rows[dgvVehiculo.CurrentRow.Index].Cells[0].Value.ToString();
            txtMarca.Text = dgvVehiculo.Rows[dgvVehiculo.CurrentRow.Index].Cells[1].Value.ToString();
            txtDescripcion.Text = dgvVehiculo.Rows[dgvVehiculo.CurrentRow.Index].Cells[2].Value.ToString();
            txtPlaca.Text = dgvVehiculo.Rows[dgvVehiculo.CurrentRow.Index].Cells[3].Value.ToString();
            cbEstado.SelectedItem = dgvVehiculo.Rows[dgvVehiculo.CurrentRow.Index].Cells[4].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "" || txtPlaca.Text == "" || cbEstado.Text == "" || txtCodigo.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();
                if (vehiculo.ModificarVehiculo() == 1)
                {
                    DisplayData();
                    LimpiarCampos();
                }
            }
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }
    }
}
