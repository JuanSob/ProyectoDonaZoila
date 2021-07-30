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
    public partial class FrmAgregarCliente : Form
    {
        //Clases
        ClsBuscar buscar = new ClsBuscar();
        ClsCliente cliente = new ClsCliente();
        ClsValidacion validacion = new ClsValidacion();

        //Forms
        FrmVisualizarZona zona = new FrmVisualizarZona();

        public FrmAgregarCliente()
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
            cliente.Nombre = txtNombre.Text;
            cliente.Numero = txtTelefono.Text;
            cliente.Correo = txtCorreo.Text;
            cliente.CodZona = Convert.ToInt32(txtCodigoZona.Text);
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtCodigoZona.Clear();
            txtNombreZona.Clear();
        }

        private void btnPuesto_Click(object sender, EventArgs e)
        {
            zona.ShowDialog();

            if (buscar.NombreZona is null)
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtCodigoZona.Text = (buscar.CodZona).ToString();
                txtNombreZona.Text = buscar.NombreZona;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || txtNombre.Text == "" || txtCodigoZona.Text == "")
            {
                MessageBox.Show("Llene todo los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();
                if (cliente.InsertarCliente() == 1)
                {
                    LimpiarCampos();
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            validacion.ValidarEmail(e,txtCorreo);
        }
    }
}
