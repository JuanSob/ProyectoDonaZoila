using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_DoñaZoila
{
    class ClsRestaurarContraseña:ClsCorreoCodigo
    {
        private static string contraseña;

        public string Contraseña { get => contraseña; set => contraseña = value; }

        public void Cambio()
        {
            sc.Open();

            SqlCommand cmd = new SqlCommand("execute RestaurarContraseña '" + To1 + "','" + Contraseña + "'", sc);

            cmd.ExecuteNonQuery();

            sc.Close();
        }

    }
}
