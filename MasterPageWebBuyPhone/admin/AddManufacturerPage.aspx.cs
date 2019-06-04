using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageWebBuyPhone.admin
{
    public partial class AddManufacturerPage1 : System.Web.UI.Page
    {
        private DBDataContext db = new DBDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAddManufacturer(object sender, EventArgs e)
        {
            Manufacturer MF = new Manufacturer();
            String Id = "MNF-" + DateTime.Now.ToString("HH:mm:ss:ffffff");
            MF.Id_Manufacturer = Id;
            MF.Name_Manufacturer = NameMNF.Text.ToString();
            MF.Active = true;
            db.Manufacturers.InsertOnSubmit(MF);
            db.SubmitChanges();
            Response.Redirect("AddManufacturerPage.aspx");
        }
    }
}