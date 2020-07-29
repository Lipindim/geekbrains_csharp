using HomeWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1.Task2
{
    /* Липин Дмитрий
     Задание 2
     Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой рост, см (целое число): ");
            uint height = ExtraConsole.ReadUintFromConsole();
            Console.WriteLine("Введите свой вес, кг (целое число): ");
            uint weight = ExtraConsole.ReadUintFromConsole();
            double bodyMassIndex = weight / (Math.Pow(height / 100d, 2));
            Console.WriteLine($"Ваш индекс массы тела: {bodyMassIndex:f2}");
            Console.ReadKey();

        }
    }
}
