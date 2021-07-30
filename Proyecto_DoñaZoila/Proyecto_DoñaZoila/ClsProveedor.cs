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
    class ClsProveedor:ClsConexionBD
    {
        //Atributos
        private static string nombre;
        private static string telefono;
        private static string celular;
        private static string correo;
        private static string estado;
        private static string descripcion;
        private static int codProveedor;

        //Encapsulamiento
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CodProveedor { get => codProveedor; set => codProveedor = value; }

        //Metodo Para poder ingresar nuevos proveedores
        public int InsertarProveedor()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute [ProveedoresInsertUpdate] 1, '" + Nombre + "','" + Telefono + "','" + Celular + "','" + Correo + "'," +
                                                "'" + Descripcion + "','" + Estado + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se agregó el proveedor de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        //Metodo Para poder modificar nuevos proveedores
        public int ModificarProveedor()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute [ProveedoresInsertUpdate] 2, '" + Nombre + "','" + Telefono + "','" + Celular + "','" + Correo + "'," +
                                                "'" + Descripcion + "','" + Estado + "','" + CodProveedor + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se modificó el proveedor de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
