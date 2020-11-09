using System;

namespace Artemkin.HomeWork._05._11
{
    class Task4
    {
        //4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
        //С помощью цикла do while ограничить ввод пароля тремя попытками.
        internal static bool LogIn()
        {
            Console.WriteLine($"Введите ваш логин");
            string login = Console.ReadLine();

            login = login.ToLower();
            int currentTry = 1;
            string userLogin = "root";
            string userPassword = "GeekBrains";
            int tryToLogIn = 3;
            string password;

            do
            {
                Console.WriteLine("Введите пароль");
                password = Console.ReadLine();

                if (login == userLogin && password == userPassword)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Неверный логин или пароль");
                }
                currentTry++;
            } while (currentTry <= tryToLogIn);
            return false;
        }
    }
}

