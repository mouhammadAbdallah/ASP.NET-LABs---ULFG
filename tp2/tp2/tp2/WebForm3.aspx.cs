using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace tp2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private string strUpdate;
        private SqlCommand sqlCmd;
        private SqlConnection hookUp;
        protected void UpdateData(object sender, EventArgs e)
        {
            hookUp = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True");
            strUpdate = "UPDATE Supporters SET LastName=@NName WHERE (LastName=@LName)";
            sqlCmd = new SqlCommand(strUpdate, hookUp);
            sqlCmd.Parameters.Add("@LName", LName.Text);
            sqlCmd.Parameters.Add("@NName", NewName.Text);
            hookUp.Open();
            sqlCmd.ExecuteNonQuery();
            hookUp.Close();
            Label1.Text = "Your Record is updated.";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}