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
    public partial class FrmModificarMaterial : Form
    {
        //Clases
        ClsMaterial material = new ClsMaterial();
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();

        public FrmModificarMaterial()
        {
            InitializeComponent();
            DisplayData();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvMateriales, "execute cargarMaterial");
        }

        //Se capturan los atribustos a utilizar
        public void CapturarDatos()
        {
            material.Nombre = txtNombre.Text;
            material.Codigo = Convert.ToInt32(txtCodigo.Text);
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CapturarDatos();

            if(material.ModificarMaterial()==1)
            {
                LimpiarCampos();
                DisplayData();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvMateriales_SelectionChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = dgvMateriales.Rows[dgvMateriales.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombre.Text = dgvMateriales.Rows[dgvMateriales.CurrentRow.Index].Cells[1].Value.ToString();
        }
    }
}
