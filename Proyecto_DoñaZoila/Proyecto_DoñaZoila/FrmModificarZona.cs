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
    public partial class FrmModificarZona : Form
    {
        //Clases
        ClsZona zona = new ClsZona();
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();

        public FrmModificarZona()
        {
            InitializeComponent();
        }

        private void FrmModificarZona_Load(object sender, EventArgs e)
        {
            DisplayData();
            foreach (DataGridViewColumn column in dgvZona.Columns)
            {
                column.Width = 216;
            }

            foreach (DataGridViewRow row in dgvZona.Rows)
            {
                row.Height = 30;
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvZona, "execute zona 1");
        }

        //Se capturan los atribustos a utilizar
        public void CapturarDatos()
        {
            zona.NombreZona = txtNombre.Text;
            zona.CodZona = Convert.ToInt32(txtCodigo.Text);
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
        }

        private void dgvZona_SelectionChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = dgvZona.Rows[dgvZona.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombre.Text = dgvZona.Rows[dgvZona.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            if (zona.ModificarZona() == 1)
            {
                DisplayData();
                LimpiarCampos();
            }
        }
    }
}
