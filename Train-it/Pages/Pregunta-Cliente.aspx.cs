using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pregunta_Cliente : System.Web.UI.Page
{
    Test test = new Test();
    Pregunta pregunta = new Pregunta();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Utils.isfull)
        {
            UpdatePanel1.Update();
            test.FillQuestion(int.Parse(Session["id_prueba"].ToString()));
            test.AddGrade(int.Parse(Session["User_id"].ToString()), int.Parse(Session["id_prueba"].ToString()));
            LblPregunta.Text = pregunta.Preguntatext.ToString();
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
                Button_Q1.Text = pregunta.CorrectAnswer;
                Button_Q2.Text = pregunta.BadAnswer1;
                Button_Q3.Text = pregunta.BadAnswer2;
                Button_Q4.Text = pregunta.BadAnswer3;

            }
            else if (right == 2)
            {
                Button_Q1.Text = pregunta.BadAnswer1;
                Button_Q2.Text = pregunta.CorrectAnswer;
                Button_Q3.Text = pregunta.BadAnswer2;
                Button_Q4.Text = pregunta.BadAnswer3;
            }
            else if (right == 3)
            {
                Button_Q1.Text = pregunta.BadAnswer1;
                Button_Q2.Text = pregunta.BadAnswer2;
                Button_Q3.Text = pregunta.CorrectAnswer;
                Button_Q4.Text = pregunta.BadAnswer3;
            }
            else if (right == 4)
            {
                Button_Q1.Text = pregunta.BadAnswer1;
                Button_Q2.Text = pregunta.BadAnswer2;
                Button_Q3.Text = pregunta.BadAnswer3;
                Button_Q4.Text = pregunta.CorrectAnswer;
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
            if (test.CorrectAnswer(pregunta.CorrectAnswer, Button_Q1.Text))
            {
                test.newGrade(Pregunta.Porcentaje, Utils.grade);
                test.UpdateGrade(Utils.grade, int.Parse(Session["User_id"].ToString()), int.Parse(Session["id_prueba"].ToString()));
            }
            if (Utils.code<Utils.maxpregunta)
            {
                test.FillQuestion(int.Parse(Session["id_prueba"].ToString()));
                UpdatePanel1.Update();
                LblPregunta.Text = pregunta.Preguntatext.ToString();
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
