using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;


namespace WebApplication1
{


    public partial class WebForm3 : System.Web.UI.Page
    {
        //存取資料庫的位置
        string DB3 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gkhga\Desktop\研究所資料\C#\0604\DB3.mdf;Integrated Security=True;Connect Timeout=30;";
        string TABLE_NAME = "TTT";

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //回到Web1
        protected void Button1_Click(object sender, EventArgs e)
        {
            string Web1;
            Web1 = "~/WebForm1.aspx?";
            Response.Redirect(Web1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(DB3);
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO " + TABLE_NAME + " (Id) values ('" + TextBox1.Text + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            GridView1.DataSourceID = "SqlDataSource1";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(DB3);
            connection.Open();
      
            SqlCommand cmd = new SqlCommand("UPDATE " + TABLE_NAME + " SET Name = ('" + TextBox3.Text + "'), Price = ('" + TextBox4.Text + "') WHERE Id = ('" + TextBox2.Text + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            GridView1.DataSourceID = "SqlDataSource1";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(DB3);
            connection.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM " + TABLE_NAME + " WHERE Id =  ('" + TextBox5.Text + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            GridView1.DataSourceID = "SqlDataSource1";
        }
    }
}