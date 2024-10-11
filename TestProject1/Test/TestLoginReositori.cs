using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messager.BLL.Validetion;

namespace TestProject1.Test;

[TestFixture]
internal class TestLoginReositori
{
    [Test]
    public async Task LoginTestEmailNULLCheck()
    {
        var Log = new LoginValue();

        string Email = " ";
        string Password = "0555355041Ggame";

        var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
        await Log.LoginVal(Email, Password));

        Assert.That(ex.Message, Is.EqualTo("Поле почты осталось пустым или введено не корректно"));
    }
    [Test]
    public async Task LoginTestPasslNULLCheck()
    {
        var Log = new LoginValue();

        string Email = "skochik-2003@mail.ru";
        string Password = "";

        var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
        await Log.LoginVal(Email, Password));

        Assert.That(ex.Message, Is.EqualTo("Поле пароля осталось пустым или введено не корректно"));
    }
    [Test]
    public async Task LoginTestNULLCheck()
    {
        var Log = new LoginValue();

        string Email = " ";
        string Password = " ";

        var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
        await Log.LoginVal(Email, Password));

        Assert.That(ex.Message, Is.EqualTo("Поле почты осталось пустым или введено не корректно"));
    }

    [Test]
    public async Task LoginTestGoodCheck()
    {
        var Log = new LoginValue();

        string Email = "Skochik-2003@mail.ru";
        string Password = "1234132123";

        var res = Log.LoginVal(Email, Password);

        Assert.IsNotNull(res);
    }
}
