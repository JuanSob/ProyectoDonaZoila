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
    class ClsEntrega:ClsConexionBD
    {
        //Atributos
        private static int codCliente;
        private static int codViaje;
        private static int codEmpleado;
        private static int codProducto;
        private static double isv;
        private static double precio;
        private static int cantidad;

        //Encapsulamiento
        public int CodCliente { get => codCliente; set => codCliente = value; }
        public int CodViaje { get => codViaje; set => codViaje = value; }
        public int CodEmpleado { get => codEmpleado; set => codEmpleado = value; }
        public double Isv { get => isv; set => isv = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int CodProducto { get => codProducto; set => codProducto = value; }


        //Crear tabla temporal
        public void CrearTemporal()
        {
            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("create table ##EntregaProducto(id int identity, codProducto int, cantidad int, costo float ) ", sc);
                ins.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        //Insertar en la tabla temporal creada anteriormente
        public void InsertarTemporal()
        {
            try
            {
                SqlCommand ins = new SqlCommand("execute insertarTemporalProducto '" + CodProducto + "','" + Cantidad + "','" + precio + "'", sc);
                ins.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        //Insertar en la tabla temporal creada anteriormente
        public void InsertarTablas()
        {
            try
            {
                SqlCommand ins = new SqlCommand("execute nuevaEntrega '" + CodCliente + "','" + CodEmpleado + "','" + Isv + "','" + codViaje + "'", sc);
                ins.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            sc.Close();
        }
    }
}
