using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Messager.BLL.HashPass;

internal class HashPassword
{
    public string Hash(string Password)
    {
        using (var sha256 = SHA256.Create())
        {
            var bytes = Encoding.UTF8.GetBytes(Password);

            var HaasPass = sha256.ComputeHash(bytes);

            return Convert.ToBase64String(HaasPass);
        }
    }
}
