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
    Pregunta pregunta = new Pregunta();

    SqlConnection conexion = new SqlConnection("Data Source = DELL\\SQLEXPRESS;Initial Catalog = TRAINT-IT; User ID = Vero; Password=123");
     public static List< Pregunta> ListPregunta = new List<Pregunta> ();


    public Boolean CorrectAnswer(string answer, string choose)
    {
        Boolean isOk = false;

        if (answer.Equals(choose))
        {
            isOk = true;

        }

        return isOk;

    }

    public void FillQuestion(int idprueba)
    {
            String sql;
            SqlCommand com;
            SqlDataReader rs;
            conexion.Open();
            sql = "SELECT * FROM Pregunta where id_prueba=@Codigo_prueba and id_pregunta=@id";
            com = conexion.CreateCommand();
            com.Parameters.AddWithValue("Codigo_prueba", idprueba);
            com.Parameters.AddWithValue("id", GetRandom());
            com.CommandText = sql;
            rs = com.ExecuteReader();

            if (rs.Read())
            {
               
                Pregunta.preguntatext = rs[1].ToString();
                Pregunta .porcentaje= rs[2].ToString();
                 Pregunta.correctAnswer= rs[3].ToString();
                Pregunta.badAnswer1 = rs[4].ToString();
                Pregunta.badAnswer2 = rs[5].ToString();
                Pregunta.badAnswer3 = rs[6].ToString();
                Pregunta.path = rs[8].ToString();
                Pregunta.format = rs[9].ToString();
                Utils.code++;
                ListPregunta.Add(pregunta);
            
            }
           
        conexion.Close();
       
    }


    public void UpdateGrade(int newgrade, int id, int prueba)
    {
        String sql;
        SqlCommand com;
        conexion.Open();
        sql = "UPDATE HISTORIAL SET Nota=@nota WHERE ID=@cedula AND id_Prueba=@prueba";
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

    public void AddGrade(int id, int prueba) {

        String sql;
        SqlCommand com;
        conexion.Open();
        sql = "INSERT INTO HISTORIAL  (Nota,Tipo,ID,ID_Prueba) VALUES (@nota,@tipo,@cedula,@prueba)";
        com = conexion.CreateCommand();
        com.Parameters.AddWithValue("nota", Utils.grade);
        com.Parameters.AddWithValue("cedula", id);
        com.Parameters.AddWithValue("prueba", prueba);
        com.Parameters.AddWithValue("Tipo", " ");
        com.CommandText = sql;
        com.ExecuteNonQuery();

        conexion.Close();
        Utils.code++;

    }

    public int GetRandom() {
        int id_pregunta;
        Random rnd = new Random();
      return id_pregunta = rnd.Next(1,10);

    }

    public override string ToString()
    {
        return pregunta.ToString();
    }




}