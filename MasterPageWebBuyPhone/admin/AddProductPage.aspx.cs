using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageWebBuyPhone.admin
{
    public partial class AddProductPage : System.Web.UI.Page
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

        protected void CheckChooseManufacturer(object source, ServerValidateEventArgs args)
        {
            if (ListManufacturer.SelectedValue.Equals("Select Manufacturer"))
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
                btnSaveProduct();
            }
        }
        protected void btnSaveProduct()
        {
            Product product = new Product();
            product.SIM = SIM.Text;
            String idManufacturer = (from p in db.Manufacturers
                                     where p.Name_Manufacturer == ListManufacturer.SelectedValue
                                     select p.Id_Manufacturer).FirstOrDefault().ToString();
            String Id = "PRD-" + DateTime.Now.ToString("HH:mm:ss:ffffff");
            product.ID_Product = Id;
            product.ID_Manufacturer = idManufacturer;
            product.Name_Product = Name.Text;
            product.Price_Product = (float)Convert.ToDouble(Price.Text);
            product.Screen = Screen.Text;
            product.Operating = Operating.Text;
            product.FrontCamera = FrontCamera.Text;
            product.RearCamera = RearCamera.Text;
            product.CPU = CPU.Text;
            product.RAM = RAM.Text;
            product.InternalMemory = InternalMemory.Text;
            product.MemoryStick = MemoryStick.Text;
            product.Battery = BatteryCapacity.Text;
            product.Details = DetailsProduct.Text;
            product.Newfeature = Newfeature.Text;
            product.Active = true;
            product.Img_Product = "/admin/Images/" + FileUpload.FileName.ToString();
            FileUpload.SaveAs(Request.PhysicalApplicationPath + "/admin/Images/" + FileUpload.FileName.ToString());
            db.Products.InsertOnSubmit(product);
            db.SubmitChanges();
            Response.Redirect("AddProductPage.aspx");
        }
    }
}