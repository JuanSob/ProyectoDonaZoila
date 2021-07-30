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
    public partial class FrmAgregarVehiculo : Form
    {
        //Clases
        ClsBuscar buscar = new ClsBuscar();
        ClsVehiculo vehiculo = new ClsVehiculo();
        ClsValidacion validacion = new ClsValidacion();

        //Forms
        FrmVisualizarEmpleado empleado = new FrmVisualizarEmpleado();

        public FrmAgregarVehiculo()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Se capturan los atribustos a utilizar
        public void CapturarDatos()
        {
            vehiculo.PlacaCarro = txtPlaca.Text;
            vehiculo.Marca = txtMarca.Text;
            vehiculo.Descripcion = txtDescripcion.Text;
            vehiculo.Estado = cbEstado.GetItemText(this.cbEstado.SelectedItem);
            vehiculo.Empleado = Convert.ToInt32(txtEmpleado.Text);
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtPlaca.Clear();
            txtMarca.Clear();
            txtDescripcion.Clear();
            txtEmpleado.Clear();
            cbEstado.SelectedItem = null;
            txtNombre.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "" || txtPlaca.Text == "" || cbEstado.Text == "" || txtNombre.Text == ""
             || txtEmpleado.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();
                if (vehiculo.InsertarVehiculo() == 1)
                {
                    LimpiarCampos();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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
                if(buscar.EsatadoEmpleado == "Activo")
                {
                    txtNombre.Text = buscar.NombreEmpleado;
                    txtEmpleado.Text = buscar.CodigoEmpleado.ToString();
                }
            }
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }
    }
}
