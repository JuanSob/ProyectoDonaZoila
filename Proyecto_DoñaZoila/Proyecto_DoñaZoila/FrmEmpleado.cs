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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmAgregarEmpleado());
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
            panelRegistros.Controls.Add(childForm);
            panelRegistros.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmModificarEmpleado());
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmVisualizarEmpleado());
        }
    }
}
