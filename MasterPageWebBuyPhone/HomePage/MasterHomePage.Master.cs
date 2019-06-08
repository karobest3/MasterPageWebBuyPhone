using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageWebBuyPhone.HomePage
{
    public partial class MasterHomePage : System.Web.UI.MasterPage
    {
        private DBDataContext db = new DBDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            RepterDetails.DataSource = db.Manufacturers.Select(p => p).Where(p => p.Active.Equals(1));
            RepterDetails.DataBind();
        }
        protected void loadPageProduct(object sender, EventArgs e)
        {

            LinkButton button = (LinkButton)sender;
            string buttonText = button.Text;
            string ID = (from p in db.Manufacturers
                         where p.Name_Manufacturer == buttonText
                         select p.Id_Manufacturer).Single();
            Response.Redirect("ProductsPage.aspx?Id_Manufacturer=" + ID);

        }
    }
}