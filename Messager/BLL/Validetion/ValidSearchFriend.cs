using Messager.DAL.Repositori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messager.BLL.Validetion;

public class ValidSearchFriend
{
    public async Task ValidSearch(string Email)
    {
        if (string.IsNullOrWhiteSpace(Email)) 
        {
            throw new ArgumentException("Поле почты осталось пустым");
        }

        FriendsRepositori friends = new();

        await friends.SearchForFriends(Email);
    }
}
