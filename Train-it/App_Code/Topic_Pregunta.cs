using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Topic_Pregunta
/// </summary>
public class Topic_Pregunta
{
    public Topic_Pregunta()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public static int Id { get; set; }
    public static string Topic { get; set; }



    public void addTopicQuestion( string topic ) {

        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "INSERT INTO  Topic_Question (Topic) VALUES ( @topic)";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("topic", topic);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();
       

    }

    public void updateTopicQuestion(int id,string topic){

        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "UPDATE  Topic_Question SET Topic=@topic WHERE id=@id";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("topic", topic);
        com.Parameters.AddWithValue("id",id);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();

    }

    public void deleteTopicQuestion(int id) {

        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "DELETE Topic_Question  WHERE id=@id";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("id", id);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();

    }

    public void searchTopic(int id)
    {

        String sql;
        SqlCommand com;
        SqlDataReader rs;
        Utils.conexion.Open();
        sql = "select Topic from Topic_Question where ID=@Id";
        com = Utils.conexion.CreateCommand();
        com.CommandText = sql;
        com.Parameters.AddWithValue("Id", id);

        rs = com.ExecuteReader();

        if (rs.Read())
        {
            Topic = rs[0].ToString();

        }

        Utils.conexion.Close();



    }
}