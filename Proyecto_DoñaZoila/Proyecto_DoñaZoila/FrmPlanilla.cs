﻿using System;
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
    public partial class FrmPlanilla : Form
    {
        //Clases
        ClsEmpleado empleado = new ClsEmpleado();
        ClsBuscar buscar = new ClsBuscar();
        ClsValidacion validacion = new ClsValidacion();

        //Formularios
        FrmVisualizarEmpleado ver = new FrmVisualizarEmpleado();

        public FrmPlanilla()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;
        
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPlanilla.Controls.Add(childForm);
            panelPlanilla.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Metodo para capturar datos
        public void CapturarDatos()
        {
            empleado.CodEmpleado = Convert.ToInt32(txtCodigoEmpleado.Text);
            empleado.Ihss = Convert.ToDouble(txtIhss.Text)/100;
            empleado.Rap = Convert.ToDouble(txtRap.Text)/100;
            empleado.Sueldo = Convert.ToDouble(txtSueldo.Text);
            empleado.Bono = Convert.ToDouble(txtBono.Text);
            empleado.Viatico = Convert.ToDouble(txtViaticos.Text);
        }

        //Metodo para limpiar los textbox
        public void LimpiarCampos()
        {
            txtCodigoEmpleado.Clear();
            txtNombreEmpleado.Clear();
            txtIhss.Clear();
            txtRap.Clear();
            txtSueldo.Clear();
            txtBono.Clear();
            txtViaticos.Clear();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ver.ShowDialog();

            if(buscar.NombreEmpleado is null)
            {
                MessageBox.Show("No seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtNombreEmpleado.Text = buscar.NombreEmpleado;
                txtCodigoEmpleado.Text = buscar.CodigoEmpleado.ToString();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtCodigoEmpleado.Text == "" || txtNombreEmpleado.Text == "" || txtIhss.Text == ""
                || txtRap.Text == "" || txtBono.Text == "" || txtSueldo.Text == "" || txtViaticos.Text == "")

            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CapturarDatos();
                if (empleado.NuevaPlanilla() == 1)
                {
                    LimpiarCampos();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtIhss_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.NumerosDecimales(e);
        }

        private void txtRap_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.NumerosDecimales(e);
        }

        private void txtBono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.NumerosDecimales(e);
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.NumerosDecimales(e);
        }

        private void txtViaticos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.NumerosDecimales(e);
        }
    }
}
