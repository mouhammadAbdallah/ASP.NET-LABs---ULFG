using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Redirect("server.aspx?name=John&age=30");
        }

        protected void UploadBtn_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(@"C:\Users\Moham\OneDrive\University\semesters\semester8\ASPLabs\tp4\tp4\" + FileUpload1.FileName);
                Label1.Text = "File Uploaded: " + FileUpload1.FileName;
            }
            else { 
                Label1.Text = "No File Uploaded.";
            }
        }
    }
}