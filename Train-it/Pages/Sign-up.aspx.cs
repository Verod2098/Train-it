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
        Utils.conexion.Close();
    }

    protected void BttnSingup_Click(object sender, EventArgs e)
    {

        try
        {
            user.isMailReal(TxtMail.Text);
            user.addUser(int.Parse(Txtid.Text), TxtName.Text, TxtMail.Text, TxtOcupation.Text, Txtplace.Text, TxtPhone.Text, "Usuario",0, "Basic", Txtdate.Text, TxtPassword.Text);
            Response.Write("<script language=javascript>.alert-blue-grey('Usuario Registrado con exito');</script>");
            Session["User_id"] = Txtid.Text;
            Session["Tipo"] = "Basic";
            Response.Redirect("Preferencias.aspx");

        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
            Response.Write("<script language=javascript>('Error al Registrar');</script>");

        }
    }
}