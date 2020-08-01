using HomeWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Task5
{
    /* Липин Дмитрий
    Задание 5
    а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/

    class Program
    {
        private static double minNormalBodyMassIndex = 18.5;
        private static double maxNormalBodyMassIndex = 25;

        static void Main(string[] args)
        {
            Console.Write("Введите свой вес, кг: ");
            uint weight = ExtraConsole.ReadUintFromConsole();
            Console.Write("Введите свой рост, см: ");
            uint height = ExtraConsole.ReadUintFromConsole();

            double bodyMassIndex = GetBodyMassIndex(weight, height);
            BodyMassIndexInterpretation bodyMassIndexInterpretation = GetBodyMassIndexInterpretation(bodyMassIndex);
            
            switch (bodyMassIndexInterpretation)
            {
                case BodyMassIndexInterpretation.Thin:
                    {
                        double massToIncrease = GetMassToIncrease(weight, height);
                        Console.WriteLine($"Вы худой. Вам нужно набрать {massToIncrease:f1} кг.");
                        break;
                    }
                case BodyMassIndexInterpretation.Normal:
                    {
                        Console.WriteLine("У вас нормальный вес.");
                        break;
                    }
                case BodyMassIndexInterpretation.Fat:
                    {
                        double massToDecrease = GetMassToDecrease(weight, height);
                        Console.WriteLine($"Вы толстый. Вам нужно сбросить {massToDecrease:f1} кг.");
                        break;
                    }
                default:
                    break;
            }

        }

        private static double GetMassToIncrease(uint weight, uint height)
        {
            double massToIncrease = minNormalBodyMassIndex * Math.Pow(height / 100.0, 2) - weight;
            return massToIncrease;
        }
        private static double GetMassToDecrease(uint weight, uint height)
        {
            double massToDecrease = weight - maxNormalBodyMassIndex * Math.Pow(height / 100.0, 2);
            return massToDecrease;
        }

        private static double GetBodyMassIndex(uint weight, uint height)
        {
            return weight / Math.Pow(height / 100.0, 2);
        }

        private static BodyMassIndexInterpretation GetBodyMassIndexInterpretation(double bodyMassIndex)
        {
            if (bodyMassIndex < minNormalBodyMassIndex)
                return BodyMassIndexInterpretation.Thin;
            if (bodyMassIndex < maxNormalBodyMassIndex)
                return BodyMassIndexInterpretation.Normal;

            return BodyMassIndexInterpretation.Fat;
        }

        private enum BodyMassIndexInterpretation
        {
            Thin,
            Normal,
            Fat
        }
    }
}
