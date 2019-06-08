using MasterPageWebBuyPhone.admin.Commons;
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
                Decentralization();
                userLogin.Text = Request.Cookies["Username"].Value;
            }
        }
        protected void Decentralization()
        {
            String pathRuning = HttpContext.Current.Request.Url.AbsolutePath;
            RolesModel role = CheckDecentralization.checkRole_Register(Request.Cookies["Username"].Value);
            if (!role.C_Register)
            {
                Register.Visible = false;
                if (pathRuning.Equals("/admin/RegisterPage.aspx"))
                {
                    Response.Redirect("HomeAdmin.aspx");
                }
            }
            if (!role.R_Register)
            {
                listEmp.Visible = false;
                if (pathRuning.Equals("/admin/ListEmployees.aspx"))
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
            if (!role.R_Manufacturer)
            {
                listMNF.Visible = false;
                if (pathRuning.Equals("/admin/ListManufacturer.aspx"))
                {
                    Response.Redirect("HomeAdmin.aspx");
                }
            }
            if (!role.C_Product)
            {
                AddProduct.Visible = false;
                if (pathRuning.Equals("/admin/AddProductPage.aspx"))
                {
                    Response.Redirect("HomeAdmin.aspx");
                }
            }

            if (!role.R_Product)
            {
                listProduct.Visible = false;
                if (pathRuning.Equals("/admin/ListProducts.aspx"))
                {
                    Response.Redirect("HomeAdmin.aspx");
                }
            }
            if (!role.C_Roles)
            {
                ListRoles.Visible = false;
                if (pathRuning.Equals("/admin/ListRoles.aspx"))
                {
                    Response.Redirect("HomeAdmin.aspx");
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

        protected void loadListEmp(object sender, EventArgs e)
        {
            Response.Redirect("ListEmployees.aspx");
        }
        protected void LoadListRoles(object sender, EventArgs e)
        {
            Response.Redirect("ListRoles.aspx");
        }
        protected void showPageChangePass(object sender, EventArgs e)
        {
            Response.Redirect("ChangePasswordPageAdmin.aspx");
        }
        protected void loadPageAddProduct(object sender, EventArgs e)
        {
            Response.Redirect("AddProductPage.aspx");
        }
        protected void loadListManufacturer(object sender, EventArgs e)
        {
            Response.Redirect("ListManufacturer.aspx");
        }
        protected void loadListProduct(object sender, EventArgs e)
        {
            Response.Redirect("ListProducts.aspx");
        }

    }
}