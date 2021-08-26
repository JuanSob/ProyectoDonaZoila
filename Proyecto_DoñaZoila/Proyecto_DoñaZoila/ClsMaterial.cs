using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_DoñaZoila
{
    class ClsMaterial:ClsConexionBD
    {

        private static string nombre;
        private static int codigo;
        private string descripcion;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        //Metodo para insertar maerial
        public int NuevoMaterial()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute insertarMaterial 1,'" + Nombre + "','" + Descripcion + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se añadió el material de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public int ModificarMaterial()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute insertarMaterial 2,'" + Nombre + "','" + Descripcion + "','" + Codigo + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se cambió el material de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
