using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Task3
{
    /// <summary>
    /// Класс для работы с одномерным массивом.
    /// </summary>
    public class MyArray
    {
        private int[] array;

        /// <summary>
        /// Длина массива.
        /// </summary>
        public int Length
        {
            get
            {
                return array.Length;
            }
        }

        /// <summary>
        /// Сумма элементов массива.
        /// </summary>
        public int Sum
        {
            get
            {
                return array.Sum();
            }
        }

        /// <summary>
        /// Максимальное значение в массиве.
        /// </summary>
        public int Max
        {
            get
            {
                return array.Max();
            }
        }

        /// <summary>
        /// Доступ к элементу массива.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        /// <summary>
        /// Конструктор для создания массива. Заполняет массив числами от исходного значения с заданнчм шагом.
        /// </summary>
        /// <param name="arrayLength">Длина массива.</param>
        /// <param name="initialValue">Начальное значение.</param>
        /// <param name="stepSize">Шаг.</param>
        public MyArray(uint arrayLength, int initialValue, int stepSize)
        {
            if (arrayLength == 0)
                throw new ArgumentException("Массив не может быть нулевой длины", nameof(arrayLength));
            array = new int[arrayLength];
            int currentValue = initialValue;
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = currentValue;
                currentValue += stepSize;
            }
        }

        /// <summary>
        /// Создаёт массив заданной длины.
        /// </summary>
        /// <param name="arrayLength">Длина массива.</param>
        public MyArray(uint arrayLength)
        {
            if (arrayLength == 0)
                throw new ArgumentException("Массив не может быть нулевой длины", nameof(arrayLength));
            array = new int[arrayLength];
        }

        public MyArray(int[] initArray)
        {
            if (initArray == null)
                throw new ArgumentNullException(nameof(initArray));

            this.array = initArray;
        }

        /// <summary>
        /// Заполняет массив случайными значениями.
        /// </summary>
        /// <param name="minValue">Минимальное возможное значение.</param>
        /// <param name="maxValue">Максимальное возвожное значение.</param>
        public void FillRandomValues(int minValue, int maxValue)
        {
            Random random = new Random();
            for (int i = 0; i < this.Length; i++)
            {
                this[i] = random.Next(minValue, maxValue + 1);
            }
        }

        /// <summary>
        /// Возвращающает новый массив с измененными знаками у всех элементов массива.
        /// </summary>
        /// <returns></returns>
        public MyArray Inverse()
        {
            int[] inverseArray = new int[this.Length];
            for (int i = 0; i < this.Length; i++)
            {
                inverseArray[i] = -this[i];
            }

            return new MyArray(inverseArray);
        }

        /// <summary>
        /// Умножает каждный элемент массива на заданное число.
        /// </summary>
        /// <param name="multiplier">Множитель.</param>
        public void Multi(int multiplier)
        {
            for (int i = 0; i < this.Length; i++)
            {
                this[i] *= multiplier;
            }
        }

        /// <summary>
        /// Получить количество максимальных элементов в массиве.
        /// </summary>
        /// <returns></returns>
        public int MaxCount()
        {
            if (array == null)
                return 0;

            return this.array.Where(x => x == this.Max).Count();
        }

        /// <summary>
        /// Подсчитать частоту вхождения каждого элемента в массив.
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, int> GetFrequencyOfOccurrenceElements()
        {
            Dictionary<int, int> frequencyOfOccurenceDictionary = new Dictionary<int, int>();
            for (int i = 0; i < this.Length; i++)
            {
                if (frequencyOfOccurenceDictionary.ContainsKey(this[i]))
                    frequencyOfOccurenceDictionary[this[i]]++;
                else
                    frequencyOfOccurenceDictionary[this[i]] = 1;
            }

            return frequencyOfOccurenceDictionary;
        }

        public override string ToString()
        {
            return string.Join(" ", this.array);
        }

    }
}
