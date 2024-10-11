using Messager.DAL.Repositori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messager.BLL.Validetion;

public class LoginValue
{
    public async Task LoginVal(string Email, string Password)
    {
        if (string.IsNullOrWhiteSpace(Email))
        {
            throw new ArgumentException("Поле почты осталось пустым или введено не корректно");
        }

        if (string.IsNullOrWhiteSpace(Password))
        {
            throw new ArgumentException("Поле пароля осталось пустым или введено не корректно");
        }

        LoginRepository loginRepository = new();
        
        await loginRepository.Login(Email, Password);
    }
}
