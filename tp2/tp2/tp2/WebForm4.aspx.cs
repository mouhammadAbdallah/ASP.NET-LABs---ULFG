using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace tp2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        private string strDelete;
        private SqlCommand sqlCmd;
        private SqlConnection hookUp;
        protected void WipeOut(object sender, EventArgs e)
        {
            hookUp = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True");
            strDelete = "DELETE FROM Supporters WHERE LastName=@LName AND FirstName = @FName";
        sqlCmd = new SqlCommand(strDelete, hookUp);
            sqlCmd.Parameters.Add("@LName", LName.Text);
            sqlCmd.Parameters.Add("@FName", FName.Text);
            hookUp.Open();
            sqlCmd.ExecuteNonQuery();
            hookUp.Close();
            Label1.Text = FName.Text + " " + LName.Text + " has left the table.";
        }
    
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}