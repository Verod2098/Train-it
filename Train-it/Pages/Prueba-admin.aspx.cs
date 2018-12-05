using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Prueba_admin : System.Web.UI.Page
{

    Test test = new Test();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BttnAdd_Click(object sender, EventArgs e)
    {
        try
        {

            test.AddTest(int.Parse(Txt_grade.Text), Txt_NombreText.Text, int.Parse(DDLType.Text), int.Parse(Txt_Time.Text), Txt_Approved.Text, int.Parse(TxtPrem.Text), int.Parse(TxtBasic.Text), int.Parse(TxtPrice.Text));
            Response.Write("<script language=javascript>alert('Agregado Con éxito');</script>");
            Txt_ID.Text = " ";
            TxtBasic.Text = " ";
            TxtPrem.Text = " ";
            Txt_Approved.Text = " ";
            Txt_grade.Text = " ";
            Txt_NombreText.Text = " ";
            Txt_Time.Text = " ";
            TxtPrice.Text = " ";

        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }
    }





    protected void Bttndel_Click(object sender, EventArgs e)
    {
        try
        {

            test.deleteTest(int.Parse(Txt_ID.Text));
            Response.Write("<script language=javascript>alert('Eliminado  Con éxito');</script>");
            Txt_ID.Text = " ";
            TxtBasic.Text = " ";
            TxtPrem.Text = " ";
            Txt_Approved.Text = " ";
            Txt_grade.Text = " ";
            Txt_NombreText.Text = " ";
            Txt_Time.Text = " ";
            TxtPrice.Text = " ";
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }
    }

    protected void Bttnupdate_Click(object sender, EventArgs e)
    {
        try
        {
            test.updateTest(int.Parse(Txt_grade.Text), Txt_NombreText.Text, int.Parse(DDLType.Text), int.Parse(Txt_Time.Text), Txt_Approved.Text, int.Parse(TxtPrem.Text), int.Parse(TxtBasic.Text), int.Parse(TxtPrice.Text), int.Parse(Txt_ID.Text));
            Response.Write("<script language=javascript>alert('Actualizado Con éxito');</script>");
            Txt_ID.Text = " ";
            TxtBasic.Text = " ";
            TxtPrem.Text = " ";
            Txt_Approved.Text = " ";
            Txt_grade.Text = " ";
            Txt_NombreText.Text = " ";
            Txt_Time.Text = " ";
            TxtPrice.Text = " ";
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }
    }

    protected void Bttnsearch_Click(object sender, EventArgs e)
    {
        try
        {

            test.searchTest(int.Parse(Txt_ID.Text));
            TxtBasic.Text = Utils.maxpreguntaBasic.ToString();
            TxtPrem.Text =Utils.maxpreguntaPremium.ToString() ;
            Txt_Approved.Text = Utils.approved.ToString();
            Txt_grade.Text = Utils.grade.ToString();
            Txt_NombreText.Text = Utils.name;
            Txt_Time.Text =Utils.time;
            TxtPrice.Text = Utils.price.ToString();

        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }
    }
}