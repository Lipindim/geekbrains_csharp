using HomeWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Task3
{
    /* Липин Дмитрий
    Задание 3
    С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.*/
    class Program
    {
        static void Main(string[] args)
        {
            int sumPositiveOddNumbers = 0;
            int inputNumber;
            do
            {
                Console.Write("Введите число, для завершения введите 0: ");
                inputNumber = ExtraConsole.ReadIntFromConsole();
                if (inputNumber > 0 && inputNumber % 2 == 1)
                    sumPositiveOddNumbers += inputNumber;
            }
            while (inputNumber != 0);

            Console.WriteLine($"Сумма всех нечетных положительных чисел: {sumPositiveOddNumbers}");
        }
    }
}
