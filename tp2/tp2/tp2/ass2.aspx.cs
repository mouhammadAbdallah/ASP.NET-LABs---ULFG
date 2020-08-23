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
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = 0;
            dtn.Text = "The date and time: " + DateTime.Now;
            labelMessage.Text = "";

        }
        private string strInsert;
        private SqlCommand sqlCmd;
        private SqlConnection hookUp;
        protected void buttonSubmit_Click(object sender, EventArgs e)
        {
            

            if (Page.IsValid)
            {

                string pr = (mOF.SelectedValue == "0") ? "Mr" : "Miss";
                int age = DateTime.Now.Year - int.Parse(dateOfBirth.Text.Split('-')[2]);
                labelMessage.Text = pr + " " + firstName.Text + " " + lastName.Text + " born in " + placeOfBirth.Text + " is " +
                        age.ToString() + " old and is " + familysatus.SelectedValue + ",his nationality is " + nationality.SelectedValue;

            }
            hookUp = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True");
            if (id == 0)
            {
                strInsert = "INSERT INTO person(name, lastname,";
                strInsert += "dateofbirth, placeofbirth, gender,nationality,familystatus)VALUES";
                strInsert += "(@Name,@LName,@dob,@pob,@gender,@natio,@fs)";
            }
            else
            {
                id = int.Parse(DropDownList1.SelectedValue.ToString().Trim());
                strInsert = "update person set name=@Name ,lastname=@LName, ";
                strInsert += "dateofbirth=@dob, placeofbirth=@pob, gender=@gender, nationality=@natio, familystatus=@fs ";
                strInsert += "where (id=" + id.ToString() + ")";
            }
            sqlCmd = new SqlCommand(strInsert, hookUp);
            sqlCmd.Parameters.Add("@Name", firstName.Text);
            sqlCmd.Parameters.Add("@LName", lastName.Text);
            sqlCmd.Parameters.Add("@dob", dateOfBirth.Text.Trim());
            sqlCmd.Parameters.Add("@pob", placeOfBirth.Text.Trim());
            sqlCmd.Parameters.Add("@gender", mOF.SelectedValue);
            sqlCmd.Parameters.Add("@natio", nationality.SelectedValue);
            sqlCmd.Parameters.Add("@fs", familysatus.SelectedValue);

            hookUp.Open();
            sqlCmd.ExecuteNonQuery();
            hookUp.Close();
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            id = 0;
            labelMessage.Text = "";
            familysatus.SelectedValue = "single";
            nationality.SelectedValue = "Lebanon";
            mOF.SelectedValue = null;
            firstName.Text = "";
            lastName.Text = "";
            dateOfBirth.Text = "";
            placeOfBirth.Text = "";
            buttonSubmit.Text = "Submit Request";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSubmit.Text = "Update";
            DataSet ds;
            string conString;
            string sqlCmd;
            conString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True";

            sqlCmd = "select * from person where (id=@Id)";
            ds = GetDataSet(conString, sqlCmd);

            id = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            firstName.Text = ds.Tables[0].Rows[0][1].ToString();
            lastName.Text = ds.Tables[0].Rows[0][2].ToString();
            dateOfBirth.Text = DateTime.Parse(ds.Tables[0].Rows[0][3].ToString()).ToString("dd-MM-yyyy");
            placeOfBirth.Text = ds.Tables[0].Rows[0][4].ToString();
            mOF.SelectedValue = ds.Tables[0].Rows[0][5].ToString();
            nationality.SelectedValue = ds.Tables[0].Rows[0][6].ToString().Trim();
            familysatus.SelectedValue = ds.Tables[0].Rows[0][7].ToString().Trim();


            string pr = (mOF.SelectedValue == "0") ? "Mr" : "Miss";
            int age = DateTime.Now.Year - int.Parse(dateOfBirth.Text.Split('-')[2]);
            labelMessage.Text = pr + " " + firstName.Text + " " + lastName.Text + " born in " + placeOfBirth.Text + " is " +
                    age.ToString() + " old and is " + familysatus.SelectedValue + ",his nationality is " + nationality.SelectedValue;


        }
        public DataSet GetDataSet(string ConnectionString, string SQL)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = SQL;
            cmd.Parameters.Add("@Id", DropDownList1.SelectedValue.ToString());
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            conn.Open();
            da.Fill(ds);
            conn.Close();
            return ds;
        }

        protected void placeOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            id = int.Parse(DropDownList1.SelectedValue.ToString().Trim());

            hookUp = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True");
            strInsert = "delete from person ";
            strInsert += "where (id=" + id.ToString() + ")";


            sqlCmd = new SqlCommand(strInsert, hookUp);

            hookUp.Open();
            sqlCmd.ExecuteNonQuery();
            hookUp.Close();
            DropDownList1.DataBind();
            Button1_Click(null,null);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DropDownList1.SelectedIndex = DropDownList1.SelectedIndex - 1;
            DropDownList1_SelectedIndexChanged(null, null);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DropDownList1.SelectedIndex = DropDownList1.SelectedIndex + 1;
            DropDownList1_SelectedIndexChanged(null, null);
        }
    }
}