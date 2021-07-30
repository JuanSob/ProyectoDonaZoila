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
    public partial class FrmEmpleadoVehiculos : Form
    {
        //Clases
        ClsBuscar buscar = new ClsBuscar();
        ClsVehiculo vehiculo = new ClsVehiculo();

        //Forms
        FrmVisualizarEmpleado empleado = new FrmVisualizarEmpleado();
        FrmVisualizarVehiculo verVehiculo = new FrmVisualizarVehiculo();

        public FrmEmpleadoVehiculos()
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
            vehiculo.CodVehiculo = Convert.ToInt32(txtCodigoVehiculo.Text);
            vehiculo.Empleado = Convert.ToInt32(txtCodigoEmpleado.Text);
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtCodigoVehiculo.Clear();
            txtCodigoEmpleado.Clear();
            txtNombreEmpleado.Clear();
            txtPlaca.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
                    txtNombreEmpleado.Text = buscar.NombreEmpleado;
                    txtCodigoEmpleado.Text = buscar.CodigoEmpleado.ToString();
                }
            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            verVehiculo.ShowDialog();

            if (buscar.PlacaVehiculo is null)
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (buscar.EstadoVehiculo == "Activo")
                {
                    txtPlaca.Text = buscar.PlacaVehiculo;
                    txtCodigoVehiculo.Text = buscar.CodVehiculo.ToString();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CapturarDatos();

            if(vehiculo.CambioConductor()==1)
            {
                LimpiarCampos();
            }
        }
    }
}
