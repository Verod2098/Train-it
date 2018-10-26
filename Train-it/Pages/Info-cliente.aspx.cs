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
        Fillinfo(1);
    } 


   private void Fillinfo (int id) {
        try
        {
            if (User.searchUser(id)) {

                Txt_NombreText.Text = Utils.nombre;
                TxtJob.Text = Utils.ocupacion;
                TxtCentroEducativo.Text = Utils.lugar;
                Txtphone.Text = Utils.tel.ToString();
                Txt_correo.Text = Utils.correo;
                Txt_Fecha.Text = Utils.fecha;
                Labeltipe.Text = Utils.tipo;


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
}