using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Topic_admin : System.Web.UI.Page
{

    Topic_Pregunta pregunta = new Topic_Pregunta();
    Topic_Test test = new Topic_Test();
        
        protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BttnAddpru_Click(object sender, EventArgs e)
    {
        try {

            pregunta.addTopicQuestion();
        }
        catch (Exception exception)

        {
            Console.WriteLine(exception.ToString());
        }
    }
}