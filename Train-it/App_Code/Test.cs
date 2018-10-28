using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Esta clase contiene todos los metodos relacionados al examen
/// </summary>
public class Test
{



    public Test()
    {
        using (var db = new Train_itEntities())
        {
            var result = db.Preferencias.Where(c => c.active == true).ToList();
        }
    }


    public Boolean CorrectAnswer(string answer, string choose)
    {
        Boolean isOk = false;

        if (answer.Equals(choose))
        {
            isOk = true;

        }

        return isOk;

    }

    public Boolean FillQuestion(int idprueba)
    {
        Boolean isQuestion = true;
        while (Utils.code < Utils.maxpregunta) //Para el limite de las preguntas 
        {
           
            String sql;
            SqlCommand com;
            SqlDataReader rs;

            conexion.Open();
            sql = "SELECT * FROM Pregunta where Codigo_prueba=@Codigo_prueba";
            com = conexion.CreateCommand();
            com.Parameters.AddWithValue("Codigo_prueba", idprueba);
            com.CommandText = sql;
            rs = com.ExecuteReader();

            if (rs.Read())
            {
                Utils.pregunta = rs[1].ToString();
                Utils.Porcentaje = int.Parse(rs[6].ToString());
                Utils.CorrectAnswer = rs[5].ToString();
                Utils.BadAnswer1 = rs[2].ToString();
                Utils.BadAnswer2 = rs[3].ToString();
                Utils.BadAnswer3 = rs[4].ToString();
                Utils.code++;


            }
            else
            {
                isQuestion = false;
            }
            

        }
        conexion.Close();
        return isQuestion;
    }


    public void addGrade(int newgrade, int id, int prueba)
    {
        String sql;
        SqlCommand com;
        conexion.Open();
        sql = "UPDATE Historico SET Nota=@nota WHERE cedula=@cedula AND id_Prueba=@prueba";
        com = conexion.CreateCommand();
        com.Parameters.AddWithValue("nota", newgrade);
        com.Parameters.AddWithValue("cedula", id);
        com.Parameters.AddWithValue("prueba", prueba);
        com.CommandText = sql;
        com.ExecuteNonQuery();



        conexion.Close();
    }

    public void newGrade(int porcentaje, int grade)

    {

        Utils.grade = grade + porcentaje;

    }



}