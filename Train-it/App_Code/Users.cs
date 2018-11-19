using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;

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

    
    public Users()
    {
       
    }

   public void updateClient(string name,string mail,string job,string place,string phone) {

         String sql;
         SqlCommand com;
         Utils.conexion.Open();
         sql = "UPDATE Usuario SET Name=@name,Phone_Number=@phone,Place_Occupation=@place,Occupation=@job, Email=@mail WHERE Id=@id ";
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
        sql = "select * from  User where Id=@Id";
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
        sql = " INSERT INTO [USER]  (id,Name,Mail,Occupation,Place_Occupation,Phone_Number,Rol,Specialty,Type,Birthdate,Password) VALUES " +
            "(@id,@Name,@Mail,@Occupation,@place_Occupation,@Phone_Number,@Rol,@Specialty,@Type,@Bithdate,@Password) ";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("Name", name);
        com.Parameters.AddWithValue("Phone_Number", phone);
        com.Parameters.AddWithValue("place_Occupation", place);
        com.Parameters.AddWithValue("Occupation", job);
        com.Parameters.AddWithValue("Mail", mail);
        com.Parameters.AddWithValue("id", id);
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
        sql = "SELECT Id,Type,rol FROM [User] where Mail=@correo AND Password=@contrasena";
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
                isReal = true;
           

        }
        Utils.conexion.Close();
        return isReal;

    }
}
