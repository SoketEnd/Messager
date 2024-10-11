using Messager;
using Messager.BLL.Validetion;

namespace TestProject1.Test;

[TestFixture]
public class TestRegRepositori
{
    [Test]
    public async Task TestCHekVak_1()
    {
        var VaReg = new ValidReg();

        string Name = "Эдуард";
        string MiddleName = "";
        string Email = "";
        string Password = "";

        var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
        await VaReg.ValidRegCheck(Name, MiddleName, Email, Password));

        Assert.That(ex.Message, Is.EqualTo("Поле 'Фамилия' осталось пустым"));
    }

    [Test]
    public async Task TestCHekVak_2()
    {
        var VaReg = new ValidReg();

        string Name = "Эдуард";
        string MiddleName = "Скочик";
        string Email = "";
        string Password = "";

        var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
        await VaReg.ValidRegCheck(Name, MiddleName, Email, Password));

        Assert.That(ex.Message, Is.EqualTo("Поле 'почта' осталось пустым"));
    }
    [Test]
    public async Task TestCHekVak_3()
    {
        var VaReg = new ValidReg();

        string Name = "Эдуард";
        string MiddleName = "Скочик";
        string Email = "skochik-2003@mail.ru";
        string Password = "";

        var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
        await VaReg.ValidRegCheck(Name, MiddleName, Email, Password));

        Assert.That(ex.Message, Is.EqualTo("Поле 'пароля' осталось пустым"));
    }
    [Test]
    public async Task TestCHekVak_4()
    {
        var VaReg = new ValidReg();

        string Name = "Эдуард";
        string MiddleName = "Скочик";
        string Email = "skochik-2003@mail.ru";
        string Password = "0555355041Ggame";

        var res = VaReg.ValidRegCheck(Name, MiddleName, Email, Password);

        Assert.IsNotNull(res);
    }
}