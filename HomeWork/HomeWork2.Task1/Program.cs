using HomeWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Task1
{
    class Program
    {
        /* Липин Дмитрий
        Задание 1
        Написать метод, возвращающий минимальное из трёх чисел.*/

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = ExtraConsole.ReadIntFromConsole();
            Console.Write("Введите второе число: ");
            int b = ExtraConsole.ReadIntFromConsole();
            Console.Write("Введите третье число: ");
            int c = ExtraConsole.ReadIntFromConsole();

            int min = GetMin(a, b, c);

            Console.WriteLine($"Минимальное число: {min}");
        }

        static int GetMin(int a, int b, int c)
        {
            int min = a;
            if (b < min)
                b = min;
            if (c < min)
                c = min;
            return min;
        }

    }
}
