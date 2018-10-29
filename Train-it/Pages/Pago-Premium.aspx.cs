using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Pago_Premium : System.Web.UI.Page
{

    Tarjeta tarjeta = new Tarjeta();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ChckListTarjeta_SelectedIndexChanged(object sender, EventArgs e)
    {
        Tarjeta.Tipo = ChckListTarjeta.Text;
    }

    protected void BttnPay_Click(object sender, EventArgs e)
    {
        try {
            tarjeta.addCreditCard(Txt_NombreText.Text, TxtTarejat.Text, TxtCodigo.Text, Tarjeta.Tipo, Txtfecha.Text);
            tarjeta.upgradeAccount(TxtTarejat.Text,Utils.cedula);
            TxtCodigo.Text = "";
            Txtfecha.Text = "";
            Txt_NombreText.Text = "";
            TxtTarejat.Text = "";
            ChckListTarjeta.Visible= false;

        }

        catch (Exception exception)
        {

            Console.WriteLine(exception.ToString());

        }
    }
}