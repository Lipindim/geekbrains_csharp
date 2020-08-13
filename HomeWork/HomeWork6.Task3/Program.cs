using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Task3
{
    /* Липин Дмитрий
    Задание 3
    Переделать программу Пример использования коллекций для решения следующих задач:
        а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
        в) отсортировать список по возрасту студента;
        г) *отсортировать список по курсу и возрасту студента;*/
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();                             // Создаем список студентов
            using (StreamReader sr = new StreamReader("students.csv"))
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        string[] s = sr.ReadLine().Split(';');
                        // Добавляем в список новый экземпляр класса Student
                        students.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                        // Выход из Main
                        if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                    }
                }
            }
            StudentStatisticCalculator studentStatisticCalculator = new StudentStatisticCalculator(students);
            //Количество студентов на 5 и 6 курсах
            int studentsOnCourse5 = studentStatisticCalculator.GetStudentsEnrolledInTheCourse(5);
            int studentsOnCourse6 = studentStatisticCalculator.GetStudentsEnrolledInTheCourse(6);
            //Распределение студентов от 18 до 20 лет по курсам
            Dictionary<string, int> studentsDistributions = studentStatisticCalculator.GetDistributionOfStudentsByAgeByCourse(18, 20);
            //Список студентов, отсортированный по возрасту
            var studentSortByAge = studentStatisticCalculator.GetStudentsSortByAge();
            //Список студентов, отсортированный по курсу и возрасту
            var studentSortByCourseAndAge = studentStatisticCalculator.GetStudentsSortByCourseAndAge();

            Console.ReadKey();

        }

        static void GenerateCvv()
        {
            string[] firstNames = { "Дмитрий", "Артур", "Андрей", "Денис", "Юрий" };
            string[] lastNames = { "Иванов", "Петров", "Сидоров", "Пупкин", "Губкин" };
            string[] univercities = { "ДВГУПС", "ТОГУ", "ДВГГУ", "ДВАГС", "ДВГМУ" };
            string[] facilities = { "ИУАТ", "ЕНИ", "СГИ", "ФВС", "ЭИ" };
            string[] departments = { "Математика", "Программирование", "Философия", "Физика", "История" };
            string[] cities = { "Хабаровск", "Владивосток", "Иркутск", "Новосибирск", "Красноярск" };
            Random rnd = new Random();
            using (StreamWriter sw = new StreamWriter("students.csv"))
            {
                for (int i = 0; i < 100; i++)
                {
                    string[] values = new string[9];
                    values[0] = firstNames[rnd.Next(firstNames.Length)];
                    values[1] = lastNames[rnd.Next(lastNames.Length)];
                    values[2] = univercities[rnd.Next(univercities.Length)];
                    values[3] = facilities[rnd.Next(facilities.Length)];
                    values[4] = departments[rnd.Next(departments.Length)];
                    values[5] = rnd.Next(18, 24).ToString();
                    values[6] = rnd.Next(1, 7).ToString();
                    values[7] = rnd.Next(100, 600).ToString();
                    values[8] = cities[rnd.Next(cities.Length)];
                    sw.WriteLine(string.Join(";", values));
                }
                
            }
        }
    }
}
