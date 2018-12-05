using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Nota_cliente : System.Web.UI.Page
{
    Test test = new Test();
    SqlConnection conexion = new SqlConnection("Data Source = DELL\\SQLEXPRESS;Initial Catalog = TRAINT-IT; User ID = Vero; Password=123");
    protected void Page_Load(object sender, EventArgs e)
    {
        FillInfo();
        //printQuestions();
    }

    protected void BttnNota_Click(object sender, EventArgs e)
    {

        Response.Redirect("Index-cliente.aspx", false);
    }

    protected void BttnLinkPremiun_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pago-Premium.aspx", false);
    }


    private void FillInfo() {

        try
        {

            String sql;
            SqlCommand com;
            SqlDataReader rs;
            conexion.Open();
            sql = "Select * from Historial where id_prueba=@prueba and id=@id";
            com = conexion.CreateCommand();
            com.CommandText = sql;
            com.Parameters.AddWithValue("prueba", int.Parse(Session["id_prueba"].ToString()));
            com.Parameters.AddWithValue("id", Users.id);
            rs = com.ExecuteReader();

            if (rs.Read())
            {
                LblCodTxt.Text = Users.id.ToString();
                LblNomTex.Text = rs[3].ToString();
                LblCacTex.Text = rs[0].ToString();

            }

        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
        }


    }

 

       public void printQuestions()
       {
           try
           {

            //var DataSource = Utils.ListPregunta; 

            DataList1.DataSource = Utils.ListPregunta;
            DataList1.DataBind();
           }
           catch (Exception i)
           {
               Console.WriteLine(i.ToString());
           }
       }
}
