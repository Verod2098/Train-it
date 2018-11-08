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



    public void addCreditCard(string name,string card_number,string CVV,string type, string Expiration_Date) {


        String sql;
        SqlCommand com;
        conexion.Open();
        sql = "INSERT INTO CreditCard  (Name,Card_Number,CVV,Type,Expiration_Date) VALUES (@Name,@NCard_Number,@CVV,@Type,@Expiratio_Date)";
        com = conexion.CreateCommand();
        com.Parameters.AddWithValue("Name", name);
        com.Parameters.AddWithValue("Card_Number", card_number);
        com.Parameters.AddWithValue("CVV", CVV);
        com.Parameters.AddWithValue("Type", type);
        com.Parameters.AddWithValue("Expiration_Date", Expiration_Date);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        conexion.Close();

    }


    public void upgradeAccount(string CreditCard, int id) {

        String sql;
        SqlCommand com;
        conexion.Open();
        sql = "UPDATE User SET creditCard=@creditcard, Type=@Type WHERE id=@id ";
        com = conexion.CreateCommand();
        com.Parameters.AddWithValue("creditCard", CreditCard);
        com.Parameters.AddWithValue("Id", id);
        com.Parameters.AddWithValue("Type", "Premium");
        com.CommandText = sql;
        com.ExecuteNonQuery();


    }
}