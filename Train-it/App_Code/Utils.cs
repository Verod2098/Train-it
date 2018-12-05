using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Contiene todas las variables estaticas del sistema 
/// </summary>
public class Utils
{
    //Examen 
    public static int maxpreguntaPremium;
    public static int maxpreguntaBasic;
    public static int id;
    public static int id_prueba;
    public static int approved;
    public static int grade=0;
    public static Boolean isfull;
    public static int code = 0;
    public static int price;
    public static string name;
    public static int type;
    public static string time;
    public static int maxpregunta;



    //String de conexion 
    public static SqlConnection conexion = new SqlConnection("Data Source = DELL\\SQLEXPRESS;Initial Catalog = TRAINT-IT; User ID = Vero; Password=123");

    public static List<Pregunta> ListPregunta = new List<Pregunta>();
}
