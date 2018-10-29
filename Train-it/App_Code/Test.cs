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
            sql = "SELECT * FROM Pregunta where Codigo_prueba=@Codigo_prueba and id_pregunta=@id";
            com = conexion.CreateCommand();
            com.Parameters.AddWithValue("Codigo_prueba", idprueba);
            com.Parameters.AddWithValue("id", GetRandom());
            com.CommandText = sql;
            rs = com.ExecuteReader();

            if (rs.Read())
            {
                Pregunta pregunta = new Pregunta();
                pregunta.Preguntatext = rs[1].ToString();
                Pregunta .porcentaje= int.Parse(rs[2].ToString());
                 pregunta.CorrectAnswer= rs[3].ToString();
                pregunta.BadAnswer1 = rs[4].ToString();
                pregunta.BadAnswer2 = rs[5].ToString();
                pregunta.BadAnswer3 = rs[6].ToString();
                pregunta.Path = rs[8].ToString();
                pregunta.Format = rs[9].ToString();
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
      return id_pregunta = rnd.Next(10);

    }


  

}