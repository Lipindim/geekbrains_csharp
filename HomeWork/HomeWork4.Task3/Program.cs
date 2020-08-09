using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Task3
{
    /* Липин Дмитрий
    Задача 3
    а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
    б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
    е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)*/
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray(20);
            myArray.FillRandomValues(-20, 20);
            Console.WriteLine($"Начальный массив:\n{myArray}");
            Console.WriteLine($"Сумма элементов массива: {myArray.Sum}");
            Console.WriteLine($"Инверсный массив:\n{myArray.Inverse()}");
            myArray.Multi(5);
            Console.WriteLine($"Массив, умноженный на 5:\n{myArray}");
            Console.WriteLine($"Количество максимальных элементов: {myArray.MaxCount()}");
            Dictionary<int, int> frequencyOfOccurrenceDictionary = myArray.GetFrequencyOfOccurrenceElements();
            string[] stringPairs = frequencyOfOccurrenceDictionary.Select(x => $"{x.Key}:{x.Value}").ToArray();
            Console.WriteLine($"Количество вхождений элементов: {string.Join("; ", stringPairs)}");
        }
    }
}
