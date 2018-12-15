using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

/// <summary>
/// Descripción breve de MailService
/// </summary>
public class MailService
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
}