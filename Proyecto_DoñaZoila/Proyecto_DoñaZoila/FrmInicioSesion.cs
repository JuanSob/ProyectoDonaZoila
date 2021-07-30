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
    public partial class FrmInicioSesion : Form
    {
        //Clases
        ClsInicioSesion iniciar = new ClsInicioSesion();

        //Variables Globales
        int clickUsuario = 0;
        int clickContraseña = 0;

        public FrmInicioSesion()
        {
            InitializeComponent();
            validacionTextbox();
        }

        //Metodo para evitar que copien y peguen
        public void validacionTextbox()
        {
            txtUsuario.ShortcutsEnabled = false;
            txtContrasena.ShortcutsEnabled = false;
        }
        
        //Programacion Labels
        public void CambioColorUsuario(int num)
        {
            if(num == 1)
            {
                lblUsuario.Text = "*Debe de ingresar su nombre de usuario.";
                lblUsuario.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblUsuario.ForeColor = System.Drawing.Color.Black;
            }
        }

        public void CambioColorContraseña(int num)
        {
            if (num == 1)
            {
                lblContraseña.Text = "*Debe de ingresar su contraseña.";
                lblContraseña.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblContraseña.ForeColor = System.Drawing.Color.Black;
            }
        }
        //Fin programacion label

        //Programacion de los text box de usuario
        private void txtUsuario_Click(object sender, EventArgs e)
        {
            clickUsuario++;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;

                if (clickUsuario > 0)
                    CambioColorUsuario(1);
            }
            else
                CambioColorUsuario(2);
        }
        //Fin programacion de los text box de usuario

        //Programacion de los text box de Contraseña
        private void txtContrasena_Click(object sender, EventArgs e)
        {
            clickContraseña++;
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.LightGray;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.DimGray;
                txtContrasena.UseSystemPasswordChar = false;

                if (clickContraseña > 0)
                    CambioColorContraseña(1);
            }
            else
                CambioColorContraseña(2);
        }
        //Fin programacion de los text box de Contraseña



        //Programación inicio de sesión
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            //Validación de los textbox
            if(txtUsuario.Text.Equals("Usuario") && txtContrasena.Text.Equals("Contraseña"))
            {
                CambioColorUsuario(1);
                CambioColorContraseña(1);
            }
            else if(txtUsuario.Text.Equals("Usuario"))
            {
                CambioColorContraseña(1);
                CambioColorContraseña(2);
            }
            else if(txtContrasena.Text.Equals("Contraseña"))
            {
                CambioColorContraseña(2);
                CambioColorContraseña(1);
            }
            else
            {
                CambioColorContraseña(2);
                CambioColorContraseña(2);

                //Se llaman las variables en las que se almacena lo escrito en el text box
                iniciar.Usuario = this.txtUsuario.Text;
                iniciar.Contraseña = this.txtContrasena.Text;

                if (iniciar.Buscar() == true)
                {
                    FrmMenu Men = new FrmMenu();
                    Men.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(""+iniciar.Msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Programación botones cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Programación botones minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Programación link label para restaurar contraseña
        private void lblOlvidar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmOlvidarContra olvidar = new FrmOlvidarContra();
            olvidar.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void FrmInicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
