using Messager.BLL.HashPass;
using Messager.DAL.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messager.DAL.Repositori;

internal class LoginRepository
{
    public async Task Login(string Email, string Password)
    {
        using (MessagerDataBase dataBase = new())
        {
            var person = dataBase.UserDataBase.FirstOrDefault(x => x.Email == Email && x.Password == Password);

            HashPassword hash = new HashPassword();

            var res = hash.Hash(Password);

            if (person != null )
            {
                Console.WriteLine("Вы успешно вошли в аккаунт!");
                await dataBase.SaveChangesAsync();
            }
            else
            {
                Console.WriteLine("Пользователь с такими данными не найден");
            }
        }
    }
}
