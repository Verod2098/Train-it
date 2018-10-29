using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Pregunta
/// </summary>
public class Pregunta
{



    private string preguntatext;
    private string correctAnswer;
    private string badAnswer1;
    private string badAnswer2;
    private string badAnswer3;
    private string path;
    private string format;
    public static int porcentaje;

    public string Preguntatext { get => preguntatext; set => preguntatext = value; }
    public string CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
    public string BadAnswer1 { get => badAnswer1; set => badAnswer1 = value; }
    public string BadAnswer2 { get => badAnswer2; set => badAnswer2 = value; }
    public string BadAnswer3 { get => badAnswer3; set => badAnswer3 = value; }
    public string Path { get => path; set => path = value; }
    public string Format { get => format; set => format = value; }
    public static int Porcentaje { get => porcentaje; set => porcentaje = value; }

    public Pregunta()
    {
       
    }


}