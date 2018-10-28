using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Users
/// </summary>
public class Users
{

    SqlConnection conexion = new SqlConnection("Data Source = DELL\\SQLEXPRESS;Initial Catalog = TRAINT-IT; User ID = Vero; Password=123");

    
    public Users()
    {
       
    }

   public void updateClient(string name,string mail,string job,string place,string phone) {

         String sql;
         SqlCommand com;
         conexion.Open();
         sql = "UPDATE Usuario SET Nombre=@name,Numero_Telefono=@phone,Lugar_Ocupacion=@place,Ocupacion=@job, Email=@mail WHERE Cedula=@cedula ";
         com = conexion.CreateCommand();
         com.Parameters.AddWithValue("name", name);
         com.Parameters.AddWithValue("phone", phone);
        com.Parameters.AddWithValue("place", place);
        com.Parameters.AddWithValue("job", job);
        com.Parameters.AddWithValue("mail", mail);
        com.Parameters.AddWithValue("cedula", Utils.cedula);
        com.CommandText = sql;
         com.ExecuteNonQuery();

     } 


    

    public bool searchUser( int id) {

        Boolean isReal = false;
        String sql;
        SqlCommand com;
        SqlDataReader rs;
        conexion.Open();
        sql = "select * from  Usuario where Cedula=@Cedula";
        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.Parameters.AddWithValue("Cedula", id);

        rs = com.ExecuteReader();

        if (rs.Read())
        {
            Utils.nombre = rs[1].ToString();
            Utils.tel = rs[2].ToString();
            Utils.lugar = rs[3].ToString();
            Utils.ocupacion = rs[4].ToString();
            Utils.correo = rs[5].ToString();
            Utils.tipo = rs[6].ToString();
            Utils.fecha = rs[8].ToString();
            isReal = true;

        }
        
        conexion.Close();
        return isReal;
    }


    public void insertPreferences(int id, string prueba)
    {
        String sql;
        SqlCommand com;
        conexion.Open();
        sql = "INSERT INTO PREFERENCIAS(ID_Usuario, ID_PRUEBA) VALUES(@cedula, (SELECT CODIGO FROM TEMA_PRUEBA WHERE TEMA =@Prueba)); ";
        com = conexion.CreateCommand();
        com.Parameters.AddWithValue("cedula", id);
        com.Parameters.AddWithValue("prueba", prueba);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        conexion.Close();
      
    }
}
