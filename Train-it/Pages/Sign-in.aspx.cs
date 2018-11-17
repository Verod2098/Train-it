using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Sign_in : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Users user = new Users();
    }

 



    protected void BttnSign_Click(object sender, EventArgs e)
    {
   /*     try
        {
            if (users.searchclient(TxtUser.Text, TxtPassword.Text))
            {
                Session["User_name"] = Utils.nombre;
                Session["User_id"] = Utils.id;
                Response.Redirect("Index-cliente.aspx",false);
                
            } else if (user.searchAdmin(TxtUser.Text, TxtPassword.Text))
            {
                Response.Redirect("Index-Admin.aspx",false);
            }
            else
            {
                Response.Write("<script language=javascript>alert('Datos incorrectos');</script>");
            }
        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
            Response.Write("<script language=javascript>.alert-blue-grey('Error al ingresar');</script>");

        }

    */
    }
}