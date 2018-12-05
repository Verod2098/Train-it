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
            if (Validate(TxtPassword.Text))
            {
                user.isMailReal(TxtMail.Text);
                user.addUser(int.Parse(Txtid.Text), TxtName.Text, TxtMail.Text, TxtOcupation.Text, Txtplace.Text, TxtPhone.Text, "Usuario", 0, "Basic", Txtdate.Text, TxtPassword.Text);
                Response.Write("<script language=javascript>.alert-blue-grey('Usuario Registrado con exito');</script>");
                Session["User_id"] = Txtid.Text;
                Session["Tipo"] = "Basic";
                Response.Redirect("Preferencias.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>.alert-blue-grey('La contraseña no cumple con los parámetros de seguridad');</script>");
            }

        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
            Response.Write("<script language=javascript>('Error al Registrar');</script>");

        }
    }


    private Boolean Validate(string password)
    {
        Boolean isGood = false;

        if (password != String.Empty)
        {
            if (password.Length > 8)
            {

                bool contNum = false;
                bool contString = false;
                foreach (char item in password)
                {
                    if (Char.IsNumber(item))
                    {
                        contNum = true;
                    }
                    else if (Char.IsLetter(item))
                    {
                        contString = true;
                    }

                }
                if (!contString || !contNum)
                {
                    Response.Write("<script language=javascript>('No contiene números o caractéres');</script>");
                }
            }
            else
            {

                Response.Write("<script language=javascript>('La contraseña no tiene el largo adecuado ');</script>");


            }
            return isGood;
        }
    
        else
        {
            Response.Write("<script language=javascript>('No puede dejar este espacio en blanco ');</script>");
        }

        }
   
    
}


