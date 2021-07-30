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
    public partial class FrmProveedorAgregar : Form
    {
        ClsProveedor proveedor = new ClsProveedor();
        ClsValidacion validacion = new ClsValidacion();

        public FrmProveedorAgregar()
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
            if(txtDescripcion.Text=="")
            {
                proveedor.Nombre = txtNombre.Text;
                proveedor.Telefono = txtTelefono.Text;
                proveedor.Celular = txtCelular.Text;
                proveedor.Correo = txtCorreo.Text;
                proveedor.Estado = cbEstado.GetItemText(this.cbEstado.SelectedItem);
            }
            else
            {
                proveedor.Descripcion = txtDescripcion.Text;
                proveedor.Nombre = txtNombre.Text;
                proveedor.Telefono = txtTelefono.Text;
                proveedor.Celular = txtCelular.Text;
                proveedor.Correo = txtCorreo.Text;
                proveedor.Estado = cbEstado.GetItemText(this.cbEstado.SelectedItem);
            }
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtDescripcion.Clear();
            cbEstado.SelectedItem = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtTelefono.Text == "" || txtCelular.Text == ""
               || txtCorreo.Text == "" || cbEstado.Text == "")

            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();

                if (proveedor.InsertarProveedor() == 1)
                {
                    LimpiarCampos();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            validacion.ValidarEmail(e, txtCorreo);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }
    }
}
