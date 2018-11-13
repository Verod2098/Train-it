﻿using System;
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



    public void addTopicQuestion(int id, string topic ) {

        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "INSERT INTO  Topic_Question (Topic,ID) VALUES ( @topic,@id)";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("topic", topic);
        com.Parameters.AddWithValue("id", id);
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
}