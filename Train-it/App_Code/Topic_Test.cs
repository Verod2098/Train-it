using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Topic_Test
/// </summary>
public class Topic_Test
{
    public Topic_Test()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public static int Id { get; set; }
    public static string Topic { get; set; }

    public void addTopicTest(int id, string topic)
    {

        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "INSERT INTO  Topic_TEST (Topic,ID) VALUES ( @topic,@id)";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("topic", topic);
        com.Parameters.AddWithValue("id", id);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();


    }

    public void updateTopicTest(int id, string topic)
    {

        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "UPDATE  Topic_TEST SET Topic=@topic WHERE id=@id";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("topic", topic);
        com.Parameters.AddWithValue("id", id);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();

    }

    public void deleteTopicTest(int id)
    {

        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "DELETE Topic_TEST  WHERE id=@id";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("id", id);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();

    }



}