using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageWebBuyPhone.admin
{
    public partial class ListProducts : System.Web.UI.Page
    {
        private DBDataContext db = new DBDataContext();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListManufacturer.Items.Add("Select Manufacturer");
                ListManufacturer.Items.FindByValue("Select Manufacturer").Attributes.Add("disabled", "disabled");
                ListManufacturer.Items.FindByValue("Select Manufacturer").Selected = true;
                GetNameManufacturer();
            }
          
        }     
        protected void EditGridView(object sender, GridViewEditEventArgs e)
        {
            GridViewProduct.EditIndex = e.NewEditIndex;
        }
        protected void GV_Bind()
        {
            ListManufacturer.Items.FindByValue("Select Manufacturer").Attributes.Add("disabled", "disabled");
            GridViewProduct.DataSource = LoadData();
            GridViewProduct.DataBind();
        }
        protected void GetNameManufacturer()
        {
            var list = (from p in db.Manufacturers
                        where p.Active == true
                        select p.Name_Manufacturer).ToList();
            foreach (var item in list)
            {
                ListManufacturer.Items.Add(item);
            }
        }
        protected List<Product> LoadData()
        {

            String id = (from p in db.Manufacturers
                         where p.Name_Manufacturer == ListManufacturer.SelectedValue
                         select p.Id_Manufacturer).Single();
            List<Product> List = db.Products.Select(p => p).Where(p => p.Active == true && p.ID_Manufacturer== id).ToList();
            return List;
        }

        protected void LoadGridView(object sender, EventArgs e)
        {
            GV_Bind();
        }
    }
}