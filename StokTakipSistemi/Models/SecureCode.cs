using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Models
{
    internal class SecureCode
    {

        

        public static string GetSecureCode() {
            string catalog = "0123456789abcdefghjkmnoprstuvyzwxABCDEFGHJKLMNOPRSTUVYZWX0123456789";
            List<char> secureCodeArray = new List<char>();
            string secureCode = "";
            byte IndexNo = 0;
            Random random = new Random();
            while (secureCodeArray.Count < 5)
            {

                secureCodeArray.Add(catalog[random.Next(catalog.Length)]);
                secureCode += secureCodeArray[IndexNo];
                IndexNo++;

            }
            return secureCode;
        } 
}
}
