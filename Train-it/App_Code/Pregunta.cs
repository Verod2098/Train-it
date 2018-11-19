using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Pregunta
/// </summary>
public class Pregunta
{



    public static string preguntatext;
    public static string correctAnswer;
    public static string badAnswer1;
    public static string badAnswer2;
    public static string badAnswer3;
    public static string porcentaje;
    public static Byte[] image = new byte[10];

    

    public Pregunta()
    {
        
    }

    public override string ToString()
    {
        return "   Pregunta: "  + preguntatext.ToString() +  "  Respuesta:  "+ correctAnswer.ToString() + "   " ;

    }


    public void addQuestion(string Question, string Percentaje, string Correct_Answer, string Bad_Answer1, string Bad_Answer2, string Bad_Answer3, string Type_Question, byte[] image, int ID_TEST, int ID_Topic, int ID, int ID_Creator) {

        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "INSERT INTO  Question (Question,Percentaje,Correct_Answer,Bad_Answer1,Bad_Answer2,Bad_Answer3,Type_Question,Image,ID_TEST,ID_Topic,id_Questions,ID_Creator) VALUES (@Question,@Percentaje,@Correct_Answer,@Bad_Answer1,@Bad_Answer2,@Bad_Answer3,@Type_Question,@Image,@ID_TEST,@ID_Topic,@ID,@ID_Creator)";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("Question", Question);
        com.Parameters.AddWithValue("Percentaje", Percentaje);
        com.Parameters.AddWithValue("Correct_Answer", Correct_Answer);
        com.Parameters.AddWithValue("Bad_Answer1", Bad_Answer1);
        com.Parameters.AddWithValue("Bad_Answer2", Bad_Answer2);
        com.Parameters.AddWithValue("Bad_Answer3", Bad_Answer3);
        com.Parameters.AddWithValue("Type_Question", Type_Question);
        com.Parameters.AddWithValue("Image",image);
        com.Parameters.AddWithValue("ID_Creator", ID_Creator);
        com.Parameters.AddWithValue("ID_Topic", ID_Topic);
        com.Parameters.AddWithValue("ID", ID);
        com.Parameters.AddWithValue("ID_TEST", ID_TEST);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();
    }


    public void updateQuestion(string Question,string Percentaje,string Correct_Answer,string Bad_Answer1,string Bad_Answer2,string Bad_Answer3,string Type_Question,byte [] image,int ID_TEST,int ID_Topic,int ID,int ID_Creator) {

        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "Update Question SET  Question=@Question,Percentaje=@Percentaje,Correct_Answer=@Correct_Answer,Bad_Answer1=@Bad_Answer1,Bad_Answer2=@Bad_Answer2,Bad_Answer3=@Bad_Answer3,Type_Question=@Type_Question,Image=@image,ID_Creator=@ID_Creator,ID_Topic=@ID_Topic,ID_TEST=@ID_TEST where id_Questions=@ID";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("Question", Question);
        com.Parameters.AddWithValue("Percentaje", Percentaje);
        com.Parameters.AddWithValue("Correct_Answer", Correct_Answer);
        com.Parameters.AddWithValue("Bad_Answer1", Bad_Answer1);
        com.Parameters.AddWithValue("Bad_Answer2", Bad_Answer2);
        com.Parameters.AddWithValue("Bad_Answer3", Bad_Answer3);
        com.Parameters.AddWithValue("Type_Question", Type_Question);
        com.Parameters.AddWithValue("image", image);
        com.Parameters.AddWithValue("ID_Creator", ID_Creator);
        com.Parameters.AddWithValue("ID_Topic",ID_Topic);
        com.Parameters.AddWithValue("ID", ID);
        com.Parameters.AddWithValue("ID_TEST", ID_TEST);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();


    }

    public void deleteQuestion (int id ) {

        String sql;
        SqlCommand com;
        Utils.conexion.Open();
        sql = "DELETE Question  WHERE id_questions=@id";
        com = Utils.conexion.CreateCommand();
        com.Parameters.AddWithValue("id", id);
        com.CommandText = sql;
        com.ExecuteNonQuery();

        Utils.conexion.Close();

    }
}