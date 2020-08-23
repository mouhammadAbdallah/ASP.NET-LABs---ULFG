using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dtn.Text = "The date and time: " + DateTime.Now;
            labelMessage.Text = "";
        }

        protected void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                labelMessage.Text = "Your reservation has been processed.";
            }
        }

        protected void checkPhoneConfirmation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPhoneConfirmation.Checked)
            {
                textPhoneNumber.Enabled = true;
                validatorRequiredPhoneNumber.ValidationGroup =
                "AllValidators";
                validatorRegExPhoneNumber.ValidationGroup = "AllValidators";
            }
            else
            {
                textPhoneNumber.Enabled = false;
                validatorRequiredPhoneNumber.ValidationGroup = "";
                validatorRegExPhoneNumber.ValidationGroup = "";
            }
        }
    }
}