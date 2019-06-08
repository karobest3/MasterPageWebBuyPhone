using MasterPageWebBuyPhone.admin.Commons;
using MasterPageWebBuyPhone.admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageWebBuyPhone.admin
{
    public partial class ListEmployees : System.Web.UI.Page
    {
        private DBDataContext db = new DBDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GV_Bind();
            }
            Decentralization();
        }
        protected void Decentralization()
        {
            String pathRuning = HttpContext.Current.Request.Url.AbsolutePath;
            RolesModel role = CheckDecentralization.checkRole_Register(Request.Cookies["Username"].Value);
            foreach (GridViewRow row in GridViewEmp.Rows)
            {
                if (!role.U_Register)
                {
                    row.Cells[8].Enabled = false;
                    if (pathRuning.Equals("/admin/UpdateInfoEmp.aspx"))
                    {
                        Response.Redirect("HomeAdmin.aspx");
                    }
                }
                if (!role.D_Register)
                {
                    row.Cells[9].Enabled = false;
                }
            }
        }
        protected void GV_Bind()
        {
            String ID_Emp_Login = (from p in db.AccountEmps
                                   where p.Username == Request.Cookies["Username"].Value
                                   select p.ID_Emp).Single();
            GridViewEmp.DataSource = db.Employees.Select(p => p).Where(p => p.ID_Emp != ID_Emp_Login);
            GridViewEmp.DataBind();
            FormatSex();
        }
        protected void FormatSex()
        {
            foreach (GridViewRow row in GridViewEmp.Rows)
            {
                if (row.Cells[8].Text.Equals("True"))
                {
                    row.Cells[8].Text = "Male";
                }
                else if (row.Cells[8].Text.Equals("False"))
                {
                    row.Cells[8].Text = "Female";
                }
            }
        }

        protected void DeleteGridView(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridViewEmp.Rows[e.RowIndex];
            String ID = GridViewEmp.DataKeys[e.RowIndex].Value.ToString();
            // Delete Role with Id Account
            var account = (from p in db.AccountEmps
                           where p.ID_Emp == ID
                           select p).First();
            var IdDeleteInRole = (from p in db.Roles
                                  where p.ID_Account == account.ID_Account
                                  select p).First();
            db.Roles.DeleteOnSubmit(IdDeleteInRole);
            db.SubmitChanges();
            // Delete Account
            db.AccountEmps.DeleteOnSubmit(account);
            db.SubmitChanges();
            // Delete Employees
            var emp = (from p in db.Employees
                       where p.ID_Emp == ID
                       select p).First();
            db.Employees.DeleteOnSubmit(emp);
            db.SubmitChanges();
            GV_Bind();
        }

        protected void EditGridView(object sender, GridViewEditEventArgs e)
        {
            String ID = GridViewEmp.DataKeys[e.NewEditIndex].Value.ToString();
            Response.Redirect("UpdateInfoEmp.aspx?ID=" + ID);
        }
    }
}