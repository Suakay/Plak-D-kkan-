using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak_Data.Entity
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Security.Cryptography;

    public class ŞifreHelper
    {
        public static string Sha256Hash(string sifre)
        {
            using (SHA256 hash = SHA256.Create()) 
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
    }

}
