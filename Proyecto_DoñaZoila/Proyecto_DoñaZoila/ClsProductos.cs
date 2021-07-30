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
    class ClsProductos:ClsConexionBD
    {
        //Atributos
        private static string nombreProducto;
        private static string codigoBarra;
        private static int codCategoria;
        private static int codProducto;
        private static int productoNuevo;
        private static int codMaterial;
        private static int materialUtilizado;

        //Encapsulamiento
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string CodigoBarra { get => codigoBarra; set => codigoBarra = value; }
        public int CodCategoria { get => codCategoria; set => codCategoria = value; }
        public int CodProducto { get => codProducto; set => codProducto = value; }
        public int ProductoNuevo { get => productoNuevo; set => productoNuevo = value; }
        public int CodMaterial { get => codMaterial; set => codMaterial = value; }
        public int MaterialUtilizado { get => materialUtilizado; set => materialUtilizado = value; }


        //Metodo para insertar nuevos productos
        public int InsertarProducto()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute procedimientoProductos 2,'" + NombreProducto + "','" + CodigoBarra + "','" + CodCategoria + "'", sc);
                ins.ExecuteNonQuery();
                
                MessageBox.Show("Se agregó el nuevo producto de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        //Metodo para modificar productos
        public int ModificarProducto()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute procedimientoProductos 3,'" + NombreProducto + "','" + CodigoBarra + "','" + CodCategoria + "'," +
                                                "'" + codProducto + "'", sc);
                ins.ExecuteNonQuery();
                
                MessageBox.Show("Se modificó el producto de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        //Metodo para cambiar la cantidad de material en inventario
        public int RealizacionProducto()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute RealizacionProductos '" + CodProducto + "','" + CodMaterial + "','" + productoNuevo + "','" + MaterialUtilizado + "'", sc);
                ins.ExecuteNonQuery();

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

        //Metodo para cambiar la cantidad de producto en inventario
        public void NuevoProducto()
        {
            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute nuevoProducto '" + CodProducto + "','" + ProductoNuevo + "'", sc);
                ins.ExecuteNonQuery();

                MessageBox.Show("Se agregó el nuevo producto de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            sc.Close();
        }
    }
}
