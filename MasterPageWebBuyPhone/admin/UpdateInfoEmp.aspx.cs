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
        private DBDataContext db = new DBDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var info = (from p in db.Employees
                            where p.ID_Emp == Request["id"]
                            select p).Single();
                FullName.Text = info.FullName;
                Email.Text = info.Email;
                Phone.Text = info.Phone;
                Address.Text = info.Address;
                Passport.Text = info.Passport;
                Birthday.Text = Convert.ToString(info.Birthday);
                Boolean checkSex = Convert.ToBoolean(info.Sex);
                if (checkSex) {
                    Male.Checked = true;
                    Female.Checked = false;
                }
                else
                {
                    Male.Checked = false;
                    Female.Checked = true;
                }
            }
        }
        
        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            Employee Emp = db.Employees.SingleOrDefault(p => p.ID_Emp == Request["id"]);
            {
                Emp.Address = Address.Text.ToString();
                Emp.Birthday = Convert.ToDateTime(Birthday.Text);
                Emp.Email = Email.Text.ToString();
                Emp.FullName = FullName.Text.ToString();
                Emp.Passport = Passport.Text.ToString();
                Emp.Phone = Phone.Text.ToString();
                if (Female.Checked)
                {
                    Emp.Sex = false;
                }
                else
                {
                    Emp.Sex = true;
                }
            }
            db.SubmitChanges();
            Response.Redirect("ListEmployees.aspx");
        }
    }
}