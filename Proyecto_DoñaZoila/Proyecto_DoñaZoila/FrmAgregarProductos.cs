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
    public partial class FrmAgregarProductos : Form
    {
        //Clases
        ClsProductos productos = new ClsProductos();
        ClsBuscar buscar = new ClsBuscar();
        ClsValidacion validacion = new ClsValidacion();

        //Forms
        FrmVisualizarCategoria categoria = new FrmVisualizarCategoria();

        public FrmAgregarProductos()
        {
            InitializeComponent();
        }

        //Se capturan los atribustos a utilizar
        public void CapturarDatos()
        {
            productos.NombreProducto = txtNombreProducto.Text;
            productos.CodigoBarra = txtCodigoBarra.Text;
            productos.CodCategoria = Convert.ToInt32(txtCodigoCategoria.Text);
        }

        //Metodo para poder limpiar todos los campos
        public void LimpiarCampos()
        {
            txtNombreCategoria.Clear();
            txtNombreProducto.Clear();
            txtCodigoCategoria.Clear();
            txtCodigoBarra.Clear();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            categoria.ShowDialog();

            if (buscar.NombreCategoria is null)
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {                
                txtNombreCategoria.Text = buscar.NombreCategoria;
                txtCodigoCategoria.Text = buscar.CodCategoria.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "" || txtCodigoBarra.Text == "" || txtCodigoCategoria.Text == "" || txtNombreCategoria.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();
                if (productos.InsertarProducto() == 1)
                {
                    LimpiarCampos();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }
    }
}
