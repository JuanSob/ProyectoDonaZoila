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
    public partial class FrmCostosFijos : Form
    {
        //Clases
        ClsCostosFijos costos = new ClsCostosFijos();
        ClsValidacion validacion = new ClsValidacion();

        public FrmCostosFijos()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo para capturar datos
        public void CapturarDatos()
        {
            costos.CostoAgua = Convert.ToDouble(txtAgua.Text);
            costos.CostoLuz = Convert.ToDouble(txtCostoLuz.Text);
            costos.CostosAdicionales = Convert.ToDouble(txtOtros.Text);
            costos.CostoMantenimiento = Convert.ToDouble(txtMantenimiento.Text);
            costos.CostoGasolina = Convert.ToDouble(txtGasolina.Text);
            costos.Fecha = dpFecha.Value.Date.ToString("yyy/M/d");
        }

        //Metodo para limpiar los textbox
        public void LimpiarCampos()
        {
            txtAgua.Clear();
            txtCostoLuz.Clear();
            txtOtros.Clear();
            txtMantenimiento.Clear();
            txtGasolina.Clear();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtCostoLuz.Text == "" || txtGasolina.Text == "" || txtOtros.Text == "" || txtMantenimiento.Text == "" || txtAgua.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();

                if (costos.InsertarCostos() == 1)
                {
                    LimpiarCampos();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtCostoLuz_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.NumerosDecimales(e);
        }

        private void txtGasolina_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.NumerosDecimales(e);
        }

        private void txtOtros_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.NumerosDecimales(e);
        }

        private void txtAgua_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.NumerosDecimales(e);
        }

        private void txtMantenimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.NumerosDecimales(e);
        }
    }
}
