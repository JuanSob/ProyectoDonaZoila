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
    class ClsOrden:ClsConexionBD
    {
        //Clases
        ClsInicioSesion inicioSesion = new ClsInicioSesion();

        //Atributos
        private static int codProveedor;
        private static int codMaterial;
        private static int cantidad;
        private static double isv;
        private static double costo;

        //Encapsulamiento
        public int CodProveedor { get => codProveedor; set => codProveedor = value; }
        public int CodMaterial { get => codMaterial; set => codMaterial = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Isv { get => isv; set => isv = value; }
        public double Costo { get => costo; set => costo = value; }

        //Crear tabla temporal
        public void CrearTemporal()
        {
            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("create table ##OrdenMateriales(id int identity, codMaterial int, cantidad int, costo float ) ", sc);
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
                SqlCommand ins = new SqlCommand("execute insertarTemporal '" + codMaterial + "','" + Cantidad + "','" + Costo + "'", sc);
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
                SqlCommand ins = new SqlCommand("execute [dbo].[nuevaOrden] '" + CodProveedor + "','" + inicioSesion.Codemp + "','" + Isv + "'", sc);
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
