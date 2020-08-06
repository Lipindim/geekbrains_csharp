using HomeWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Task1
{
    /* Липин Дмитрий
    Задание 1
    а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
    в) Добавить диалог с использованием switch демонстрирующий работу класса.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Генерирую случайные комплексные числа");
            double maxValue = 10;
            int decimalPoints = 1;
            Complex a = new Complex(Randomizer.GenerateRandomDouble(maxValue, decimalPoints), Randomizer.GenerateRandomDouble(maxValue, decimalPoints));
            Complex b = new Complex(Randomizer.GenerateRandomDouble(maxValue, decimalPoints), Randomizer.GenerateRandomDouble(maxValue, decimalPoints));
            Console.WriteLine($"Первое комплексное число: {a}");
            Console.WriteLine($"Первое комплексное число: {b}");
            
            string answer = string.Empty;
            bool isFinished = false;
            while (!isFinished)
            {
                Console.WriteLine("Какую операцию желаете выполнить с числами? Введите оператор +, -, * или /. Для выхода введите q.");
                answer = Console.ReadLine().ToLower();
                Complex result = null;
                switch (answer)
                {
                    case "+":
                        {
                            result = a + b;
                            break;
                        }
                    case "-":
                        {
                            result = a - b;
                            break;
                        }
                    case "*":
                        {
                            result = a * b;
                            break;
                        }
                    case "/":
                        {
                            result = a / b;
                            break;
                        }
                    case "q":
                        {
                            isFinished = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Неизвестная команда. Повторите попытку");
                            continue;
                        }
                }
                if (!isFinished)
                {
                    Console.WriteLine($"Результат: {result}");
                }
            }
        }
    }
}
