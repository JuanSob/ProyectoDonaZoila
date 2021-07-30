using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DoñaZoila
{
    class ClsZona:ClsConexionBD
    {
        //Atributos
        private static string nombreZona;
        private static int codZona;

        public string NombreZona { get => nombreZona; set => nombreZona = value; }
        public int CodZona { get => codZona; set => codZona = value; }



        //Metodo para insertat zona
        public int NuevaZona()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute zona 2,'" + NombreZona + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se añadió la zona de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

                var = 2;
            }
            sc.Close();

            return var;
        }

        //Metodo para modificar zona
        public int ModificarZona()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute zona 3,'" + NombreZona + "','" + CodZona + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se modificó la zona de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

                var = 2;
            }
            sc.Close();

            return var;
        }

    }
}
