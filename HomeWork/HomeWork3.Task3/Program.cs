using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Task3
{
    /* Липин Дмитрий
    Задание 3
    *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
    * Добавить свойства типа int для доступа к числителю и знаменателю;
    * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
    *** Добавить упрощение дробей.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создаю случайные дроби");
            Random random = new Random();
            int maxValue = 20;
            Fraction a = Fraction.GetRandomFraction(maxValue);
            Fraction b = Fraction.GetRandomFraction(maxValue);
            Console.WriteLine($"Первая дробь: {a}, вторая дробь: {b}");
            Console.WriteLine($"Сумма дробей: {a + b}");
            Console.WriteLine($"Разность дробей: {a - b}");
            Console.WriteLine($"Произведение дробей: {a * b}");
            Console.WriteLine($"Частное дробей: {a / b}");
            Console.WriteLine($"Десятичное представление дробей: {a.GetDecimal}; {b.GetDecimal}");
        }
    }
}
