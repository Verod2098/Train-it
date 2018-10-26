using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Info_examen_pregunta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BttnPrueba_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("Pregunta-Cliente.aspx", false);
        }
        catch (Exception exception) {

            Console.WriteLine(exception.ToString());

        }
    }
}