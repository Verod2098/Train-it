using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Pregunta_admin : System.Web.UI.Page
{
    Pregunta pregunta = new Pregunta();
    protected void Page_Load(object sender, EventArgs e)
    {
        Utils.conexion.Close();
    }





    protected void BttnAdd_Click(object sender, EventArgs e)
    {

        try
        {

            if (image.HasFile) {
                Pregunta.image = image.FileBytes;

            }
            pregunta.addQuestion(txt_pregunta.Text, txt_Porcentaje.Text, txt_RA.Text, txt_RN1.Text, txt_RN2.Text, txt_RN3.Text, DDLTipoPregunta.Text, Pregunta.image, int.Parse(DropDownListCodPrueba.Text), int.Parse(DropDownListCodTema.Text), int.Parse(txt_Nump.Text), 1);
            Response.Write("<script language=javascript>alert('Ingresado Con éxito');</script>");
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }

    }




    protected void BttnDel_Click(object sender, EventArgs e)
    {
        try
        {

            pregunta.deleteQuestion(int.Parse(txt_Nump.Text));
            Response.Write("<script language=javascript>alert('Eliminado Con éxito');</script>");

        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }

    }



    protected void BttnUp_Click(object sender, EventArgs e)
    {
        try
        {
            if (image.HasFile)
            {
                Pregunta.image = image.FileBytes;

            }
            pregunta.updateQuestion(txt_pregunta.Text, txt_Porcentaje.Text, txt_RA.Text, txt_RN1.Text, txt_RN2.Text, txt_RN3.Text, DDLTipoPregunta.Text, Pregunta.image, int.Parse(DropDownListCodPrueba.Text), int.Parse(DropDownListCodTema.Text), int.Parse(txt_Nump.Text), 1);
            Response.Write("<script language=javascript>alert('Actualizado Con éxito');</script>");
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
            Response.Write("<script language=javascript>alert('Error al realizar acción');</script>");
        }
    }
}




