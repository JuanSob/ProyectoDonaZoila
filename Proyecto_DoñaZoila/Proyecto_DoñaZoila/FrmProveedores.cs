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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
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
            panelProveedor.Controls.Add(childForm);
            panelProveedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmProveedorAgregar());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmModificarProveedor());
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmVisualizarProveedor());
        }
    }
}
