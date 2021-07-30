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
    public partial class FrmPuestos : Form
    {
        //Clases
        ClsCargarDataGrid cargar = new ClsCargarDataGrid();
        ClsBuscar buscar = new ClsBuscar();

        public FrmPuestos()
        {
            InitializeComponent();
        }

        //Lo que se ejecuta al cargar el form
        private void FrmPuestos_Load(object sender, EventArgs e)
        {
            DisplayData();

            foreach (DataGridViewColumn column in dgvPuestos.Columns)
            {
                column.Width = 230;
            }

            foreach (DataGridViewRow row in dgvPuestos.Rows)
            {
                row.Height = 30;
            }
        }

        //Metodo para traer datos al data grid view
        private void DisplayData()
        {
            cargar.Abrir();
            cargar.cargaDatos(dgvPuestos, "execute [dbo].[cargarPuestoRol] 2");
        }

        //Programación boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Programación boton minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Metodo pasar valor al atributo
        private void dgvPuestos_DoubleClick(object sender, EventArgs e)
        {
            buscar.CodigoPuesto = Convert.ToInt32(dgvPuestos.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

    }
}
