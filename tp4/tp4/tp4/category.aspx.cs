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
    public partial class category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strInsert;
            SqlCommand sqlCmd;
            SqlConnection hookUp;

            DataSet ds;
            hookUp = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();

            strInsert = "select * from subject where(cId=@cId)";

            sqlCmd = new SqlCommand(strInsert, hookUp);
            sqlCmd.Parameters.Add("@cId", Request.QueryString["cId"].ToString().Trim());
            da.SelectCommand = sqlCmd;
            ds = new DataSet();
            hookUp.Open();
            da.Fill(ds);
            hookUp.Close();

            

            Response.Write("<table>");
            int i, np = ds.Tables[0].Rows.Count;
            for (i = 0; i < np; i++)
            {
                Response.Write("<tr>");
                
                Response.Write("<td>");
                Response.Write("<a href='"+ ds.Tables[0].Rows[i][1].ToString().Trim() + ".png'><img src=" + ds.Tables[0].Rows[i][1].ToString().Trim() + ".png width=140 height= 140></img></a>");
                Response.Write("</td>");

                Response.Write("<td width=64 >");
                Response.Write(ds.Tables[0].Rows[i][2].ToString().Trim());
                Response.Write("</td>"); 

                Response.Write("<td width=64>");
                Response.Write(ds.Tables[0].Rows[i][3].ToString().Trim());
                Response.Write("</td>");

                Response.Write("</tr>");
            }
            Response.Write("</table>");

        }
    }
}