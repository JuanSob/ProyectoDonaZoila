using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Proyecto_DoñaZoila
{
    class ClsConexionBD
    {
        //Atributos necesarios
        public string cadenaconexion;
        protected string sql;
        protected int resultado;
        protected SqlConnection cnn;
        protected SqlCommand comandosql;
        protected string mensaje;
        public SqlCommandBuilder cmb;
        public SqlCommand comando;

        DataTable dt;
        public SqlDataAdapter da;
        SqlCommand cmdo;
        SqlDataReader dr;

        //Cadena conexión
        public string conexion = "Data Source=DESKTOP-SEC5S6T;Initial Catalog=ProductosDoñaZoila;Integrated Security=True";
        //public string conexion = "Data Source=Banegas;Initial Catalog=ProductosDoñaZoila;Integrated Security=True";
        //public string conexion = "Data Source=DESKTOP-UNDHECI;Initial Catalog=ProductosDoñaZoila;Integrated Security=True";
        //public string conexion = "Data Source=SENTY;Initial Catalog=ProductosDoñaZoila;Integrated Security=True";

        public SqlConnection sc = new SqlConnection();

        //metodo constructor
        public ClsConexionBD()
        {
            sc.ConnectionString = conexion;
        }

        //Abrir conexion a Base de datos
        public void Abrir()
        {
            try
            {
                sc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Ocurrido: " + ex);
            }
            finally
            {
                sc.Close();
            }
        }

        //Cerrar conexion a Base de datos
        public void Cerrar()
        {
            sc.Close();
        }
    }
}
