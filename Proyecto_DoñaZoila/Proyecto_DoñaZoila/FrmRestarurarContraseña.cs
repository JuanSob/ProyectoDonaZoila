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
    public partial class FrmRestarurarContraseña : Form
    {

        //Clases necesarias
        ClsRestaurarContraseña restaurar = new ClsRestaurarContraseña();

        public FrmRestarurarContraseña()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            if (txtContra.Text != "" && txtVerificar.Text != "")
            {
                restaurar.Contraseña = txtContra.Text;

                if (txtContra.Text == txtVerificar.Text)
                {
                    restaurar.Cambio();

                    MessageBox.Show("Se ha cambiado la contraseña con exito", "Cambio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("La contraseña ingresada es incorrecta.", "Contraseña incorrecta", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tiene algun campo vacio, debe llenarlos todos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void FrmRestarurarContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
