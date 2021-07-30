using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DoñaZoila
{
    class ClsCargarDataGrid:ClsConexionBD
    {

        DataTable dt;

        public void cargaDatos(DataGridView dgv, String dad)
        {
            try
            {
                da = new SqlDataAdapter(dad, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede cargar los datos" + ex.ToString());
            }
        }

    }
}
