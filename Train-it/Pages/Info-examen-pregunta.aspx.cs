using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Info_examen_pregunta : System.Web.UI.Page {
    Test test = new Test();
    SqlConnection conexion = new SqlConnection("Data Source = DELL\\SQLEXPRESS;Initial Catalog = TRAINT-IT; User ID = Vero; Password=123");
    protected void Page_Load(object sender, EventArgs e)
    {
        fillInfo();
    }

    protected void BttnPrueba_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("Pregunta-Cliente.aspx", false);
            Utils.code = 0;
            Utils.grade = 0;
            test.AddGrade(int.Parse(Session["User_id"].ToString()), int.Parse(Session["id_prueba"].ToString()));
        }
        catch (Exception exception) {

            Console.WriteLine(exception.ToString());

        }
    }

    private void fillInfo() {

        try
        {

            String sql;
            SqlCommand com;
            SqlDataReader rs;
            
            conexion.Open();
            sql = "select * from  Test where Name=@codigo";
            com = conexion.CreateCommand();
            com.CommandText = sql;
            com.Parameters.AddWithValue("codigo", Session["nombre_prueba"].ToString());

            rs = com.ExecuteReader();

            if (rs.Read())
            {
                Session["id_Prueba"] = rs[8].ToString();
                LblCodTxt.Text = rs[8].ToString ();
                LblNomTex.Text = Session[ "nombre_prueba"].ToString();
                LblEsTex.Text = rs[2].ToString();
                LblTimeText.Text= rs[3].ToString();

                if (Session["Tipo"].ToString() == "Basic")
                {

                    Utils.maxpregunta = int.Parse(rs[6].ToString());

                }
                else {
                    if (Session["Tipo"].ToString() == "Premium") {

                        Utils.maxpregunta = int.Parse(rs[5].ToString());

                    }

                }
                

            }

        }
        catch (Exception i)
        {
            Console.WriteLine(i.ToString());
        }

        conexion.Close();

    }
    
}