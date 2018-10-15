using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pregunta_Cliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Utils.isfull)
        {
            UpdatePanel1.Update();
           // Test.FillQuestion(int.Parse(Session["id_prueba"].ToString()));
            LblPregunta.Text = Utils.pregunta;
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
                Button_Q1.Text = Utils.CorrectAnswer;
                Button_Q2.Text = Utils.BadAnswer1;
                Button_Q3.Text = Utils.BadAnswer2;
                Button_Q4.Text = Utils.BadAnswer3;

            }
            else if (right == 2)
            {
                Button_Q1.Text = Utils.BadAnswer1;
                Button_Q2.Text = Utils.CorrectAnswer;
                Button_Q3.Text = Utils.BadAnswer2;
                Button_Q4.Text = Utils.BadAnswer3;
            }
            else if (right == 3)
            {
                Button_Q1.Text = Utils.BadAnswer1;
                Button_Q2.Text = Utils.BadAnswer2;
                Button_Q3.Text = Utils.CorrectAnswer;
                Button_Q4.Text = Utils.BadAnswer3;
            }
            else if (right == 4)
            {
                Button_Q1.Text = Utils.BadAnswer1;
                Button_Q2.Text = Utils.BadAnswer2;
                Button_Q3.Text = Utils.BadAnswer3;
                Button_Q4.Text = Utils.CorrectAnswer;
            }


        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
        }

    }





    protected void Button_Q1_Click(object sender, EventArgs e)
    {

    }
}
