using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Topic_admin : System.Web.UI.Page
{

    Topic_Pregunta pregunta = new Topic_Pregunta();
    Topic_Test test = new Topic_Test();
        
        protected void Page_Load(object sender, EventArgs e)
    {
        FillGridPru();
        FillGridPre();
    }

    private void FillGridPru()
    {
        try
        {
            Utils.conexion.Open();
            SqlCommand consulta = new SqlCommand(string.Format("SELECT * FROM Topic_Test"), Utils.conexion);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridViewTopic.DataSource = dt;
            GridViewTopic.DataBind();
            Utils.conexion.Close();
        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
        }
    }

    private void FillGridPre()
    {
        try
        {
            Utils.conexion.Open();
            SqlCommand consulta = new SqlCommand(string.Format("SELECT * FROM Topic_Question"), Utils.conexion);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridViewPre.DataSource = dt;
            GridViewPre.DataBind();
            Utils.conexion.Close();
        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
        }
    }

    protected void BttnAddpru_Click(object sender, EventArgs e)
    {
        try {

            test.addTopicTest(int.Parse(txt_codtemapru.Text),txtNombretemapru.Text);
            Response.Write("<script language=javascript>alert('Ingresado Con éxito');</script>");
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }
    }

    protected void BttnUPptu_Click(object sender, EventArgs e)
    {
        try
        {

            test.updateTopicTest(int.Parse(txt_codtemapru.Text), txtNombretemapru.Text);
            Response.Write("<script language=javascript>alert('Actualizado Con éxito');</script>");
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }
    }

    protected void BttnDELpru_Click(object sender, EventArgs e)
    {
        try
        {

            test.deleteTopicTest(int.Parse(txt_codtemapru.Text));
            Response.Write("<script language=javascript>alert('Eliminado Con éxito');</script>");

        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }
    }

    protected void BttnAddpre_Click(object sender, EventArgs e)
    {
        try
        {

           pregunta.addTopicQuestion(int.Parse(Txtcodtemapre.Text),Txtnombretemapre.Text);
            Response.Write("<script language=javascript>alert('Ingresado Con éxito');</script>");
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }
    }

    protected void BttnUPpre_Click(object sender, EventArgs e)
    {
        try
        {

            pregunta.updateTopicQuestion(int.Parse(Txtcodtemapre.Text), Txtnombretemapre.Text);
            Response.Write("<script language=javascript>alert('Actualizado Con éxito');</script>");
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }
    }

    protected void BttnDelPRe_Click(object sender, EventArgs e)
    {
        try
        {

            pregunta.deleteTopicQuestion(int.Parse(Txtcodtemapre.Text));
            Response.Write("<script language=javascript>alert('Eliminado Con éxito');</script>");
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }
    }

  
}