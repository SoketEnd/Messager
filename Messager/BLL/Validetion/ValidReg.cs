using Messager.DAL.Repositori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messager.BLL.Validetion;

public class ValidReg
{
    public async Task ValidRegCheck(string Name, string LastName, string Mail, string Password)
    {
        if (string.IsNullOrWhiteSpace(Name)) throw new ArgumentException("Поле 'Имя' осталось пустым");

        if (string.IsNullOrWhiteSpace(LastName)) throw new ArgumentException("Поле 'Фамилия' осталось пустым");

        if (string.IsNullOrWhiteSpace(Mail)) throw new ArgumentException("Поле 'почта' осталось пустым");

        if (string.IsNullOrWhiteSpace(Password)) throw new ArgumentException("Поле 'пароля' осталось пустым");

        RegistrationBlock registrationBlock = new RegistrationBlock();

        await registrationBlock.Registration(Name, LastName, Mail, Password);
    }
}
