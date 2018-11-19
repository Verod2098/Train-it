using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Preferencias : System.Web.UI.Page
{

    Users user = new Users();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Bttnnext_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("index-cliente.aspx", false);

        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
        }
    }

    
    protected void GrriPrefe_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            Session["Preferencias"] = GrriPrefe.SelectedRow.Cells[1].Text;
            user.insertPreferences(int.Parse(Session["User_id"].ToString()), Session["Preferencias"].ToString());
            Response.Write("<script language=javascript>alert('Ingresado Con éxito');</script>");
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }

    }
}