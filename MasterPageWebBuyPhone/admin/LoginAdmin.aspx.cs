using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageWebBuyPhone.admin
{
    public partial class LoginAdmin : System.Web.UI.Page
    {
        private DBDataContext db = new DBDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            int UserAdmin =
            (from p in db.AccountEmps
             where p.Username == "admin"
             select p).Count();
            if (UserAdmin.Equals(0))
            {
                //Insert Emp
                String IdEmp = "Emp-" + DateTime.Now.ToString("HH:mm:ss:ffffff");
                Employee Emp = new Employee();
                Emp.ID_Emp = IdEmp;
                Emp.Address = "admin";
                Emp.Birthday = Convert.ToDateTime("2019-01-01");
                Emp.Email = "Admin@admin.com";
                Emp.FullName = "Admin";
                Emp.Passport = "Admin";
                Emp.Phone = "Admin";
                Emp.Sex = true;
                db.Employees.InsertOnSubmit(Emp);
                db.SubmitChanges();
                //Insert Account
                AccountEmp Acc = new AccountEmp();
                String IdAcc = "Acc-" + DateTime.Now.ToString("HH:mm:ss:ffffff");
                Acc.Active = true;
                Acc.Username = "admin";
                Acc.Password = HashPass.GetPass("admin");
                Acc.ID_Emp = IdEmp;
                Acc.ID_Account = IdAcc;
                Acc.Secret_Question = "What is the first phone number you use?";
                Acc.Secret_Answer = "admin";
                db.AccountEmps.InsertOnSubmit(Acc);
                db.SubmitChanges();
                //Insert Roles
                Role role = new Role();
                role.ID_Account = IdAcc;
                role.Username = "admin";
                role.Role_Register = 15;
                role.Role_Product = 15;
                role.Role_Roles = true;
                role.Roles_Manufacturer = 15;
                db.Roles.InsertOnSubmit(role);
                db.SubmitChanges();
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String user = Username.Text.ToString();
            String pass = Password.Text.ToString();
            var count = db.AccountEmps.Select(p => p).Where(p => (p.Username.Equals(user) && p.Password.Equals(HashPass.GetPass(pass)))).Count();
            if (count.Equals(0))
            {
                Password.Focus();
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Username or Password is Incorrect!!!');", true);
            }
            else
            {
                Response.Cookies["Username"].Value = user;
                Response.Redirect("HomeAdmin.aspx");
            }

        }
    }
}