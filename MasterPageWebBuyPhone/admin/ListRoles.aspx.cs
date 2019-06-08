using MasterPageWebBuyPhone.admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageWebBuyPhone.admin
{
    public partial class ListRoles : System.Web.UI.Page
    {
        private DBDataContext db = new DBDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListRole.Items.Add("Register");
                ListRole.Items.Add("Manufacturer");
                ListRole.Items.Add("Product");
                ListRole.Items.Add("Decentralization");
                Gv_Bind();
            }
        }
        protected void Gv_Bind()
        {
            LoadGridViewChoose();
            List<RolesModel> list_Roles = getRole();
            GridViewRoles.DataSource = list_Roles;
            GridViewRoles.DataBind();
        }
        protected List<RolesModel> getRole() {
            List<RolesModel> list_Roles = new List<RolesModel>();
            var list = db.Roles.Select(p => p);
            foreach (var item in list)
            {
                RolesModel roles = new RolesModel();
                roles.Username = item.Username;
                roles.C_Roles = Convert.ToBoolean(item.Role_Roles);
                // xu ly role register           
                String binary = Convert.ToString(Convert.ToInt32(item.Role_Register), 2);
                if (binary.Length.Equals(3)) {
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
                roles.C_Register = getValueBoolean(Convert.ToString(binary[0]));
                roles.R_Register = getValueBoolean(Convert.ToString(binary[1]));
                roles.U_Register = getValueBoolean(Convert.ToString(binary[2]));
                roles.D_Register = getValueBoolean(Convert.ToString(binary[3]));
                // xu ly role product
                binary = Convert.ToString(Convert.ToInt32(item.Role_Product), 2);
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
                roles.C_Product = getValueBoolean(Convert.ToString(binary[0]));
                roles.R_Product = getValueBoolean(Convert.ToString(binary[1]));
                roles.U_Product = getValueBoolean(Convert.ToString(binary[2]));
                roles.D_Product = getValueBoolean(Convert.ToString(binary[3]));
                //Xu ly role Manufacturer
                binary = Convert.ToString(Convert.ToInt32(item.Roles_Manufacturer), 2);
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
                roles.C_Manufacturer = getValueBoolean(Convert.ToString(binary[0]));
                roles.R_Manufacturer = getValueBoolean(Convert.ToString(binary[1]));
                roles.U_Manufacturer = getValueBoolean(Convert.ToString(binary[2]));
                roles.D_Manufacturer = getValueBoolean(Convert.ToString(binary[3]));
                list_Roles.Add(roles);
            }
            return list_Roles;
        }
        protected void EditGridView(object sender, GridViewEditEventArgs e)
        {
            GridViewRoles.EditIndex = e.NewEditIndex;
            ListRole.Enabled = false;
            Gv_Bind();
        }
        protected void CancelGridView(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewRoles.EditIndex = -1;
            ListRole.Enabled = true;
            Gv_Bind();
        }
        protected void UpdateGridView(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridViewRoles.Rows[e.RowIndex];
            String username = GridViewRoles.DataKeys[e.RowIndex].Value.ToString();
            CheckBox C_Register = row.Cells[1].Controls[0] as CheckBox;
            CheckBox R_Register = row.Cells[2].Controls[0] as CheckBox;
            CheckBox U_Register = row.Cells[3].Controls[0] as CheckBox;
            CheckBox D_Register = row.Cells[4].Controls[0] as CheckBox;
            CheckBox C_Product = row.Cells[5].Controls[0] as CheckBox;
            CheckBox R_Product = row.Cells[6].Controls[0] as CheckBox;
            CheckBox U_Product = row.Cells[7].Controls[0] as CheckBox;
            CheckBox D_Product = row.Cells[8].Controls[0] as CheckBox;
            CheckBox C_Decentralization = row.Cells[9].Controls[0] as CheckBox;
            CheckBox C_Manufacturer = row.Cells[10].Controls[0] as CheckBox;
            CheckBox R_Manufacturer = row.Cells[11].Controls[0] as CheckBox;
            CheckBox U_Manufacturer = row.Cells[12].Controls[0] as CheckBox;
            CheckBox D_Manufacturer = row.Cells[13].Controls[0] as CheckBox;
            int valueRole = 0;
            Role role = db.Roles.SingleOrDefault(p => p.Username == username);

            if (ListRole.SelectedValue.Equals("Register"))
            {
                valueRole = GetValueRole(C_Register.Checked, R_Register.Checked,
                U_Register.Checked, D_Register.Checked);
                role.Role_Register = valueRole;
            }
            else if (ListRole.SelectedValue.Equals("Product"))
            {
                valueRole = GetValueRole(C_Product.Checked, R_Product.Checked,
                U_Product.Checked, D_Product.Checked);
                role.Role_Product = valueRole;
            }
            else if (ListRole.SelectedValue.Equals("Decentralization")) {
                role.Role_Roles = C_Decentralization.Checked;
            }
            else if (ListRole.SelectedValue.Equals("Manufacturer")){
                valueRole = GetValueRole(C_Manufacturer.Checked, R_Manufacturer.Checked,
                U_Manufacturer.Checked, D_Manufacturer.Checked);
                role.Roles_Manufacturer = valueRole;
            }
            GridViewRoles.EditIndex = -1;//cho phep khi bam update se thoat khỏi tình trạng edit
            ListRole.Enabled = true;
            db.SubmitChanges();
            Gv_Bind();
        }
        protected Boolean getValueBoolean(String s)
        {
            if (s.Equals("1"))
            {
                return true;
            }
            return false;
        }

        protected void LoadGridViewChoose()
        {
            String Chosse = ListRole.SelectedValue;
            switch (Chosse)
            {
                case "Register":
                    LoadRegister();
                    break;
                case "Product":
                    LoadProduct();
                    break;
                case "Decentralization":
                    LoadDecentralization();
                    break;
                case "Manufacturer":
                    LoadManufacturer();
                    break;
                default:
                    LoadRegister();
                    break;
            }
        }
        protected void LoadRegister()
        {
            GridViewRoles.Columns[1].Visible = true;
            GridViewRoles.Columns[2].Visible = true;
            GridViewRoles.Columns[3].Visible = true;
            GridViewRoles.Columns[4].Visible = true;
            GridViewRoles.Columns[5].Visible = false;
            GridViewRoles.Columns[6].Visible = false;
            GridViewRoles.Columns[7].Visible = false;
            GridViewRoles.Columns[8].Visible = false;
            GridViewRoles.Columns[9].Visible = false;
            GridViewRoles.Columns[10].Visible = false;
            GridViewRoles.Columns[11].Visible = false;
            GridViewRoles.Columns[12].Visible = false;
            GridViewRoles.Columns[13].Visible = false;
        }
        protected void LoadProduct()
        {
            GridViewRoles.Columns[1].Visible = false;
            GridViewRoles.Columns[2].Visible = false;
            GridViewRoles.Columns[3].Visible = false;
            GridViewRoles.Columns[4].Visible = false;
            GridViewRoles.Columns[5].Visible = true;
            GridViewRoles.Columns[6].Visible = true;
            GridViewRoles.Columns[7].Visible = true;
            GridViewRoles.Columns[8].Visible = true;
            GridViewRoles.Columns[9].Visible = false;
            GridViewRoles.Columns[10].Visible = false;
            GridViewRoles.Columns[11].Visible = false;
            GridViewRoles.Columns[12].Visible = false;
            GridViewRoles.Columns[13].Visible = false;
        }
        protected void LoadDecentralization()
        {
            GridViewRoles.Columns[1].Visible = false;
            GridViewRoles.Columns[2].Visible = false;
            GridViewRoles.Columns[3].Visible = false;
            GridViewRoles.Columns[4].Visible = false;
            GridViewRoles.Columns[5].Visible = false;
            GridViewRoles.Columns[6].Visible = false;
            GridViewRoles.Columns[7].Visible = false;
            GridViewRoles.Columns[8].Visible = false;
            GridViewRoles.Columns[9].Visible = true;
            GridViewRoles.Columns[10].Visible = false;
            GridViewRoles.Columns[11].Visible = false;
            GridViewRoles.Columns[12].Visible = false;
            GridViewRoles.Columns[13].Visible = false;
        }
        protected void LoadManufacturer()
        {
            GridViewRoles.Columns[1].Visible = false;
            GridViewRoles.Columns[2].Visible = false;
            GridViewRoles.Columns[3].Visible = false;
            GridViewRoles.Columns[4].Visible = false;
            GridViewRoles.Columns[5].Visible = false;
            GridViewRoles.Columns[6].Visible = false;
            GridViewRoles.Columns[7].Visible = false;
            GridViewRoles.Columns[8].Visible = false;
            GridViewRoles.Columns[9].Visible = false;
            GridViewRoles.Columns[10].Visible = true;
            GridViewRoles.Columns[11].Visible = true;
            GridViewRoles.Columns[12].Visible = true;
            GridViewRoles.Columns[13].Visible = true;
        }


        protected void LoadGridView(object sender, EventArgs e)
        {
            Gv_Bind();
        }
        protected int GetValueRole(Boolean value_1, Boolean value_2, Boolean value_3, Boolean value_4) {
            int result = 0;
            String stringValue1 = "0";
            String stringValue2 = "0";
            String stringValue3 = "0";
            String stringValue4 = "0";
            if (value_1) stringValue1 = "1";
            if (value_2) stringValue2 = "1";
            if (value_3) stringValue3 = "1";
            if (value_4) stringValue4 = "1";
            String s = stringValue1 + stringValue2 + stringValue3 + stringValue4;
            result = Convert.ToInt32(s, 2);
            return result;
        }
    }
}