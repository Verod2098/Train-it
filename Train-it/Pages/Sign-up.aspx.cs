using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Sign_up : System.Web.UI.Page
{
    Users user = new Users();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BttnSingup_Click(object sender, EventArgs e)
    {

        try
        {
            user.isMailReal(TxtMail.ToString());
            


        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
            Response.Write("<script language=javascript>.alert-blue-grey('Error al Registrar');</script>");

        }
    }
}