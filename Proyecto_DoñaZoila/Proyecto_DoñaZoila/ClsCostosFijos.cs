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
    class ClsCostosFijos:ClsConexionBD
    {
        //Atributos
        private double costoLuz;
        private double costoGasolina;
        private double costosAdicionales;
        private double costoAgua;
        private double costoMantenimiento;
        private string fecha;

        //Encapsulamiento
        public double CostoLuz { get => costoLuz; set => costoLuz = value; }
        public double CostoGasolina { get => costoGasolina; set => costoGasolina = value; }
        public double CostosAdicionales { get => costosAdicionales; set => costosAdicionales = value; }
        public double CostoAgua { get => costoAgua; set => costoAgua = value; }
        public double CostoMantenimiento { get => costoMantenimiento; set => costoMantenimiento = value; }
        public string Fecha { get => fecha; set => fecha = value; }

        //Metodo para insertar costos fijos
        public int InsertarCostos()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute InsertarCostosFijos '" + costoLuz + "','" + costoGasolina + "','" + costosAdicionales + "'," +
                                                "'" + costoAgua + "','" + costoMantenimiento + "','" + fecha + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se agregaron los costos de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
