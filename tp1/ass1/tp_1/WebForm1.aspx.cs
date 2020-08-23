using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace tp_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        StreamWriter sw;
        protected void Page_Load(object sender, EventArgs e)
        {
            dtn.Text = "The date and time: " + DateTime.Now;
            labelMessage.Text = "";
        }

        protected void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                            
            string pr = (mOF.SelectedValue == "0") ? "Mr" : "Miss";
            int age = DateTime.Now.Year - int.Parse(dateOfBirth.Text.Split('-')[2]);
            labelMessage.Text = pr+" "+firstName.Text+" "+lastName.Text+" born in "+placeOfBirth.Text+" is "+
                age.ToString()+" old and is "+familysatus.SelectedValue+",his nationality is "+nationality.SelectedValue;


                string path = @"C:\Users\Moham\OneDrive\University\semesters\semester8\ASPLabs\tp1\ass1\data.txt";
                
                if (!File.Exists(path))
                {
                    sw = File.CreateText(path);
                    sw.Close();
                }

                sw = File.AppendText(path);

                sw.WriteLine(labelMessage.Text);

                sw.Close();
            }
        }


    }
}