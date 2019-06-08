using MasterPageWebBuyPhone.admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterPageWebBuyPhone.admin.Commons
{
    public static class CheckDecentralization
    {
        static DBDataContext db = new DBDataContext();
        public static RolesModel checkRole_Register(String Username)
        {
            RolesModel role = new RolesModel();
            var roleSQL = db.Roles.Select(p => p)
                .Where(p => p.Username == Username)
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
        public static Boolean getValueBoolean(String s)
        {
            if (s.Equals("1"))
            {
                return true;
            }
            return false;
        }
    }
}