using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messager.BLL.Validetion; 

namespace TestProject1.Test;

[TestFixture]
class FriendTest
{
    [Test]
    public async Task TestNullFriendSearch()
    {
        var Friend = new ValidSearchFriend();

        string Email = " ";

        var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
        await Friend.ValidSearch(Email));

        Assert.That(ex.Message, Is.EqualTo("Поле почты осталось пустым"));
    }

    public async Task TestGoodFriendSearch()
    {
        var Friend = new ValidSearchFriend();

        string Email = "Sjochik-2003@mail.ru";

        var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
        await Friend.ValidSearch(Email));

        Assert.IsNotNull(ex);
    }
}
