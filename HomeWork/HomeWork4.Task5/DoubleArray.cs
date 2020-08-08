using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork4.Task5
{
    public class DoubleArray
    {
        private const int minRandomElementValue = -100;
        private const int maxRandomElementValue = 100;

        private int[][] array;
        
        /// <summary>
        /// Количство строк в двумерном массиве.
        /// </summary>
        public int RowsCount
        {
            get
            {
                if (array == null)
                    return 0;

                return array.Length;
            }
        }

        /// <summary>
        /// Количество столбцов в двумерном массиве.
        /// </summary>
        public int ColumnsCount
        {
            get
            {
                if (array == null)
                    return 0;
                int[] firstRow = array.FirstOrDefault();
                if (firstRow == null)
                    return 0;

                return firstRow.Length;
            }
        }

        /// <summary>
        /// Общее количество элементов в двумерном массиве.
        /// </summary>
        public int TotalElementsCount
        {
            get
            {
                return RowsCount * ColumnsCount;
            }
        }

        /// <summary>
        /// Минимальное значение в двумерном массиве.
        /// </summary>
        public int Min
        {
            get
            {
                if (this.IsArrayEmpty())
                    return 0;

                return this.array.Min(r => r.Min());
            }
        }

        /// <summary>
        /// Максимальное значение в двумерном массиве.
        /// </summary>
        public int Max
        {
            get
            {
                if (this.IsArrayEmpty())
                    return 0;

                return this.array.Max(r => r.Max());
            }
        }

        /// <summary>
        /// Конструктор без начальной инициализации двумерного массива.
        /// </summary>
        public DoubleArray()
        {

        }

        /// <summary>
        /// Конструктор для создания двумерного массива.
        /// </summary>
        /// <param name="rowsCount">Количество строк в массиве.</param>
        /// <param name="columnsCount">Количество столбцов в массиве.</param>
        /// <param name="randomFilling">Заполнить массив случайными значениями.</param>
        public DoubleArray(uint rowsCount, uint columnsCount, bool randomFilling = true)
        {
            if (rowsCount == 0)
                throw new ArgumentException("Количество строк в массиве не может равняться 0.", nameof(rowsCount));
            if (columnsCount == 0)
                throw new ArgumentException("Количество столбцов в массиве не может равняться 0.", nameof(columnsCount));

            this.array = new int[rowsCount][];
            for (int i = 0; i < rowsCount; i++)
            {
                this.array[i] = new int[columnsCount];
            }
            if (randomFilling)
            {
                Random random = new Random();
                for (int i = 0; i < rowsCount; i++)
                {
                    for (int j = 0; j < columnsCount; j++)
                    {
                        array[i][j] = random.Next(minRandomElementValue, maxRandomElementValue + 1);
                    }
                }
            }
        }

        /// <summary>
        /// Получить сумму элементов двумерного массива.
        /// </summary>
        /// <returns></returns>
        public int GetElementsSum()
        {
            if (this.IsArrayEmpty())
                return 0;

            return this.array.Sum(r => r.Sum());
        }

        /// <summary>
        /// Получить сумму элементов двумерного массива, больше заданного значения.
        /// </summary>
        /// <param name="graterThenValue">Сумма для элементов больше этого значения.</param>
        /// <returns></returns>
        public int GetElementsSumGraterThen(int graterThenValue)
        {
            if (this.IsArrayEmpty())
                return 0;

            return this.array.Sum(r => r.Where(e => e > graterThenValue).Sum());
        }

        /// <summary>
        /// Получить индексы максимального элемента.
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        public void GetMaxElementIndexes(out int rowIndex, out int columnIndex)
        {
            if (this.IsArrayEmpty())
            {
                rowIndex = -1;
                columnIndex = -1;
                return;
            }

            int max = this.array[0][0];
            rowIndex = 0;
            columnIndex = 0;
            for (int i = 0; i < this.RowsCount; i++)
            {
                for (int j = 0; j < this.ColumnsCount; j++)
                {
                    if (max < this.array[i][j])
                    {
                        max = this.array[i][j];
                        rowIndex = i;
                        columnIndex = j;
                    }
                }
            }
        }

        private bool IsArrayEmpty()
        {
            return array == null || this.TotalElementsCount == 0;
        }

        /// <summary>
        /// Записать двумерный массив в файл.
        /// </summary>
        /// <param name="filePath"></param>
        public void WriteToFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentNullException(nameof(filePath));
                
            File.WriteAllText(filePath, this.ToString());
        }

        /// <summary>
        /// Считать двумерный массив из файла.
        /// </summary>
        /// <param name="filePath"></param>
        public void ReadFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length == 0)
                throw new FormatException("Указанный файл пустой.");

            string[] headerSplit = lines.First().Split(' ');
            if (headerSplit.Length != 2)
                throw new FormatException("В заголовке должно быть указано кол-во строк и столбцов через пробел.");

            int rowsCount = int.Parse(headerSplit[0]);
            int columnsCount = int.Parse(headerSplit[1]);

            if (rowsCount != lines.Length - 1)
                throw new FormatException("Неверно указано кол-во строк в массиве.");

            this.array = new int[rowsCount][];
            for (int i = 0; i < rowsCount; i++)
            {
                this.array[i] = new int[columnsCount];
            }

            for (int i = 0; i < rowsCount; i++)
            {
                string[] splitRow = lines[i + 1].Split(';');
                if (splitRow.Length != columnsCount)
                    throw new FormatException($"Неверное кол-во элементов в строке {i}");
                for (int j = 0; j < columnsCount; j++)
                {
                    this.array[i][j] = int.Parse(splitRow[j]);
                }
            }


        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.RowsCount} {this.ColumnsCount}");
            for (int i = 0; i < this.RowsCount; i++)
            {
                for (int j = 0; j < this.ColumnsCount; j++)
                {
                    if (j == this.ColumnsCount - 1)
                        sb.Append(this.array[i][j]);
                    else
                        sb.Append($"{this.array[i][j]};");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
