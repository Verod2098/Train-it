using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Info_cliente : System.Web.UI.Page
{

    Users User = new Users();
    protected void Page_Load(object sender, EventArgs e)
    {
        Utils.conexion.Close();
        Fillinfo(int.Parse(Session["User_id"].ToString()));
    } 


   private void Fillinfo (int id) {
        try
        {
            if (User.searchUser(id)) {

                Txt_NombreText.Text = Users.nombre;
                TxtJob.Text = Users.ocupacion;
                TxtCentroEducativo.Text = Users.lugar;
                Txtphone.Text = Users.tel;
                Txt_correo.Text = Users.correo;
                Txt_Fecha.Text = Users.fecha;
                Labeltipe.Text = Users.tipo;


            }
                
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
        }


    }


    protected void UpgradeButton_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("Pago-Premium.aspx",false);
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString ());
        }
    }

    protected void BttnUdate_Click(object sender, EventArgs e)
    {

        try {

            User.updateClient(Txt_NombreText.Text, Txt_correo.Text, TxtJob.Text, TxtCentroEducativo.Text, Txtphone.Text, int.Parse(Session["User_id"].ToString())
);
            Response.Write("<script language=javascript>alert('Actualizado Con éxito');</script>");
            Txt_NombreText.Text = "";
            Txtphone.Text = " ";
            Txt_correo.Text = " ";
            TxtCentroEducativo.Text = " ";
            TxtJob.Text = " ";
            Txt_Fecha.Text = " ";
            Labeltipe.Text = " ";
           
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Actualizado Con éxito');</script>");
            Txt_NombreText.Text = "";
            Txtphone.Text = " ";
            Txt_correo.Text = " ";
            TxtCentroEducativo.Text = " ";
            TxtJob.Text = " ";
            Txt_Fecha.Text = " ";
            Labeltipe.Text = " ";

        }
    }
}