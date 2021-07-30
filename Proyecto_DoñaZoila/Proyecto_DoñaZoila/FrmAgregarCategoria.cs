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
    public partial class FrmAgregarCategoria : Form
    {
        //Clases
        ClsCategoríaProducto categoria = new ClsCategoríaProducto();

        public FrmAgregarCategoria()
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
            categoria.NombreCategoria = txtDescripcion.Text;
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtDescripcion.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();

                if (categoria.InsertarCategoria() == 1)
                {
                    LimpiarCampos();
                }
            }
        }
    }
}
