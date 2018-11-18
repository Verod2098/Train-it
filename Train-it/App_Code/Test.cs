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

    public Test () {
        Utils.conexion.Close();

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

    public void FillQuestion(int idprueba)
    {
            String sql;
            SqlCommand com;
            SqlDataReader rs;
            Utils.conexion.Open();
            sql = "SELECT * FROM Question where id_test=@id_test and id_question=@id";
            com = Utils.conexion.CreateCommand();
            com.Parameters.AddWithValue("id_test", idprueba);
            com.Parameters.AddWithValue("id", GetRandom());
            com.CommandText = sql;
            rs = com.ExecuteReader();

            if (rs.Read())
            {
               
                Pregunta.preguntatext = rs[1].ToString();
                Pregunta.porcentaje= rs[2].ToString();
                Pregunta.correctAnswer= rs[3].ToString();
                Pregunta.badAnswer1 = rs[4].ToString();
                Pregunta.badAnswer2 = rs[5].ToString();
                Pregunta.badAnswer3 = rs[6].ToString();
                Pregunta.path = rs[8].ToString();
                Pregunta.format = rs[9].ToString();
                Utils.code++;
                ListPregunta.Add(pregunta);
            char Values= '%';
            Pregunta.porcentaje = Pregunta.porcentaje.TrimEnd(Values);
            
            
            }
           
        Utils.conexion.Close();
       
    }



    public void AddTest(int Grade,string Name, int Type, int Time,string Approved,int maxPremium,int maxBasic,int  Price,int  ID) {


        
        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "INSERT INTO  TEST (Grade,Name,Type,Time,Approved,maxPremium,maxBasic,Price,ID) VALUES ( @Grade,@Name,@Type,@Time,@Approved,@maxPremium,@maxBasic,@Price,@ID)";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("Grade", Grade);
        com.Parameters.AddWithValue("Name", Name);
        com.Parameters.AddWithValue("Type", Type);
        com.Parameters.AddWithValue("Time", Time);
        com.Parameters.AddWithValue("Approved", Approved);
        com.Parameters.AddWithValue("maxPremium", maxPremium);
        com.Parameters.AddWithValue("maxBasic", maxBasic);
        com.Parameters.AddWithValue("Price", Price);
        com.Parameters.AddWithValue("ID", ID);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();

    }

    public void UpdateGrade(int newgrade, int id, int test)
    {
        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "UPDATE Record SET Grade=@grade WHERE ID=@id AND id_Test=@test";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("Grade", newgrade);
        com.Parameters.AddWithValue("Id", id);
        com.Parameters.AddWithValue("Test", test);
        com.CommandText = sql;
        com.ExecuteNonQuery();



       Utils. conexion.Close();
    }

    public void newGrade(int porcentaje, int grade)

    {

        Utils.grade = grade + porcentaje;

    }

    public void AddGrade(int id, int test) {

        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "INSERT INTO Record  (Grade,Type,ID,ID_Test) VALUES ( @grade,@type,@id,@test)";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("grade", Utils.grade);
        com.Parameters.AddWithValue("id", id);
        com.Parameters.AddWithValue("test", test);
        com.Parameters.AddWithValue("Type", " ");
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();
        Utils.code++;

    }

    public int GetRandom() {
        int id_pregunta;
        Random rnd = new Random();
      return id_pregunta = rnd.Next(1,10);

    }

    public void deleteTest(int id){
        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "DELETE TEST  WHERE id=@id";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("id", id);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();
    }

    public void updateTest(int Grade, string Name, int Type, int Time, string Approved, int maxPremium, int maxBasic, int Price, int ID) {

        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "Update TEST SET VALUES Grade=@Grade,Name=@Name,Type=@Type,Time=@Time,Approved=@Approved,maxPremium=@maxPremium,maxBasic=@maxBasic,Price=@Price where ID=@ID";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("Grade", Grade);
        com.Parameters.AddWithValue("Name", Name);
        com.Parameters.AddWithValue("Type", Type);
        com.Parameters.AddWithValue("Time", Time);
        com.Parameters.AddWithValue("Approved", Approved);
        com.Parameters.AddWithValue("maxPremium", maxPremium);
        com.Parameters.AddWithValue("maxBasic", maxBasic);
        com.Parameters.AddWithValue("Price", Price);
        com.Parameters.AddWithValue("ID", ID);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();
    }



}