using System;
using System.Collections.Generic;
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
    public static string path;
    public static string format;
    public static string porcentaje;

    

    public Pregunta()
    {
       
    }

    public override string ToString()
    {
        return "Pregunta: "  + preguntatext +  "Respuesta:  "+ correctAnswer + "  ";

    }



}