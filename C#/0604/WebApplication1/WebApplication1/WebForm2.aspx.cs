using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Request.QueryString["TextBox"];
            Label2.Text = Request.QueryString["Sum"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Web1;
            Web1 = "~/WebForm1.aspx?";
            Response.Redirect(Web1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string Web3;
            Web3 = "~/WebForm3.aspx?";
            Response.Redirect(Web3);
        }
    }
}