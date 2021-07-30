using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_DoñaZoila
{
    class ClsInicioSesion:ClsConexionBD
    {
        //Atributos
        private string usuario;
        private string contraseña;
        private static int rol;
        private string sql;
        private  SqlCommand  comandosql;
        private static string nombreEmpleado;
        private static int codemp;
        private static string est;
        private static string msj;

        //Metodo constructor
        public ClsInicioSesion()
        {
            usuario = string.Empty;
            contraseña = string.Empty;

            this.sql = string.Empty;
        }


        //Encapsulamiento
        public string Usuario
        {
            get
            {
                return this.usuario;
            }

            set
            {
                this.usuario = value;
            }
        }


        public string Contraseña
        {
            get
            {
                return this.contraseña;
            }

            set
            {
                this.contraseña = value;
            }
        }


        public int Rol { get => rol; set => rol = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public int Codemp { get => codemp; set => codemp = value; }
        public string Msj { get => msj; set => msj = value; }

        //Metodo para validar y verificar que la contraseña haya sido correcta
        public bool Buscar()
        {
            bool Resultado = false;

            sc.Open();
            this.sql = string.Format(@"select [usuario] , Convert(varchar(50), Decryptbypassphrase('C0ntr@$Eñä', [contraseña]))  from [dbo].[Empleado] where [usuario] = '" + this.usuario + "' and Convert(varchar(50),Decryptbypassphrase('C0ntr@$Eñä', contraseña)) = '" + this.contraseña + "'");

            SqlCommand memb = new SqlCommand("execute InicioSesion 1, '" + this.usuario + "'", sc);
            rol = Convert.ToInt32(memb.ExecuteScalar());

            SqlCommand code = new SqlCommand("execute InicioSesion 2,'" + this.usuario + "'", sc);
            codemp = Convert.ToInt32(code.ExecuteScalar());

            SqlCommand nom = new SqlCommand("execute InicioSesion 3, '" + this.Usuario + "'", sc);

            try
            {
                SqlCommand estado = new SqlCommand("execute InicioSesion 4, '" + this.Usuario + "'", sc);
                est = estado.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
                est = "n";
            }

            //se llaman los comandos de sql
            this.comandosql = new SqlCommand(this.sql, this.sc);

            //Se inicializa para poder leer lo que se trae de SQL
            SqlDataReader Reg = null;

            //Se pasa lo obtenido con el query a esta variable
            Reg = this.comandosql.ExecuteReader();

            if (est == "Activo")
            {
                if (Reg.Read())//Si lo que encuentra no es algo null procede
                {
                    Resultado = true;
                    this.mensaje = "Bienvenido, Datos Correctos";

                    Reg.Close();
                    nombreEmpleado = nom.ExecuteScalar().ToString();
                }
                else //Si recibe datos nulos se ejecuta este else
                {
                    Msj = "Datos Incorrcetos, Verifique Porfavor";
                }
            }
            else
            {
                Msj = "No tiene autorizado iniciar sesión, comuniquese con el administrador.";
            }

            //Se cierra la base de datos
            sc.Close();

            //Retornamos el valor de resultado para que sea ejecutado en el login
            return Resultado;
        }
    }
}
