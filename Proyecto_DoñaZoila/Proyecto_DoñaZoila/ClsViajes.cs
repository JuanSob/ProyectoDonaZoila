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
    class ClsViajes:ClsConexionBD
    {
        //Atributos
        private static double montoCargado;
        private static int codVehiculo;

        public double MontoCargado { get => montoCargado; set => montoCargado = value; }
        public int CodVehiculo { get => codVehiculo; set => codVehiculo = value; }

        //Metodo para agregar nuevos viajes
        public int AgregarViaje()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute Viaje 2, '" + montoCargado + "','" + codVehiculo + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se agregó el viaje de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
