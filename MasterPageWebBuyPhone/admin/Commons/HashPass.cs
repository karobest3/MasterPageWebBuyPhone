using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace MasterPageWebBuyPhone.admin
{
    public static class HashPass
    {
        public static String GetPass(String pass) {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < result.Length; i++) {
                str.Append(result[i].ToString("x2"));
            }
            return str.ToString();
        }
    }
}