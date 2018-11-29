using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Security.Cryptography;

namespace BizzLayer
{
    public class LoginSection
    {
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public static Personel Login(string uname, string pass)
        {
            var conn = new DataLayer.DataClasses1DataContext();
            Personel user = (from a in conn.Personel
                             where a.uname == uname && a.password == MD5Hash(pass)
                             select a).SingleOrDefault();
            return user;
        }
    }
}
