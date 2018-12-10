using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Usuario_Admin : System.Web.UI.Page

{ 
    Users user=new Users();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BttnAdd_Click(object sender, EventArgs e)
    {
        try
        {

           // user.addUser(int.Parse(Txtid.Text), TxtName.Text, TxtMail.Text, TxtOcupation.Text, Txtplace.Text, TxtPhone.Text, DDL.Text, int.Parse(DropDownList1.ToString()), "Basic", Txtdate.Text, TxtPassword.Text);
            Response.Write("<script language=javascript>alert('Ingresado Con éxito');</script>");
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }

    }
}