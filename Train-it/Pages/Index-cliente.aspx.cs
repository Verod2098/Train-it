using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Index_cliente : System.Web.UI.Page
{

    SqlConnection conexion = new SqlConnection("Data Source = DELL\\SQLEXPRESS;Initial Catalog = TRAINT-IT; User ID = Vero; Password=123");
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }



    protected void GridViewExamen_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {



            Session["Tema"] = GridViewExamen.SelectedRow.Cells[0].Text;
            Response.Redirect("GridPreguntas-cliente.aspx", false);

        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
        }


    }
}