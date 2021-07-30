using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_DoñaZoila
{
    public partial class FrmMenu : Form
    {
        //Clases
        ClsInicioSesion inicioSesion = new ClsInicioSesion();

        public FrmMenu()
        {
            InitializeComponent();
            Personalizar_Diseno();

            lblNombre.Text = inicioSesion.NombreEmpleado;
        }

        private void Personalizar_Diseno()
        {
            panelEmpleado.Visible = false;
            panelInventario.Visible = false;
            panelOtros.Visible = false;
            panelVentas.Visible = false;
            
        }

        //Ocultar Submenus
        private void OcultarSubmenu()
        {
            if (panelEmpleado.Visible == true)
                panelEmpleado.Visible = false;
            if (panelInventario.Visible == true)
                panelInventario.Visible = false;
            if (panelOtros.Visible == true)
                panelOtros.Visible = false;
            if (panelVentas.Visible == true)
                panelVentas.Visible = false;

        }
        //Para mostrar el submenu
        private void mostrarSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                OcultarSubmenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelEmpleado);
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
            panelCentral.Controls.Add(childForm);
            panelCentral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmEmpleado());
            OcultarSubmenu();
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmPlanilla());
            OcultarSubmenu();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void panelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelCentral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmProveedores());
            OcultarSubmenu();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelInventario);
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmMateriales());
            OcultarSubmenu();
        }

        private void btnOrdenMateriales_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmOrdenes());
            OcultarSubmenu();
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelOtros);
        }

        private void btnCostosFijos_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmCostosFijos());
            OcultarSubmenu();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmInicioSesion inicioSesion = new FrmInicioSesion();
            inicioSesion.Show();
            this.Close();
        }

        private void btnZonas_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmZonas());
            OcultarSubmenu();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelVentas);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmCliente());
            OcultarSubmenu();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmVehiculos());
            OcultarSubmenu();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmProductos());
            OcultarSubmenu();
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmEntrega());
            OcultarSubmenu();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmTodosReportes());
            OcultarSubmenu();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();

            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnViaje_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmViajes());
            OcultarSubmenu();
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmMapa());
            OcultarSubmenu();
        }
    }
}
