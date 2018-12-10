using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Net.Mail;


/// <summary>
/// Summary description for Users
/// </summary>
public class Users
{

    public static string nombre;
    public static int id;
    public static string tel;
    public static string fecha;
    public static string lugar;
    public static string ocupacion;
    public static string tipo;
    public static string correo;
    public static string rol;
    public static string password;
    public static string  Status;

    private string mensaje;
    private SqlCommand comando = new SqlCommand();
    SqlConnection conexion = new SqlConnection("Data Source = DELL\\SQLEXPRESS;Initial Catalog = TRAINT-IT; User ID = Vero; Password=123");
    private SqlDataReader leer;

    public Users()
    {
       
    }

   public void updateClient(string name,string mail,string job,string place,string phone,int id) {

         String sql;
         SqlCommand com;
         Utils.conexion.Open();
         sql = "UPDATE [User] SET Name=@name,Phone_Number=@phone,Place_Occupation=@place,Occupation=@job, mail=@mail WHERE Id=@id ";
         com = Utils.conexion.CreateCommand();
         com.Parameters.AddWithValue("name", name);
         com.Parameters.AddWithValue("phone", phone);
        com.Parameters.AddWithValue("place", place);
        com.Parameters.AddWithValue("job", job);
        com.Parameters.AddWithValue("mail", mail);
        com.Parameters.AddWithValue("id", id);
        com.CommandText = sql;
         com.ExecuteNonQuery();
        Utils.conexion.Close();

     } 



    public bool searchUser( int id) {

        Boolean isReal = false;
        String sql;
        SqlCommand com;
        SqlDataReader rs;
       Utils. conexion.Open();
        sql = "select * from  [User] where Id=@Id";
        com = Utils.conexion.CreateCommand();
        com.CommandText = sql;
        com.Parameters.AddWithValue("Id", id);

        rs = com.ExecuteReader();

        if (rs.Read())
        {
            nombre = rs[1].ToString();
            tel = rs[2].ToString();
            lugar = rs[3].ToString();
            ocupacion = rs[4].ToString();
           correo = rs[5].ToString();
            tipo = rs[6].ToString();
           fecha = rs[8].ToString();
            isReal = true;
          //  Status = int.Parse(rs[12].ToString());


        }
        
        Utils.conexion.Close();
        return isReal;
    }


    public void insertPreferences(int id, string test)
    {
        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "INSERT INTO PREFERENCES(ID_User, ID_TEST) VALUES(@id, (SELECT ID FROM TOPIC_TEST WHERE TOPIC =@Test)); ";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("id", id);
        com.Parameters.AddWithValue("test", test);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();
      
    }

    //https://www.codeproject.com/Articles/5189/End-to-end-Email-Address-Verification-for-Applicat
    public void isMailReal(string mail) {

        try
        {
            string[] host = (mail.Split('@'));
            string hostname = host[1];

            IPHostEntry IPhst = Dns.Resolve(hostname);
            IPEndPoint endPt = new IPEndPoint(IPhst.AddressList[0], 25);
            Socket s = new Socket(endPt.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp);
            s.Connect(endPt);
        }
        catch (Exception e) {

            Console.Write("El correo no es Válido" + e);

        }


    }


    public void addUser(int id,string name, string mail, string job, string place, string phone,string Rol,int Specialty,string type,string birthdate,string password) {
        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = " INSERT INTO [USER]  (id,Name,Mail,Occupation,Place_Occupation,Phone_Number,Rol,Specialty,Type,Birthdate,Password,Status) VALUES " +
            "(@id,@Name,@Mail,@Occupation,@place_Occupation,@Phone_Number,@Rol,@Specialty,@Type,@Bithdate,@Password,@Status) ";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("Name", name);
        com.Parameters.AddWithValue("Phone_Number", phone);
        com.Parameters.AddWithValue("place_Occupation", place);
        com.Parameters.AddWithValue("Occupation", job); 
        com.Parameters.AddWithValue("Mail", mail);
        com.Parameters.AddWithValue("id", id);
        com.Parameters.AddWithValue("Status","true");
       
        if (Specialty == 0)
        {
            com.Parameters.AddWithValue("Specialty", DBNull.Value);
        }
        else {
            com.Parameters.AddWithValue("Specialty", Specialty);
        }
        
        com.Parameters.AddWithValue("Type", type);
        com.Parameters.AddWithValue("Rol", Rol);
        com.Parameters.AddWithValue("Bithdate", birthdate);
        com.Parameters.AddWithValue("Password", password);
        
        com.CommandText = sql;
        com.ExecuteNonQuery();
        Utils.conexion.Close();
    }


    public Boolean searchclient(string correo, string contrasena)
    {
        Boolean isReal = false;
        String sql;
        SqlCommand com;
        SqlDataReader rs;

        Utils.conexion.Open();
        sql = "SELECT Id,Type,rol,Status FROM [User] where Mail=@correo AND Password=@contrasena";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("correo", correo);
        com.Parameters.AddWithValue("contrasena", contrasena);
        com.CommandText = sql;
        rs = com.ExecuteReader();

        if (rs.Read())
        {
            
                tipo = rs[1].ToString();
                rol = rs[2].ToString();
                id = int.Parse(rs[0].ToString());
                Status = rs[3].ToString();
                isReal = true;
           

        }
        Utils.conexion.Close();
        return isReal;

    }


    public String msjPassword(int id) {
        String msj;

        searchUser(id);
        msj = "Estimado: " + nombre + " Su Contraseña es:  " + password;

        return msj;

    }

    public void mail()
    {
        MailMessage correo = new MailMessage();



    }


    public Boolean noActive(int id) {

        Boolean isSuccesful = true;
        try
        {
           
            String sql;
            SqlCommand com;
            Utils.conexion.Open();
            sql = "UPDATE [User] SET Status=@Status WHERE Id=@id ";
            com = Utils.conexion.CreateCommand();
            com.Parameters.AddWithValue("Status", "false");
            com.Parameters.AddWithValue("id", id);
            com.CommandText = sql;
            com.ExecuteNonQuery();
            Utils.conexion.Close();


         

        }
        catch (Exception e) {
            Console.WriteLine(e.ToString());
            isSuccesful = false;
        }
        return isSuccesful;
    }

    public  String RecuperarPassword(string id)
    {
        comando.Connection = conexion.Open();
        comando.CommandText = "Select * from usuarios where id = " Users.id;
        leer = comando.ExecuteReader();
        if (leer.Read() == true)
        {
            Users.correo = leer["Mail"].ToString();
            Users.nombre = leer["Nombre"].ToString();
            Users.password = leer["password"].ToString();
            EnviarCorreo();
            mensaje = "Estimado " + Users.nombre + ", se ha enviado la contraseña a su correo: " + Users.correo + " verifique su bandeja de entrada";
            leer.Close();
        }
        else
        {
            mensaje = "No existen datos en el sistema";
        }
        return mensaje;
    }

    public void EnviarCorreo()
    {
        MailMessage Correo = new MailMessage();
        Correo.From = new MailAddress("soporteTrainit@gmail.com");
        Correo.To.Add(Users.correo);
        Correo.Subject = ("RECUPERAR CONTRASEÑA SYSTEM");
        Correo.Body = "Hola, " + Users.nombre + "Usted solicitó recuperar su contraseña.\n Su contraseña es: " + Users.password;
        Correo.Priority = MailPriority.High;

        SmtpClient ServerMail = new SmtpClient();
        ServerMail.Credentials = new NetworkCredential("soporteTrainit@gmail.com", "@admin123");
        ServerMail.Host = "smtp@gmail.com";
        ServerMail.Port = 587;
        ServerMail.EnableSsl = true;
        try
        {
            ServerMail.Send(Correo);
        }
        catch (Exception e)
        {
        }
        Correo.Dispose();

    }

}
