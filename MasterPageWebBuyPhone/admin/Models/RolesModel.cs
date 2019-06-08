using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterPageWebBuyPhone.admin.Models
{
    public class RolesModel
    {
        public String Username { get; set; }
        public Boolean C_Register { get; set; }
        public Boolean R_Register { get; set; }
        public Boolean U_Register { get; set; }
        public Boolean D_Register { get; set; }
        public Boolean C_Product { get; set; }
        public Boolean R_Product { get; set; }
        public Boolean U_Product { get; set; }
        public Boolean D_Product { get; set; }
        public Boolean C_Roles { get; set; }
    }
}