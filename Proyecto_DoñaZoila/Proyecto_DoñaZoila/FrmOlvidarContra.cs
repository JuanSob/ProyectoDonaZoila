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
    public partial class FrmOlvidarContra : Form
    {
        //Clases
        ClsCorreoCodigo correo = new ClsCorreoCodigo();


        public FrmOlvidarContra()
        {
            InitializeComponent();
        }

        //Eventos necesarios en la carga del form
        private void FrmOlvidarContra_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            btnCodigo.Enabled = false;
        }

        //Programación botones minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Programación botones cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Programación botón para enviar correo
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "")
            {
                correo.To1 = txtCorreo.Text;

                if (true == correo.VerificarCorreo())
                {
                    MessageBox.Show("Espere un momento enviando correo.....", "ENVIANDO CORREO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (true == correo.Enviar())
                    {
                        MessageBox.Show("El codigo se ha enviado de manera exitosa.", "Codigo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        txtCodigo.Enabled = true;
                        btnCodigo.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No se logró enviar el correo electronico.", "Codigo", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                        txtCorreo.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("El correo ingresado no pertenece a nadie", "Correo invalido", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtCorreo.Clear();
                }
            }
            else
            {
                MessageBox.Show("No se ha escrito ningun correo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Programcación botón para verificar el código ingresado
        private void btnCodigo_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text != "")
            {
                if (txtCodigo.Text == correo.CodigoRandom)
                {
                    FrmRestarurarContraseña contra = new FrmRestarurarContraseña();
                    this.Close();
                    contra.Show();
                    correo.CodigoRandom = null;
                }
                else
                {
                    MessageBox.Show("El codigo que ha ingresado no es el correcto.", "Error de Codigo", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No se ha escrito ningun codigo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void FrmOlvidarContra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}
