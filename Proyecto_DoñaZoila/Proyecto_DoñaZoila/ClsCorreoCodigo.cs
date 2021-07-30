using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_DoñaZoila
{
    class ClsCorreoCodigo:ClsConexionBD
    {
        //Clases
        Random rand = new Random();
        MailMessage message = new MailMessage();

        //Atributos
        private string codigoRandom;
        private static string to;
        private SqlCommand comandosql;
        private string sql;

        //MetodoConstructor
        public ClsCorreoCodigo()
        {
            this.sql = string.Empty;
        }

        //Encapsulamiento
        public string CodigoRandom { get => codigoRandom; set => codigoRandom = value; }
        public string To1 { get => to; set => to = value; }

        //Validación correo en la base de datos
        public bool VerificarCorreo()
        {
            bool var;

            sc.Open();

            this.sql = string.Format(@"select correoElectronico from Empleado where correoElectronico = '" + to + "'");

            this.comandosql = new SqlCommand(this.sql, this.sc);

            SqlDataReader Reg = null;

            Reg = this.comandosql.ExecuteReader();

            if (Reg.Read())
            {
                var = true;
            }
            else
            {
                var = false;
            }

            sc.Close();

            return var;
        }

        //Enviar el codigo al correo
        public bool Enviar()
        {
            bool var;
            String from, password, messageBody;

            codigoRandom = (rand.Next(999999)).ToString();

            from = "rbforeign88@gmail.com";
            password = "Lagarto123";

            messageBody = "¡ Hola usuario ! \nSe ha solicitado un codigo para poder cambiar de contraseña, " +
                "tu codigo para que puedas cambiar de contraseña es el siguiente: \n" + codigoRandom +
                "."+"\nTen un lindo día.";

            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Codigo para cambio de contraseña";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, password);
            try
            {
                smtp.Send(message);

                var = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

                var = false;
            }

            return var;
        }
    }
}
