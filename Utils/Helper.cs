using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MandhegParkingSystem.Utils
{
    internal class Helper
    {
        public static string Hash(string input)
        {
            using (var hasher = SHA256.Create())
            {
                string output = "";
                var res = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
                foreach (var item in res)
                {
                    output += item.ToString("x2");
                }
                return output;
            }
        }
    }
}
