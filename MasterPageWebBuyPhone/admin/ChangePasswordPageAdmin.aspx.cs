using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageWebBuyPhone.admin
{
    public partial class ChangePasswordPageAdmin : System.Web.UI.Page
    {
        private DBDataContext db = new DBDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CustomPassValided(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                if (NewPasswordConfirm.Text.Equals(NewPassword.Text))
                {

                    args.IsValid = true;
                    btnChangePass_Click();
                }
                else
                {
                    args.IsValid = false;

                }
            }
        }
        protected void btnChangePass_Click() {
            AccountEmp accountEmp = db.AccountEmps.SingleOrDefault
                (p => p.Username == Request.Cookies["Username"].Value);
            accountEmp.Password = HashPass.GetPass(NewPassword.Text);
            db.SubmitChanges();
            
            Response.Cookies["Username"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("LoginAdmin.aspx");
        }
        protected void CheckOldPassword(object source, ServerValidateEventArgs args)
        {
            int checkOldPass =
            (from p in db.AccountEmps
             where p.Username == Request.Cookies["Username"].Value && p.Password == HashPass.GetPass(OldPassword.Text)
             select p).Count();
            if (checkOldPass.Equals(0))
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
                btnChangePass_Click();
            }
        }
    }
}