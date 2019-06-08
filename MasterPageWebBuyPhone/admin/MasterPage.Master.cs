using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageWebBuyPhone
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        private DBDataContext db = new DBDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Username"] == null)
            {
                Response.Redirect("LoginAdmin.aspx");
            }
            else
            {
                // xử lý tài khoản chưa nhập thông tin thì trả về page Update
                String path = HttpContext.Current.Request.Url.AbsolutePath;
                String Secret_Answer =
               (from p in db.AccountEmps
                where p.Username == Request.Cookies["Username"].Value
                select p.Secret_Answer).Single();
                if (String.IsNullOrEmpty(Secret_Answer)&& !path.Equals("/admin/UpdateInfoEmp.aspx"))
                {
                    Response.Redirect("UpdateInfoEmp.aspx");
                    
                }

                else
                {
                    userLogin.Text = Request.Cookies["Username"].Value;
                    RepterDetails.DataSource = db.Manufacturers.Select(p => p).Where(p => p.Active.Equals(1));
                    RepterDetails.DataBind();
                }
            }
        }
        protected void Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeAdmin.aspx");
        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            Response.Cookies["Username"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("LoginAdmin.aspx");
        }

        protected void showPageInfo(object sender, EventArgs e)
        {
            Response.Redirect("UpdateInfoEmp.aspx");
        }

        protected void loadPageAddManu(object sender, EventArgs e)
        {
            Response.Redirect("AddManufacturerPage.aspx");
        }
        protected void loadPageProduct(object sender, EventArgs e)
        {

            LinkButton button = (LinkButton)sender;
            string buttonText = button.Text;
            Response.Cookies["Name_Manufacturer"].Value = buttonText;
            Response.Redirect("ProductsPage.aspx");

        }
        protected void loadListEmp(object sender, EventArgs e)
        {  
            Response.Redirect("pagelist/ListEmpPage.aspx");
        }
        protected void LoadListRoles(object sender, EventArgs e)
        {
            Response.Redirect("ListRoles.aspx");
        }
    }
}