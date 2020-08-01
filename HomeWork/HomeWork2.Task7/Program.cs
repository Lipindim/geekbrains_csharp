using HomeWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Task7
{
    /* Липин Дмитрий
    Задание 7
    a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.*/
    class Program
    {
        static void Main(string[] args)
        {
            int fromNumber = 0;
            int toNumber = 0;
            bool inputSucess = false;
            while (!inputSucess)
            {
                Console.Write("Введите перове число: ");
                fromNumber = ExtraConsole.ReadIntFromConsole();
                Console.Write("Введите второе число, больше первого: ");
                toNumber = ExtraConsole.ReadIntFromConsole();
                if (fromNumber > toNumber)
                    Console.WriteLine("Второе число меньше первого. Попробуйте ещё раз.");
                else
                    inputSucess = true;
            }
            
            Console.WriteLine($"Вывожу все числа между {fromNumber} и {toNumber}:");
            OutputNumbers(fromNumber, toNumber);
            Console.WriteLine();

            int sum = GetSumBetweenNumbers(fromNumber, toNumber);
            Console.WriteLine($"Сумма чисел между {fromNumber} и {toNumber} равна: {sum}");
        }

        private static void OutputNumbers(int fromNumber, int toNumber)
        {
            Console.Write($"{fromNumber} ");
            if (fromNumber != toNumber)
                OutputNumbers(fromNumber + 1, toNumber);
        }

        private static int GetSumBetweenNumbers(int fromNumber, int toNumber)
        {
            if (fromNumber == toNumber)
                return fromNumber;
            else
                return fromNumber + GetSumBetweenNumbers(fromNumber + 1, toNumber);
        }
    }
}
