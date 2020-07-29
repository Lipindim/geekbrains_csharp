using HomeWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1.Task4
{
    class Program
    {
        /* Липин Дмитрий
        Задание 4
        Написать программу обмена значениями двух переменных:
        а) с использованием третьей переменной;
	    б) *без использования третьей переменной.*/
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число a: ");
            int a = ExtraConsole.ReadIntFromConsole();
            Console.Write("Введите второе целое число b: ");
            int b = ExtraConsole.ReadIntFromConsole();

            SwapWithBuffer(ref a, ref b);
            Console.WriteLine($"Меняем значения с помощью третьей переменной: a = {a}, b = {b}");
            SwapWithoutBuffer(ref a, ref b);
            Console.WriteLine($"Ещё раз меняем значения без использования третьей переменной: a = {a}, b = {b}");
            Console.ReadKey();
        }

        static void SwapWithBuffer(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        static void SwapWithoutBuffer(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
