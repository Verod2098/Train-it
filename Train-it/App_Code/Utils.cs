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
    public static int maxpregunta;
    public static int id;
    public static int id_prueba;
    public static string req;
    public static int grade=0;
       public static Boolean isfull;
    public static int code = 0;

   //USer
    public static string nombre;
    public static int cedula=1;
    public static string tel;
    public static string fecha;
    public static string lugar;
    public static string ocupacion;
    public static string tipo;
    public static string correo;


    //String de conexion 
    public static SqlConnection conexion = new SqlConnection("Data Source = DELL\\SQLEXPRESS;Initial Catalog = TRAINT-IT; User ID = Vero; Password=123");

    public static List<Pregunta> ListPregunta = new List<Pregunta>();
}
