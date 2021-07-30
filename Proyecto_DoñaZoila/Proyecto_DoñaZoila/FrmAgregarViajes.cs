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
    public partial class FrmAgregarViajes : Form
    {
        //Clases
        ClsBuscar buscar = new ClsBuscar();
        ClsViajes viaje = new ClsViajes();

        //Form
        FrmVisualizarVehiculo verVehiculo = new FrmVisualizarVehiculo();

        public FrmAgregarViajes()
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
            viaje.MontoCargado = Convert.ToDouble(txtMonto.Text);
            viaje.CodVehiculo = Convert.ToInt32(txtCodigovehiculo.Text);
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtCodigovehiculo.Clear();
            txtMonto.Clear();
            txtPlaca.Clear();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
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
                    txtCodigovehiculo.Text = buscar.CodVehiculo.ToString();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigovehiculo.Text == "" || txtMonto.Text == "" || txtPlaca.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();
                if (viaje.AgregarViaje() == 1)
                    LimpiarCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
