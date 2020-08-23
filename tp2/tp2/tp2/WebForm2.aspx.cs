using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace tp2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private DateTime currentDate;
        private string strInsert;
        private SqlCommand sqlCmd;
        private SqlConnection hookUp;
        protected void EnterData(object sender, EventArgs e)
        {
            currentDate = DateTime.Now;
            hookUp = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True");
            strInsert = "INSERT INTO Supporters(LastName, FirstName,";
            strInsert += "Email, Donation, DateLastContact)VALUES";
            strInsert += "(@LName,@FName,@Em,@Donate,@NowDate)";
            sqlCmd = new SqlCommand(strInsert, hookUp);
            sqlCmd.Parameters.Add("@LName", LName.Text);
            sqlCmd.Parameters.Add("@FName", FName.Text);
            sqlCmd.Parameters.Add("@Em", Em.Text);
            sqlCmd.Parameters.Add("@Donate", Donate.Text);
            sqlCmd.Parameters.Add("@NowDate", currentDate);
            hookUp.Open();
            sqlCmd.ExecuteNonQuery();
            hookUp.Close();
            Label1.Text = "Data has been sent";
        }
    
    protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}