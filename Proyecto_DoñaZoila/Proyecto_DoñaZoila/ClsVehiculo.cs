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
    class ClsVehiculo:ClsConexionBD
    {
        //Atributos
        private static int codVehiculo;
        private static string marca;
        private static string descripcion;
        private static string placaCarro;
        private static string estado;
        private static int empleado;

        //Encapsulamiento
        public int CodVehiculo { get => codVehiculo; set => codVehiculo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string PlacaCarro { get => placaCarro; set => placaCarro = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Empleado { get => empleado; set => empleado = value; }

        //Metodo para ingfresar nuevo vehículo
        public int InsertarVehiculo()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute InsertarVehiculoConductor '" + Marca + "','" + Descripcion + "','" + PlacaCarro + "'," +
                                     "'" + Estado + "','" + Empleado + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se agregó el vehículo de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        //Metodo para modificar datos del vehículo
        public int ModificarVehiculo()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute modificarVehiculo '" + Marca + "','" + Descripcion + "','" + PlacaCarro + "'," +
                                     "'" + Estado + "','" + CodVehiculo + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se modificaro los datos del vehículo de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        //Metodo para modificar el conductor del vehículo
        public int CambioConductor()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute modificarConductor '" + codVehiculo + "','" + empleado + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se cambió el conductor del vehículo de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
