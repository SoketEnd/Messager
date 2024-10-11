using Messager.BLL.Validetion;
using Messager.DAL.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messager.DAL.Repositori;

internal class ActionRepository
{
    public async Task Altion()
    {
        while (true)
        {
                
            Console.WriteLine("Добро пожаловать в новый Месседжер выберите действий (1 или 2)");

            Console.WriteLine("1: Вход");
            Console.WriteLine("2: Регистрация");

            if (byte.TryParse(Console.ReadLine(), out byte val))
            {
                Console.WriteLine("Вы не указали вариант использования или вышли за его пределы");
            }

            switch (val)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("1: Вход");
                        Console.WriteLine("Введите почту");
                        string Email = Console.ReadLine();

                        Console.WriteLine("Введите пароль");
                        string Password = Console.ReadLine();

                        LoginValue login = new();

                        var person = login.LoginVal(Email, Password);

                        if(person!= null)
                        {
                            await ShowUserActions(Email);
                        }

                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("2:Регистрация");

                        Console.WriteLine("Введите имя");
                        string Name = Console.ReadLine();

                        Console.WriteLine("Введите фамилию");
                        string MiddleName = Console.ReadLine();

                        Console.WriteLine("Введите почту");
                        string Email = Console.ReadLine();

                        Console.WriteLine("Введите пароль");
                        string Password = Console.ReadLine();

                        ValidReg reg = new();

                        await reg.ValidRegCheck(Name, MiddleName, Email, Password);

                        break;
                    }
            }
        }
    }

    public async Task ShowUserActions(string Email)
    {
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1: Отправить сообщение");
            Console.WriteLine("2: Добавить друга");
            Console.WriteLine("3: Посмотреть профиль");
            Console.WriteLine("4: Выйти");
        }
    }
}
