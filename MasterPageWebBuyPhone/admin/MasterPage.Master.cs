using MasterPageWebBuyPhone.admin.Models;
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
                if (String.IsNullOrEmpty(Secret_Answer) && !path.Equals("/admin/UpdateInfoEmp.aspx"))
                {
                    Response.Redirect("UpdateInfoEmp.aspx");

                }

                else
                {
                    String pathRuning = HttpContext.Current.Request.Url.AbsolutePath;
                    userLogin.Text = Request.Cookies["Username"].Value;
                    RolesModel role = checkRole_Register();
                    if (!role.C_Register) {
                        Register.Visible = false;
                        if (pathRuning.Equals("/admin/RegisterPage.aspx"))
                        {
                            Response.Redirect("HomeAdmin.aspx");
                        }
                    }
                    if (!role.C_Manufacturer)
                    {
                        addManufacturer.Visible = false;
                        if (pathRuning.Equals("/admin/AddManufacturerPage.aspx"))
                        {
                            Response.Redirect("HomeAdmin.aspx");
                        }
                    }
                    RepterDetails.DataSource = db.Manufacturers.Select(p => p).Where(p => p.Active.Equals(1));
                    RepterDetails.DataBind();
                }
            }
        }
        protected RolesModel checkRole_Register()
        {
            RolesModel role = new RolesModel();
            var roleSQL = db.Roles.Select(p => p)
                .Where(p => p.Username == Request.Cookies["Username"].Value)
                .Single();
            role.Username = roleSQL.Username;
            role.C_Roles = Convert.ToBoolean(roleSQL.Role_Roles);
            // xu ly role register           
            String binary = Convert.ToString(Convert.ToInt32(roleSQL.Role_Register), 2);
            if (binary.Length.Equals(3))
            {
                binary = "0" + binary;
            }
            if (binary.Length.Equals(2))
            {
                binary = "00" + binary;
            }
            if (binary.Length.Equals(1))
            {
                binary = "000" + binary;
            }
            role.C_Register = getValueBoolean(Convert.ToString(binary[0]));
            role.R_Register = getValueBoolean(Convert.ToString(binary[1]));
            role.U_Register = getValueBoolean(Convert.ToString(binary[2]));
            role.D_Register = getValueBoolean(Convert.ToString(binary[3]));
            // xu ly role product
            binary = Convert.ToString(Convert.ToInt32(roleSQL.Role_Product), 2);
            if (binary.Length.Equals(3))
            {
                binary = "0" + binary;
            }
            if (binary.Length.Equals(2))
            {
                binary = "00" + binary;
            }
            if (binary.Length.Equals(1))
            {
                binary = "000" + binary;
            }
            role.C_Product = getValueBoolean(Convert.ToString(binary[0]));
            role.R_Product = getValueBoolean(Convert.ToString(binary[1]));
            role.U_Product = getValueBoolean(Convert.ToString(binary[2]));
            role.D_Product = getValueBoolean(Convert.ToString(binary[3]));
            //
            binary = Convert.ToString(Convert.ToInt32(roleSQL.Roles_Manufacturer), 2);
            if (binary.Length.Equals(3))
            {
                binary = "0" + binary;
            }
            if (binary.Length.Equals(2))
            {
                binary = "00" + binary;
            }
            if (binary.Length.Equals(1))
            {
                binary = "000" + binary;
            }
            role.C_Manufacturer = getValueBoolean(Convert.ToString(binary[0]));
            role.R_Manufacturer = getValueBoolean(Convert.ToString(binary[1]));
            role.U_Manufacturer = getValueBoolean(Convert.ToString(binary[2]));
            role.D_Manufacturer = getValueBoolean(Convert.ToString(binary[3]));
            return role;
        }
        protected Boolean getValueBoolean(String s)
        {
            if (s.Equals("1"))
            {
                return true;
            }
            return false;
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