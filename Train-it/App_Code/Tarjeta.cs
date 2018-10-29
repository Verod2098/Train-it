using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Tarjeta
/// </summary>
public class Tarjeta
{
    public static string nombre;
    public static string  Numero_Tarjeta;
    public static string CVV;
    public static string Tipo;
    public static string Fecha_Vencimiento;
    SqlConnection conexion = new SqlConnection("Data Source = DELL\\SQLEXPRESS;Initial Catalog = TRAINT-IT; User ID = Vero; Password=123");

    public Tarjeta()
    {
        
    }



    public void addCreditCard(string nombre,string numero_tarjeta,string cod_seguridad,string tipo, string Fecha_vencimiento) {


        String sql;
        SqlCommand com;
        conexion.Open();
        sql = "INSERT INTO Tarjeta  (Nombre,Numero_Tarjeta,Cod_seguridad,Tipo,Fecha_Vencimiento) VALUES (@Nombre,@Numero_Tarjeta,@Cod_seguridad,@Tipo,@Fecha_vencimiento)";
        com = conexion.CreateCommand();
        com.Parameters.AddWithValue("Nombre", nombre);
        com.Parameters.AddWithValue("Numero_Tarjeta", numero_tarjeta);
        com.Parameters.AddWithValue("cod_seguridad", cod_seguridad);
        com.Parameters.AddWithValue("Tipo", tipo);
        com.Parameters.AddWithValue("Fecha_vencimiento", Fecha_vencimiento);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        conexion.Close();

    }


    public void upgradeAccount(string Tarjeta, int id) {

        String sql;
        SqlCommand com;
        conexion.Open();
        sql = "UPDATE Usuario SET Tarjeta=@tarjeta, Tipo=@Tipo WHERE cedula=@cedula ";
        com = conexion.CreateCommand();
        com.Parameters.AddWithValue("tarjeta", Tarjeta);
        com.Parameters.AddWithValue("cedula", id);
        com.Parameters.AddWithValue("Tipo", "Premium");
        com.CommandText = sql;
        com.ExecuteNonQuery();


    }
}