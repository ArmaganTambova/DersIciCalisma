using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace TechLib.Filters
{
    public class PasswordHash
    {
        public static byte[] ComputeSha256HashBinary(string RawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(RawData));
                return bytes;
            }
        }
    }
}