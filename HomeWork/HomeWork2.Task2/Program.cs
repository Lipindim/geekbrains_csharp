using HomeWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Task2
{
    class Program
    {
        /* Липин Дмитрий
        Задание 2
        Написать метод подсчета количества цифр числа.*/

        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = ExtraConsole.ReadIntFromConsole();

            int digitsCount = GetDigitsCount(number);

            Console.WriteLine($"В числе '{number}' {digitsCount} цифр(а).");
        }

        private static int GetDigitsCount(int number)
        {
            if (number == 0)
                return 1;

            int calcValue = Math.Abs(number);
            int digitsCount = 0;
            while(calcValue > 0)
            {
                calcValue = calcValue / 10;
                digitsCount++;
            }
            return digitsCount;
        }
    }
}
