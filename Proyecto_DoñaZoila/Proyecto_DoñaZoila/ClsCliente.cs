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
    class ClsCliente:ClsConexionBD
    {

        private static string nombre;
        private static string numero;
        private static int codZona;
        private static string correo;
        private static int codCliente;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Numero { get => numero; set => numero = value; }
        public int CodZona { get => codZona; set => codZona = value; }
        public string Correo { get => correo; set => correo = value; }
        public int CodCliente { get => codCliente; set => codCliente = value; }

        //Metodo para ingresar nuevos clientes
        public int InsertarCliente()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute Cliente 1, '" + Nombre + "','" + Numero + "','" + CodZona + "'," +
                                                "'" + Correo + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se agregó el cliente de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        //Metodo para modificar nuevos clientes
        public int ModificarCliente()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute Cliente 3, '" + Nombre + "','" + Numero + "','" + CodZona + "'," +
                                                "'" + Correo + "','" + codCliente + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se modificó el cliente de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
