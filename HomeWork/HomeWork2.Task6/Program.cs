using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Task6
{
    /* Липин Дмитрий
    Задание 6
    Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.*/
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int finishNumber = 1000000000;
            int goodNumbersCount = 0;

            DateTime startTime = DateTime.UtcNow;
            for (int i = startNumber; i < finishNumber; i++)
            {
                if (IsGoodNumber(i))
                    goodNumbersCount++;
            }
            TimeSpan executionTime = DateTime.UtcNow - startTime;
            Console.WriteLine($"Количество хороших чисел от {startNumber} до {finishNumber}: {goodNumbersCount}.\nВремя выполнения: {executionTime.TotalSeconds:f2} с.");
        }

        private static bool IsGoodNumber(int number)
        {
            int digitsSum = GetDigitsDSum(number);
            return number % digitsSum == 0;
        }

        private static int GetDigitsDSum(int number)
        {
            int digitsSum = 0;
            int calcValue = Math.Abs(number);
            while (calcValue > 0)
            {
                digitsSum += calcValue % 10;
                calcValue /= 10;
            }
            return digitsSum;
        }
    }
}
