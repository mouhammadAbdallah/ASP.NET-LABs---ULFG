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

    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds;
            string conString;
            string sqlCmd;
            conString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True";
            
            sqlCmd = "select * from dbo.Supporters";
            ds = GetDataSet(conString, sqlCmd);
            DataOutput.Text = ds.Tables[0].Rows[0][1].ToString();

            sqlCmd = "INSERT INTO Supporters(LastName, FirstName, Email, Donation,DateLastContact)VALUES('mohamad', 'abdallah', 'mo@ulfg.net', 357, CONVERT(DATETIME,'2008-10-15 00:00:00'))";
            PutData(conString, sqlCmd);
            Label1.Text = "Data Entered";
        }
        public void PutData(string ConnectionString, string SQL)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(SQL, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataSet GetDataSet(string ConnectionString, string SQL)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = SQL;
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            conn.Open();
            da.Fill(ds);
            conn.Close();
            return ds;
        }
    }
}