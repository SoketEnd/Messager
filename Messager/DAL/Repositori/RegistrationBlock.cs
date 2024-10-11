using Messager.BLL.HashPass;
using Messager.DAL.DataBase;
using Messager.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messager.DAL.Repositori;

class RegistrationBlock
{
    public async Task Registration(string Name, string MiddleName, string Email, string Password)
    {
        using (MessagerDataBase DataBase = new())
        {
            var person = DataBase.UserDataBase.FirstOrDefault(x => x.Email == Email);

            if (person != null)
            {
                throw new Exception("Пользователь с данной почтой уже существует");
            }

            HashPassword hash = new HashPassword();

            await DataBase.UserDataBase.AddAsync(new UserDataBaseEntity(Name, MiddleName, Email, Password));

            hash.Hash(Password);

            await DataBase.SaveChangesAsync();
        }
    }
}
