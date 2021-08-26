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
    public partial class FrmMaterialesAgregar : Form
    {
        ClsMaterial material = new ClsMaterial();
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();

        public FrmMaterialesAgregar()
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
            material.Nombre = txtNombre.Text;
            material.Descripcion = cbDescripcion.SelectedItem.ToString();
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            cbDescripcion.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || cbDescripcion.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();
                if (material.NuevoMaterial() == 1)
                {
                    LimpiarCampos();
                }
            }
        
    }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
