using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageWebBuyPhone.admin
{
    public partial class UpdateInfoEmp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListQuestion.Items.Add("What is the first phone number you use?");
                ListQuestion.Items.Add("What is your first girlfriend's name?");
                ListQuestion.Items.Add("Which animal do you like best?");
                ListQuestion.Items.Add("Which subject do you like best?");
                ListQuestion.Items.Add("Which car company do you like best?");
            }
        }
        protected void CheckConfirmAnwser(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                if (Answer.Text.Equals(ConfirmAnswer.Text))
                {

                    args.IsValid = true;
                    btnUpdate_Click();
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void btnUpdate_Click()
        {

        }
    }
}