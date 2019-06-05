using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace MasterPageWebBuyPhone.admin
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        private DBDataContext db = new DBDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        protected void btnRegister_Click()
        {
            
           
            String IdEmp = "Emp-" + DateTime.Now.ToString("HH:mm:ss:ffffff");
            Employee Emp = new Employee();
            Emp.ID_Emp = IdEmp;
            Emp.Email = Email.Text.ToString();
            Emp.FullName = FullName.Text.ToString();
            Emp.Phone = Phone.Text.ToString();
            db.Employees.InsertOnSubmit(Emp);
            db.SubmitChanges();
            AccountEmp Acc = new AccountEmp();
            String IdAcc = "Acc-" + DateTime.Now.ToString("HH:mm:ss:ffffff");
            // Random Pass
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder passRandom = new StringBuilder(8);
            for (int i = 0; i < 8; i++)
            {
                passRandom.Append(characters[random.Next(characters.Length)]);
            }
            
            Acc.Active = true;
            Acc.Username = Username.Text;
            Acc.ID_Emp = IdEmp;
            Acc.ID_Account = IdAcc;
            Acc.Password = HashPass.GetPass(Convert.ToString(passRandom));
            Acc.Password = HashPass.GetPass(Convert.ToString(passRandom));
            db.AccountEmps.InsertOnSubmit(Acc);
            db.SubmitChanges();
            MailMessage mail = new MailMessage
              ("karobest3@gmail.com", Email.Text, "Account Login", "Username: "+Username.Text +" Password: "+passRandom.ToString());
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new System.Net.NetworkCredential
                ("karobest3@gmail.com", "KKkk0902");
            smtpClient.Send(mail);
            Response.Redirect("RegisterPage.aspx");    
        }
        protected void CheckUsername(object source, ServerValidateEventArgs args)
        {
            int checkUser =
            (from p in db.AccountEmps
             where p.Username == Username.Text
             select p).Count();
            if (checkUser.Equals(1))
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
                btnRegister_Click();
            }
        }
    }
}