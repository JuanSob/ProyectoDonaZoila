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
    public partial class FrmAgregarEmpleado : Form
    {

        //Clases
        ClsEmpleado empleado = new ClsEmpleado();
        ClsBuscar buscar = new ClsBuscar();
        ClsValidacion validacion = new ClsValidacion();

        //Formularios
        FrmPuestos puesto = new FrmPuestos();
        FrmRol rol = new FrmRol();

        public FrmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo para evitar que copien y peguen
        public void validacionTextbox()
        {
            txtUsuario.ShortcutsEnabled = false;
            txtContrasena.ShortcutsEnabled = false;
        }

        //Metodo para obtener el codigo del Rol
        private void btnRol_Click(object sender, EventArgs e)
        {
            rol.ShowDialog();

            if (buscar.Rol != 0)
            {
                txtRol.Text = buscar.Rol.ToString();
            }
            else
            {
                MessageBox.Show("No seleccionado", "REALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Metodo para obtener el codigo del puesto
        private void btnPuesto_Click(object sender, EventArgs e)
        {
            puesto.ShowDialog();
              
            if (buscar.CodigoPuesto != 0)
            {
                txtPuesto.Text = buscar.CodigoPuesto.ToString();
            }
            else
            {
                MessageBox.Show("No seleccionado", "REALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Se capturan los atribustos a utilizar
        public void CapturarDatos()
        {
            empleado.Nombre = txtNombre.Text;
            empleado.Apellido = txtApellido.Text;
            empleado.Identidad = txtIdentidad.Text;
            empleado.Puesto = Convert.ToInt32(txtPuesto.Text);
            empleado.Telefono = txtTelefono.Text;
            empleado.Telefono2 = txtCelular.Text;
            empleado.Correo = txtCorreo.Text;
            empleado.Rol = Convert.ToInt32(txtRol.Text);
            empleado.Contraseña = txtContrasena.Text;
            empleado.Usuario = txtUsuario.Text;
            empleado.Genero = cbGenero.GetItemText(this.cbGenero.SelectedItem);
            empleado.Estado = cbEstado.GetItemText(this.cbEstado.SelectedItem);
            empleado.Nacimiento = dtpNacimiento.Value.Date.ToString("yyy/M/d");
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtIdentidad.Clear();
            txtPuesto.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtRol.Clear();
            txtContrasena.Clear();
            txtUsuario.Clear();
            cbGenero.SelectedItem = null;
            cbEstado.SelectedItem = null;
        }

        //Programacion botón agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtIdentidad.Text == ""
                || txtTelefono.Text == "" || txtCelular.Text == "" || cbGenero.Text == ""
                || txtCorreo.Text == "" || txtPuesto.Text == "" || txtRol.Text == ""
                || cbEstado.Text == ""
                || txtUsuario.Text == "" || txtContrasena.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();

                if (empleado.InsertarEmpleado() == 1)
                    LimpiarCampos();
            }
        }

        //Programacion botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
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
    }
}
