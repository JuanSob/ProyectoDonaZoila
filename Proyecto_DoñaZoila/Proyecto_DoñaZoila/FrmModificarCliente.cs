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
    public partial class FrmModificarCliente : Form
    {

        //Clases
        ClsBuscar buscar = new ClsBuscar();
        ClsCliente cliente = new ClsCliente();
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsValidacion validacion = new ClsValidacion();

        //Forms
        FrmVisualizarZona zona = new FrmVisualizarZona();

        public FrmModificarCliente()
        {
            InitializeComponent();
            DisplayData();

            foreach (DataGridViewColumn column in dgvCliente.Columns)
            {
                column.Width = 140;
            }

            foreach (DataGridViewRow row in dgvCliente.Rows)
            {
                row.Height = 30;
            }
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvCliente, "execute [dbo].[Cliente] 2");
        }

        //Se capturan los atribustos a utilizar
        public void CapturarDatos()
        {
            cliente.CodCliente = Convert.ToInt32(txtCodigo.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Numero = txtTelefono.Text;
            cliente.Correo = txtCorreo.Text;
            cliente.CodZona = Convert.ToInt32(txtCodigoZona.Text);
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtCodigoZona.Clear();
            txtNombreZona.Clear();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || txtNombre.Text == "" || txtCodigoZona.Text == "")
            {
                MessageBox.Show("Llene todo los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();

                if (cliente.ModificarCliente() == 1)
                {
                    DisplayData();
                    LimpiarCampos();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            
            txtCodigo.Text = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombre.Text = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[1].Value.ToString();
            txtTelefono.Text = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[2].Value.ToString();
            txtCorreo.Text = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[3].Value.ToString();
            txtCodigoZona.Text = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[4].Value.ToString();
            txtNombreZona.Text = dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[5].Value.ToString();
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            validacion.ValidarEmail(e, txtCorreo);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }
    }
}
