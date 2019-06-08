using MasterPageWebBuyPhone.admin.Commons;
using MasterPageWebBuyPhone.admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageWebBuyPhone.admin.pagelist
{
    public partial class ListManufacturer : System.Web.UI.Page
    {
        private DBDataContext db = new DBDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack) {
                GV_Bind();
                
            }
            Decentralization();
        }
        protected void Decentralization() {
           
            RolesModel role = CheckDecentralization.checkRole_Register(Request.Cookies["Username"].Value);
            foreach (GridViewRow row in GridViewManufacturer.Rows)
            {
                if (!role.U_Manufacturer) {
                    row.Cells[2].Enabled = false;
                }
                if (!role.D_Manufacturer) {
                    row.Cells[3].Enabled = false;
                 }
            }
        }
        protected void GV_Bind()
        {
            GridViewManufacturer.DataSource = db.Manufacturers.Select(p => p).Where(p => p.Active == true);
            GridViewManufacturer.DataBind();
        }
        protected void EditGridView(object sender, GridViewEditEventArgs e)
        {
            GridViewManufacturer.EditIndex = e.NewEditIndex;
            GV_Bind();
        }
        protected void CancelGridView(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewManufacturer.EditIndex = -1;
            GV_Bind();
        }
        protected void UpdateGridView(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridViewManufacturer.Rows[e.RowIndex];
            String ID = GridViewManufacturer.DataKeys[e.RowIndex].Value.ToString();
            TextBox NameManufacturer= row.Cells[1].Controls[0] as TextBox;
            Manufacturer manufacturer = db.Manufacturers.SingleOrDefault(p => p.Id_Manufacturer == ID);
            manufacturer.Name_Manufacturer = NameManufacturer.Text.ToString();
            GridViewManufacturer.EditIndex = -1;
            db.SubmitChanges();
            GV_Bind();
        }
        protected void DeleteGridView(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridViewManufacturer.Rows[e.RowIndex];
            String ID = GridViewManufacturer.DataKeys[e.RowIndex].Value.ToString();
            Product product = db.Products.SingleOrDefault(p => p.ID_Manufacturer == ID);
            product.Active = false;
            db.SubmitChanges();
            Manufacturer manufacturer = db.Manufacturers.SingleOrDefault(p => p.Id_Manufacturer == ID);
            manufacturer.Active = false;
            GridViewManufacturer.EditIndex = -1;
            db.SubmitChanges();
            GV_Bind();
        }

    }
}