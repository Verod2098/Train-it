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

    /* public void updateClient(int id,string name,string date,string mail) {

         String sql;
         SqlCommand com;
         conexion.Open();
         sql = "UPDATE Usuario SET  WHERE cedula_cliente=@cedula AND codigo_Prueba=@prueba";
         com = conexion.CreateCommand();
         com.Parameters.AddWithValue("nota", newgrade);
         com.Parameters.AddWithValue("cedula", id);
         com.Parameters.AddWithValue("prueba", prueba);
         com.CommandText = sql;
         com.ExecuteNonQuery();

     } 


    */

    public bool searchUser( int id) {

        Boolean isReal = false;
        String sql;
        SqlCommand com;
        SqlDataReader rs;
        conexion.Open();
        sql = "select * from  Ususario where Cedula=@Cedula";
        com = conexion.CreateCommand();
        com.CommandText = sql;
        com.Parameters.AddWithValue("Cedula", id);

        rs = com.ExecuteReader();

        if (rs.Read())
        {
            Utils.nombre = rs[1].ToString();
            Utils.tel = int.Parse(rs[2].ToString());
            Utils.lugar = rs[3].ToString();
            Utils.ocupacion = rs[4].ToString();
            Utils.correo = rs[5].ToString();
            Utils.tipo = rs[7].ToString();
            Utils.fecha = rs[9].ToString();
            isReal = true;

        }
        
        conexion.Close();
        return isReal;
    }
}