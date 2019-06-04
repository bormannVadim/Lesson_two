using System;

namespace LoginPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            //Савенко Вадим
            int attempts = 0;
            string loging, password;
            do {
                Console.WriteLine("Введите логин:");
                loging = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                password = Console.ReadLine();
                attempts++;
                if (checkPassword(loging, password))
                {
                    Console.WriteLine("Доступ предоставлен!");
                    break;
                }
                else
                    Console.WriteLine("В доступе отказано!\nПопробуйте ещё раз...");
            } while (attempts < 4);
        }

        static bool checkPassword(string login, string password)
        {
            string EtalonLoging = "root";
            string EtalonPassword = "GeekBrains";
            return login == EtalonLoging && password == EtalonPassword ?true:false;

        }
    }
}
