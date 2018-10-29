using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_GridPreguntas_cliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridViewPruebas_SelectedIndexChanged(object sender, EventArgs e)
    {

        try
        {
            Session["nombre_prueba"] = GridViewPruebas.SelectedRow.Cells[1].Text;
            Response.Redirect("Info-examen-pregunta.aspx", false);

        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
        }


    }
}