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
    public partial class FrmVehiculos : Form
    {
        public FrmVehiculos()
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
            panelVehiculos.Controls.Add(childForm);
            panelVehiculos.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmAgregarVehiculo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmModificarVehiculo());
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmVisualizarVehiculo());
        }

        private void btnEmpleadoVehiculo_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmEmpleadoVehiculos());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmVisualizarHistorial ());
        }
    }
}
