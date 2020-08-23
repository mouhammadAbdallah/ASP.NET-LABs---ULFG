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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private string strInsert;
        private SqlCommand sqlCmd;
        private SqlConnection hookUp;
        protected void buttonSubmit_Click(object sender, EventArgs e)
        {

            hookUp = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True");

            strInsert = "INSERT INTO users(firstname, lastname,";
            strInsert += "username, password)VALUES";
            strInsert += "(@Name,@LName,@usr,@pass)";

            sqlCmd = new SqlCommand(strInsert, hookUp);
            sqlCmd.Parameters.Add("@Name", firstName.Text.Trim());
            sqlCmd.Parameters.Add("@LName", lastName.Text.Trim());
            sqlCmd.Parameters.Add("@usr", username.Text.Trim());
            sqlCmd.Parameters.Add("@pass", password.Text.Trim());


            hookUp.Open();
            sqlCmd.ExecuteNonQuery();
            hookUp.Close();

            HttpCookie usern = new HttpCookie("usern");
            usern.Value = username.Text.Trim();
            usern.Expires = DateTime.Now.AddDays(5);
            Response.Cookies.Add(usern);

            HttpCookie passw = new HttpCookie("passw");
            passw.Value = password.Text.Trim();
            passw.Expires = DateTime.Now.AddDays(5);
            Response.Cookies.Add(passw);

            Response.Redirect("signIn.aspx");

        }

    }
}