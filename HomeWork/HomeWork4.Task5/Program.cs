using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleArray doubleArray = new DoubleArray(5, 4);
            Console.WriteLine($"Массив:\n{doubleArray}");
            try
            {
                doubleArray.WriteToFile("array.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи массива в файл: {ex.Message}");
            }
            Console.WriteLine($"Максимальный элемент массива: {doubleArray.Max}");
            Console.WriteLine($"Минимальный элемент массива: {doubleArray.Min}");
            Console.WriteLine($"Сумма элементов массива: {doubleArray.GetElementsSum()}");
            Console.WriteLine($"Сумма элементов массива больше 10: {doubleArray.GetElementsSumGraterThen(10)}");
            doubleArray.GetMaxElementIndexes(out int rowIndex, out int columnIndex);
            Console.WriteLine($"Максимальный элемент массива: строка {rowIndex}, столбец {columnIndex}");


            DoubleArray doubleArrayFromFile = new DoubleArray();
            try
            {
                doubleArrayFromFile.ReadFromFile("array.txt");
                Console.WriteLine($"Массив, считанный из файла:\n{doubleArrayFromFile}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении массива из файла: {ex.Message}");
            }
        }
    }
}
