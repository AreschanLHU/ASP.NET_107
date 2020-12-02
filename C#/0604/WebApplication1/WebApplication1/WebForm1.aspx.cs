using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int sum = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "項目" + DropDownList1.SelectedItem + "     數量" + DropDownList2.SelectedValue;
            sum +=  Convert.ToInt16(DropDownList1.SelectedValue) * Convert.ToInt16(DropDownList2.SelectedValue);
            Label1.Text = Convert.ToString(sum);
            Label2.Text = Convert.ToString(Convert.ToInt16(Label2.Text) + Convert.ToInt16(Label1.Text));
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            string Web2;
            Web2 = "~/WebForm2.aspx?";
            Web2 += "Sum=" + Label2.Text;
            Web2 += "&TextBox=" + TextBox1.Text; 
           
            Response.Redirect(Web2);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string Web3;
            Web3 = "~/WebForm3.aspx?";
            Response.Redirect(Web3);
        }
    }
}