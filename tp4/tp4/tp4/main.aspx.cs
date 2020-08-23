using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace tp4
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strInsert;
            SqlCommand sqlCmd;
            SqlConnection hookUp;
            DataSet ds;

            hookUp = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();

            strInsert = "select * from category ";
            sqlCmd = new SqlCommand(strInsert, hookUp);
            da.SelectCommand = sqlCmd;
            ds = new DataSet();
            hookUp.Open();
            da.Fill(ds);
            hookUp.Close();
            int numberC = ds.Tables[0].Rows.Count;

            for (int i = 0; i < numberC; i++)
            {
                   Response.Write("</br></br></br></br></br>");
                   Response.Write("<a href=category.aspx?cId="+ ds.Tables[0].Rows[i][0].ToString()+">" +ds.Tables[0].Rows[i][1].ToString()+"</a>");
            }
            Response.Write("</table>");



        }
    }
}