using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
namespace MasterPageWebBuyPhone.admin
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        private DBDataContext db = new DBDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){ 
                ListQuestion.Items.Add("What is the first phone number you use?");
                ListQuestion.Items.Add("What is your first girlfriend's name?");
                ListQuestion.Items.Add("Which animal do you like best?");
                ListQuestion.Items.Add("Which subject do you like best?");
                ListQuestion.Items.Add("Which car company do you like best?");
            }
        }
        protected void btnRegister_Click()
        {
            String IdEmp = "Emp-" + DateTime.Now.ToString("HH:mm:ss:ffffff");
            Employee Emp = new Employee();
            Emp.ID_Emp = IdEmp;
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
            //db.Employees.InsertOnSubmit(Emp);
            //db.SubmitChanges();
            AccountEmp Acc = new AccountEmp();
            String IdAcc = "Acc-" + DateTime.Now.ToString("HH:mm:ss:ffffff");

            Acc.Active = true;
            Acc.Username = Username.Text;
            Acc.Password = HashPass.GetPass(Password.Text);
            Acc.ID_Emp = IdEmp;
            Acc.ID_Account = IdAcc;
            Acc.Secret_Question = ListQuestion.SelectedItem.Text;
            Acc.Secret_Answer = Answer.Text;
            //db.AccountEmps.InsertOnSubmit(Acc);
            //db.SubmitChanges();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.Credentials = new System.Net.NetworkCredential
                ("karobest3@gmail.com","KKkk0902");
            smtpClient.UseDefaultCredentials = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage
                ("karobest3@gmail.com",Email.Text,"ID",Password.Text);
            using (var smtpClient1 = smtpClient)
            {
                smtpClient1.Send(mail);
            }
            Response.Redirect("RegisterPage.aspx");

        }

        protected void CustomPassValided(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                if (ConfirmPassword.Text.Equals(Password.Text))
                {
                    
                    args.IsValid = true;
                    btnRegister_Click();
                }
                else
                {
                    args.IsValid = false;

                }
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
                    btnRegister_Click();
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }
    }
}