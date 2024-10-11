using Messager.DAL.DataBase;
using Messager.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messager.DAL.Repositori;

internal class FriendsRepositori
{
    public async Task SearchForFriends(string Email)
    {
        using (MessagerDataBase DataBase = new())
        {
            var person = DataBase.UserDataBase.FirstOrDefault(x => x.Email == Email);
            if (person != null)
            {
                Console.WriteLine($"Найден пользователь: {person.Name}");

                var newFriend = new UserFriendsDataBaseEntity(person.Name, person.MiddleName, person.Email, person.UserId);

                await DataBase.UserFriendsDataBase.AddAsync(newFriend);

                await DataBase.SaveChangesAsync();

                Console.WriteLine($"Вы успешно добавили пользователя {person.Name}");
            }else
            {
                Console.WriteLine("Пользователя с такой почтой не найдено");
            }
        }
    }

}
