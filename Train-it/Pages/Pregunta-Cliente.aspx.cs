using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pregunta_Cliente : System.Web.UI.Page
{
    Test test = new Test();
    Pregunta Pregunta = new Pregunta();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!Utils.isfull)
        {
            UpdatePanel1.Update();
            test.FillQuestion(int.Parse(Session["id_prueba"].ToString()));
            LblPregunta.Text = Pregunta.preguntatext.ToString();
            FillButton();
            Utils.isfull = true;
            
        }
    }


    private void FillButton()
    {
        try
        {
            Random random = new Random();
            int right = (int)random.Next(1, 4);
            if (right == 1)
            {
                Button_Q1.Text = Pregunta.correctAnswer;
                Button_Q2.Text = Pregunta.badAnswer1;
                Button_Q3.Text = Pregunta.badAnswer2;
                Button_Q4.Text = Pregunta.badAnswer3;

            }
            else if (right == 2)
            {
                Button_Q1.Text = Pregunta.badAnswer1;
                Button_Q2.Text = Pregunta.correctAnswer;
                Button_Q3.Text = Pregunta.badAnswer2;
                Button_Q4.Text = Pregunta.badAnswer3;
            }
            else if (right == 3)
            {
                Button_Q1.Text = Pregunta.badAnswer1;
                Button_Q2.Text = Pregunta.badAnswer2;
                Button_Q3.Text = Pregunta.correctAnswer;
                Button_Q4.Text = Pregunta.badAnswer3;
            }
            else if (right == 4)
            {
                Button_Q1.Text = Pregunta.badAnswer1;
                Button_Q2.Text = Pregunta.badAnswer2;
                Button_Q3.Text = Pregunta.badAnswer3;
                Button_Q4.Text = Pregunta.correctAnswer;
            }


        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
        }

    }





    protected void Button_Q1_Click(object sender, EventArgs e)
    {
        try
        {
            if (test.CorrectAnswer(Pregunta.correctAnswer, Button_Q1.Text))
            {
                test.newGrade(int.Parse (Pregunta.porcentaje), Utils.grade);
                test.UpdateGrade(Utils.grade, Utils.cedula, int.Parse(Session["id_prueba"].ToString()));
            }
            if (Utils.code<Utils.maxpregunta)
            {
                test.FillQuestion(int.Parse(Session["id_prueba"].ToString()));
                UpdatePanel1.Update();
                LblPregunta.Text = Pregunta.preguntatext.ToString();
                FillButton();
            }
            else
            {
                Response.Redirect("Nota-cliente.aspx", false);
            }

        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
        }

    }

    protected void Button_Q2_Click(object sender, EventArgs e)
    {
        try
        {
            if (test.CorrectAnswer(Pregunta.correctAnswer, Button_Q2.Text))
            {
                test.newGrade(int.Parse (Pregunta.porcentaje), Utils.grade);
                test.UpdateGrade(Utils.grade, Utils.cedula, int.Parse(Session["id_prueba"].ToString()));
            }
            if (Utils.code <Utils.maxpregunta)
            {
                test.FillQuestion(int.Parse(Session["id_prueba"].ToString()));
                UpdatePanel1.Update();
                LblPregunta.Text = Pregunta.preguntatext.ToString();
                FillButton();
            }
            else
            {
                Response.Redirect("Nota-cliente.aspx", false);
            }

        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
        }

    }

    protected void Button_Q3_Click(object sender, EventArgs e)
    {
        try
        {
            if (test.CorrectAnswer(Pregunta.correctAnswer, Button_Q3.Text))
            {
                test.newGrade(int.Parse (Pregunta.porcentaje), Utils.grade);
                test.UpdateGrade(Utils.grade, Utils.cedula, int.Parse(Session["id_prueba"].ToString()));
            }
            if (Utils.code < Utils.maxpregunta)
            {
                test.FillQuestion(int.Parse(Session["id_prueba"].ToString()));
                UpdatePanel1.Update();
                LblPregunta.Text = Pregunta.preguntatext.ToString();
                FillButton();
            }
            else
            {
                Response.Redirect("Nota-cliente.aspx", false);
            }

        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
        }

    }

    protected void Button_Q4_Click(object sender, EventArgs e)
    {
        try
        {
            if (test.CorrectAnswer(Pregunta.correctAnswer, Button_Q4.Text))
            {
                test.newGrade(int.Parse (Pregunta.porcentaje), Utils.grade);
                test.UpdateGrade(Utils.grade,Utils.cedula, int.Parse(Session["id_prueba"].ToString()));
            }
            if (Utils.code < Utils.maxpregunta)
            {
                test.FillQuestion(int.Parse(Session["id_prueba"].ToString()));
                UpdatePanel1.Update();
                LblPregunta.Text = Pregunta.preguntatext.ToString();
                FillButton();
            }
            else
            {
                Response.Redirect("Nota-cliente.aspx", false);
            }

        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
        }

    }
}
