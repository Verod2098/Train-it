using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TrainIt.Cli
{
    class Program
    {

        public static void EnviarCorreo(string emailDelReceptor, string tituloDelCorreo, string mensaje)
        {

            SmtpClient ServerMail = new SmtpClient
            {
                Credentials = new NetworkCredential("soportetrainit@gmail.com", "Admin123."),
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true
            };
            try
            {
                ServerMail.Send(
                    "soportetrainit@gmail.com",
                    emailDelReceptor,
                    tituloDelCorreo,
                    mensaje
                    );
                Console.Out.WriteLine("Se mando el correo!");
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.StackTrace);
                Console.In.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            EnviarCorreo("ale.alvarez97@hotmail.com", "Cambio de Contraseña", "Hola!");
            EnviarCorreo("ale.alvarez97@hotmail.com", "Hola :)", "Hola");
        }
    }
}
