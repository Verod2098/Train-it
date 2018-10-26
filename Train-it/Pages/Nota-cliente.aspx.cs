using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Nota_cliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BttnNota_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index-cliente.aspx", false);
    }

    protected void BttnLinkPremiun_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pago-Premium.aspx", false);
    }
}