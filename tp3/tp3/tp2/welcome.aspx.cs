using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp2
{
    public partial class welcom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string l = "welcome ";
            HttpCookie firstn = Request.Cookies["firstn"];
            HttpCookie lastn = Request.Cookies["lastn"];

            if (firstn != null)
            {
                l+= firstn.Value+" ";
            }
            if (lastn != null)
            {
                l += lastn.Value + " ";
            }
            Label1.Text = l;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie firstn = new HttpCookie("firstn");
            HttpCookie lastn = new HttpCookie("lastn");
            firstn.Value = "";
            lastn.Value = "";
            firstn.Expires = DateTime.Now;
            lastn.Expires = DateTime.Now;
            Response.Cookies.Add(firstn);
            Response.Cookies.Add(lastn);
            Response.Redirect("signIn.aspx");
        }
    }
}