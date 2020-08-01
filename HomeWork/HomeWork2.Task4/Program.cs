using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Task4
{
    /* Липин Дмитрий
    Задание 4
    Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.*/
    class Program
    {
        private static string trueLogin = "root";
        private static string truPassword = "GeekBrains";

        private static bool IsAuthSuccess(string login, string password)
        {
            return login == trueLogin && password == truPassword; 
        }

        static void Main(string[] args)
        {
            int tryCount = 3;
            bool authSuccess = false;
            do
            {
                Console.Write($"Для продолжения введите логин и пароль. Осталось попыток: {tryCount}.\nЛогин:");
                string login = Console.ReadLine();
                Console.Write("Пароль: ");
                string password = Console.ReadLine();

                authSuccess = IsAuthSuccess(login, password);
                if (!authSuccess)
                    Console.WriteLine("Неверный логин или пароль.");
                tryCount--;
            }
            while (!authSuccess && tryCount > 0);

            if (authSuccess)
                Console.WriteLine("Вы вошли в систему.");
            else
                Console.WriteLine("Вы не смогли войти в систему.");
        }


    }
}
