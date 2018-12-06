using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Sign_in : System.Web.UI.Page
{
    Users user = new Users();
    protected void Page_Load(object sender, EventArgs e)
    {
        Utils.conexion.Close();
    }


    protected void BttnSign_Click(object sender, EventArgs e)
    {
        try
        {
            if (user.searchclient(TxtUser.Text, TxtPassword.Text))
            {
                if (Users.Status == "true")
                {
                    if (Users.rol == "Usuario")
                    {
                        Session["User_id"] = Users.id;
                        Session["Tipo"] = Users.tipo;
                        Response.Redirect("Index-cliente.aspx", false);
                    }
                    else if (Users.rol == "Administrador")
                    {
                        Session["User_id"] = Users.id;
                        Session["Tipo"] = Users.tipo;
                        Response.Redirect("Index-Admin.aspx", false);
                    }
                    else if (Users.rol == "Especialista")
                    {
                        Session["User_id"] = Users.id;
                        Session["Tipo"] = Users.tipo;
                        Response.Redirect("Index-Especialista.aspx", false);
                    }

                }
            }
            else
            {



                if (Users.Status == "false")
                {

                    Response.Write("<script language=javascript>alert('La cuenta no esta activa');</script>");
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Datos incorrectos');</script>");
                }
            }
        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
            Response.Write("<script language=javascript>.alert-blue-grey('Error al ingresar');</script>");

        }


    }
}