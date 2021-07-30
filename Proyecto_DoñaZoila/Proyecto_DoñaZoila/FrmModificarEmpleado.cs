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
    public partial class FrmModificarEmpleado : Form
    {
        //Clases
        ClsEmpleado empleado = new ClsEmpleado();
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsBuscar buscar = new ClsBuscar();
        ClsValidacion validacion = new ClsValidacion();

        //Formularios
        FrmPuestos puesto = new FrmPuestos();
        FrmRol rol = new FrmRol();

        public FrmModificarEmpleado()
        {
            InitializeComponent();
        }

        //Programación ejecutada cuando el form carga
        private void FrmModificarEmpleado_Load(object sender, EventArgs e)
        {
            DisplayData();

            foreach (DataGridViewColumn column in dgvEmpleados.Columns)
            {
                column.Width = 115;
            }

            foreach (DataGridViewRow row in dgvEmpleados.Rows)
            {
                row.Height = 30;
            }
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvEmpleados, "execute [dbo].[CargarEmpleado] 1");
        }

        private void DisplayData2(string identidad)
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvEmpleados, "execute [dbo].[CargarEmpleado] 2, '"+identidad+"'");
        }

        //Se capturan los atribustos a utilizar
        public void CapturarDatos()
        {
            empleado.CodEmpleado = Convert.ToInt32(txtCodigo.Text);
            empleado.Nombre = txtNombre.Text;
            empleado.Apellido = txtApellido.Text;
            empleado.Identidad = txtIdentidad.Text;
            empleado.Puesto = Convert.ToInt32(txtPuesto.Text);
            empleado.Telefono = txtTelefono.Text;
            empleado.Telefono2 = txtCelular.Text;
            empleado.Correo = txtCorreo.Text;
            empleado.Rol = Convert.ToInt32(txtRol.Text);
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
            cbGenero.SelectedItem = null;
            cbEstado.SelectedItem = null;
        }

        //Metodo para obtener el codigo del Puesto
        private void btnPuesto_Click(object sender, EventArgs e)
        {
            puesto.ShowDialog();

            if (buscar.CodigoPuesto != 0)
            {
                txtPuesto.Text = buscar.CodigoPuesto.ToString();
            }
            else
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        //Programacion boton para modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtIdentidad.Text == ""
                 || txtTelefono.Text == "" || txtCelular.Text == "" || cbGenero.Text == ""
                 || txtCorreo.Text == "" || txtPuesto.Text == "" || txtRol.Text == ""
                 || cbEstado.Text == ""
                 || txtCodigo.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();

                if (empleado.ModificarEmpleado() == 1)
                {
                    LimpiarCampos();
                    DisplayData();
                }
            }
        }

        //Programacion botón Cancelar
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Programacion boton para retornar
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Programar datos del data grid a textbox
        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            dgvEmpleados.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEmpleados.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEmpleados.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEmpleados.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEmpleados.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            
            txtCodigo.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombre.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[1].Value.ToString();
            txtApellido.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[2].Value.ToString();
            txtIdentidad.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[3].Value.ToString();
            txtPuesto.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[4].Value.ToString();
            txtTelefono.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[5].Value.ToString();
            txtCelular.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[6].Value.ToString();
            dtpNacimiento.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells[7].Value.ToString());
            cbGenero.SelectedItem = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[8].Value.ToString();
            txtCorreo.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[9].Value.ToString();
            txtRol.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[10].Value.ToString();
            cbEstado.SelectedItem = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[11].Value.ToString();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            DisplayData2(this.txtBuscar.Text.Trim());
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

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            validacion.ValidarEmail(e, txtCorreo);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }
    }
}
