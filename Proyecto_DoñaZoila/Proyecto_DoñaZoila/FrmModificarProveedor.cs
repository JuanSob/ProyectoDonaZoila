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
    public partial class FrmModificarProveedor : Form
    {
        //Clases
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsProveedor proveedor = new ClsProveedor();
        ClsValidacion validacion = new ClsValidacion();

        public FrmModificarProveedor()
        {
            InitializeComponent();

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProveedorModificar_Load(object sender, EventArgs e)
        {
            DisplayData();

            foreach (DataGridViewColumn column in dgvEmpleados.Columns)
            {
                column.Width = 140;
            }

            foreach (DataGridViewRow row in dgvEmpleados.Rows)
            {
                row.Height = 30;
            }
        }

        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvEmpleados, "execute [dbo].[cargarProveedores]");
        }

        //Se capturan los atribustos a utilizar
        public void CapturarDatos()
        {
            if (txtDescripcion.Text == "")
            {
                proveedor.CodProveedor = Convert.ToInt32(txtCodigo.Text);
                proveedor.Nombre = txtNombre.Text;
                proveedor.Telefono = txtTelefono.Text;
                proveedor.Celular = txtCelular.Text;
                proveedor.Correo = txtCorreo.Text;
                proveedor.Estado = cbEstado.GetItemText(this.cbEstado.SelectedItem);
            }
            else
            {
                proveedor.CodProveedor = Convert.ToInt32(txtCodigo.Text);
                proveedor.Descripcion = txtDescripcion.Text;
                proveedor.Nombre = txtNombre.Text;
                proveedor.Telefono = txtTelefono.Text;
                proveedor.Celular = txtCelular.Text;
                proveedor.Correo = txtCorreo.Text;
                proveedor.Estado = cbEstado.GetItemText(this.cbEstado.SelectedItem);
            }
        }

        public void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtDescripcion.Clear();
            cbEstado.SelectedItem = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Programar datos del data grid a textbox
        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            if (dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[5].Value.Equals(""))
            {
                txtCodigo.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[0].Value.ToString();
                txtNombre.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[1].Value.ToString();
                txtTelefono.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[2].Value.ToString();
                txtCelular.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[3].Value.ToString();
                txtCorreo.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[4].Value.ToString();
                cbEstado.SelectedItem = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[6].Value.ToString();
            }
            else
            {
                txtCodigo.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[0].Value.ToString();
                txtNombre.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[1].Value.ToString();
                txtTelefono.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[2].Value.ToString();
                txtCelular.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[3].Value.ToString();
                txtCorreo.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[4].Value.ToString();
                txtDescripcion.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[5].Value.ToString();
                cbEstado.SelectedItem = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[6].Value.ToString();
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtTelefono.Text == ""
               || txtCelular.Text == "" || txtCorreo.Text == "" || cbEstado.Text == "")

            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();

                if (proveedor.ModificarProveedor() == 1)
                {
                    LimpiarCampos();
                    DisplayData();
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
