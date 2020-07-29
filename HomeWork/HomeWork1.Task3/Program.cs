using HomeWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1.Task3
{
    /* Липин Дмитрий
    Задание 3
    а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2)
    + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
    б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода. */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координаты первой точки.\nx: ");
            int x1 = ExtraConsole.ReadIntFromConsole();
            Console.Write("y: ");
            int y1 = ExtraConsole.ReadIntFromConsole();
            Console.Write("Введите координаты второй точки.\nx: ");
            int x2 = ExtraConsole.ReadIntFromConsole();
            Console.Write("y: ");
            int y2 = ExtraConsole.ReadIntFromConsole();

            double distanse = GetDistanseBetweenTwoPoints(x1, y1, x2, y2);

            Console.WriteLine($"Расстояние между двумя точками: {distanse:f2}");
            Console.ReadKey();
        }

        static double GetDistanseBetweenTwoPoints(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
