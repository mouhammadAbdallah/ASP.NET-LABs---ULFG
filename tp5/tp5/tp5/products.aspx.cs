using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace tp5
{
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DataSet ds;
            string conString;
            string sqlCmd;
            conString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True";

            sqlCmd = "INSERT INTO product(pname, pdescription,psupplier,img)VALUES('" + name.Text + "','" + desc.Text + "'," + Request.QueryString["sId"] + ",'" + FileUpload1.FileName + "')";
            SqlConnection conn = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand(sqlCmd, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            FileUpload1.SaveAs(@"C:\Users\Moham\OneDrive\University\semesters\semester8\ASPLabs\tp5\tp5\tp5\" + FileUpload1.FileName);

            Response.Redirect(Request.Url.ToString());
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}