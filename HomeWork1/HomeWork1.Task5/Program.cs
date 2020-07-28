using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1.Task5
{
    class Program
    {
        /* Липин Дмитрий
        Задание 5
        а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        б) *Сделать задание, только вывод организовать в центре экрана.
        в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).*/
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите свою фамилию: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите город, в котором вы проживаете: ");
            string city = Console.ReadLine();

            string message = $"{lastName} {firstName}, {city}";
            PrintInTheCenterScreen(message);
            Console.ReadKey();
            
        }
        static void PrintInTheCenterScreen(string message)
        {
            Console.Clear();
            int offsetX = Console.WindowWidth / 2 - message.Length / 2;
            int offsetY = Console.WindowHeight / 2;
            if (offsetX < 0)
            {
                Console.WriteLine("Сообщение слишком длинное и не помещяется в одну строку.");
                return;
            }
            Print(message, offsetX, offsetY);
        }

        static void Print(string message, int offsetX, int offsetY)
        {
            Console.SetCursorPosition(offsetX, offsetY);
            Console.Write(message);
        }
    }
}
