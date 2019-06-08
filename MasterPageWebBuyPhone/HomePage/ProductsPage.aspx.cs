using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageWebBuyPhone.HomePage
{
    public partial class ProductsPage : System.Web.UI.Page
    {
        private DBDataContext db = new DBDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            RepterDetails.DataSource = db.Products.Select(p => p).Where(p => p.Active.Equals(1)&&p.ID_Manufacturer.Equals(Request["Id_Manufacturer"]));
            RepterDetails.DataBind();
        }
    }
}