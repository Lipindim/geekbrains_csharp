using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1.Task1
{
    /* Липин Дмитрий
    Задача 1.    
    Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
    а) используя склеивание;
    б) используя форматированный вывод;
    в) используя вывод со знаком $. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите свой возраст:");
            string age = Console.ReadLine();
            Console.WriteLine("Введите свой рост:");
            string height = Console.ReadLine();
            Console.WriteLine("Введите свой вес:");
            string weight = Console.ReadLine();

            Console.WriteLine("Результат с использованием склеивания:");
            Console.WriteLine(lastName + " " + firstName + ", ваш возраст: " + age + ", рост: " + height + ", вес: " + weight);
            Console.WriteLine("Результат с использованием форматированного вывода:");
            Console.WriteLine("{0} {1}, ваш возраст: {2}, рост: {3}, вес: {4}", lastName, firstName, age, height, weight);
            Console.WriteLine("Использую вывод со знаком $");
            Console.WriteLine($"{lastName} {firstName}, ваш возраст: {age}, рост: {height}, вес: {weight}");
            Console.ReadKey();

        }
    }
}
