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
    class ClsCategoríaProducto:ClsConexionBD
    {
        //Atributos
        private string nombreCategoria;
        private int codCategoria;
        
        //Encapsulamiento
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public int CodCategoria { get => codCategoria; set => codCategoria = value; }

        //Metodo para insertar nuevas categorías
        public int InsertarCategoria()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute ProcedimientoCategoría 2,'" + NombreCategoria + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se agregó la nueva categoría de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        //Metodo para modificar categorías
        public int ModificarCategoria()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute ProcedimientoCategoría 3,'" + NombreCategoria + "','" + CodCategoria + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se modificó la categoría de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
