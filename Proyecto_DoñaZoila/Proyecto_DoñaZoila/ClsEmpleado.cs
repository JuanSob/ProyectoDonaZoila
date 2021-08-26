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
    class ClsEmpleado:ClsConexionBD
    {

        //Atributos necesarios registro y modificacion empleado
        private static int codEmpleado;
        private static string nombre;
        private static string apellido;
        private static string identidad;
        private static int puesto;
        private static string telefono;
        private static string telefono2;
        private static string nacimiento;
        private static string genero;
        private static string correo;
        private static int rol;
        private static string contraseña;
        private static string usuario;
        private static string estado;

        //Atributos necesarios planilla
        private static double ihss;
        private static double rap;
        private static double bono;
        private static double sueldo;
        private static double viatico;
        private static double aguinaldo;
        private static double debito;
        private static string razonDebito;

        //Encapsulamiento
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Identidad { get => identidad; set => identidad = value; }
        public int Puesto { get => puesto; set => puesto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Telefono2 { get => telefono2; set => telefono2 = value; }
        public string Nacimiento { get => nacimiento; set => nacimiento = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Rol { get => rol; set => rol = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Estado { get => estado; set => estado = value; }
        public int CodEmpleado { get => codEmpleado; set => codEmpleado = value; }
        public double Ihss { get => ihss; set => ihss = value; }
        public double Rap { get => rap; set => rap = value; }
        public double Bono { get => bono; set => bono = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public double Viatico { get => viatico; set => viatico = value; }
        public double Aguinaldo { get => aguinaldo; set => aguinaldo = value; }
        public double Debito { get => debito; set => debito = value; }
        public string RazonDebito { get => razonDebito; set => razonDebito = value; }

        //Metodo para ingresar nuevos empleados
        public int InsertarEmpleado()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute [insertarEmpleados] '" + Nombre + "','" + Apellido + "','" + Identidad + "'," +
                                                "'" + Puesto + "','" + Telefono + "','" + Telefono2 + "','" + Nacimiento + "'," +
                                                "'" + Genero + "','" + Correo + "','" + Rol + "','" + Contraseña + "'," +
                                                "'" + Usuario + "','" + Estado + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se el empleado de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        //Metodo para modificar empleado
        public int ModificarEmpleado()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute modificarEmpleado '" + CodEmpleado + "', '" + Nombre + "','" + Apellido + "','" + Identidad + "'," +
                                                "'" + Puesto + "','" + Telefono + "','" + Telefono2 + "','" + Nacimiento + "'," +
                                                "'" + Genero + "','" + Correo + "','" + Rol + "','" + Estado + "'", sc);
                ins.ExecuteNonQuery();
                MessageBox.Show("Se modificó el empleado de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        //Metodo para modificar empleado
        public int NuevaPlanilla()
        {
            int var;

            sc.Open();
            try
            {
                SqlCommand ins = new SqlCommand("execute [dbo].[insertarPlanilla] '" + CodEmpleado + "', '" + Ihss + "','" + Rap + "','" + Bono + "'," +
                                               "'" + Sueldo + "','" + Viatico + "','" + Aguinaldo + "','" + Debito + "'," +
                                               "'" + RazonDebito + "'", sc);

                ins.ExecuteNonQuery();
                MessageBox.Show("Se realizó la planilla de manera correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
