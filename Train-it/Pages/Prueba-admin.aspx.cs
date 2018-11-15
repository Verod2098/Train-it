using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Prueba_admin : System.Web.UI.Page
{

    Test test = new Test();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BttnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            
            test.AddTest(int.Parse(Txt_grade.Text),Txt_NombreText.Text,int.Parse(DDLType.Text),int.Parse(Txt_Time.Text),Txt_Approved.Text,int.Parse(TxtPrem.Text),int.Parse(TxtBasic.Text),int.Parse(TxtPrice.Text),int.Parse(Txt_ID.Text));
            Response.Write("<script language=javascript>alert('Agregado Con éxito');</script>");

        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }
    }



    
}