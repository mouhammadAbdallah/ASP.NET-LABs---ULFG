using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace tp2
{
    public partial class signIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string u = "";
            string p = "";
            HttpCookie usern = Request.Cookies["usern"];
            HttpCookie passw = Request.Cookies["passw"];

            if (usern != null)
            {
                u += usern.Value;
            }
            if (passw != null)
            {
                p += passw.Value;
            }
            username.Text = u;
            password.Text = p;
        }
        private string strInsert;
        private SqlCommand sqlCmd;
        private SqlConnection hookUp;
        protected void buttonSubmit_Click(object sender, EventArgs e)
        {
            DataSet ds;
            hookUp = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();

            strInsert = "select * from users ";
            strInsert += "where (username=@usr) and (password=@pass)";

            sqlCmd = new SqlCommand(strInsert, hookUp);
            sqlCmd.Parameters.Add("@usr", username.Text.Trim());
            sqlCmd.Parameters.Add("@pass", password.Text.Trim());
            da.SelectCommand = sqlCmd;
            ds = new DataSet();
            hookUp.Open();
            da.Fill(ds);
            hookUp.Close();

            try
            {
                ds.Tables[0].Rows[0][1].ToString();


                HttpCookie firstn = new HttpCookie("firstn");
                firstn.Value = ds.Tables[0].Rows[0][1].ToString();
                firstn.Expires = DateTime.Now.AddDays(5);
                Response.Cookies.Add(firstn);

                HttpCookie lastn = new HttpCookie("lastn");
                lastn.Value = ds.Tables[0].Rows[0][2].ToString();
                lastn.Expires = DateTime.Now.AddDays(5);
                Response.Cookies.Add(lastn);

                Response.Redirect("welcome.aspx");
            }
            catch
            {
                Label1.Text = "User not found, you need to sign up!";
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("signUp.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
            HttpCookie usern = new HttpCookie("usern");
            HttpCookie passw = new HttpCookie("passw");
            usern.Value = "";
            passw.Value = "";
            usern.Expires = DateTime.Now;
            passw.Expires = DateTime.Now;
            Response.Cookies.Add(usern);
            Response.Cookies.Add(passw);
            Response.Redirect("signIn.aspx");
        }
    }
}