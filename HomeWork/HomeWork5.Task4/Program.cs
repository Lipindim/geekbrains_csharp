using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeWork5.Task4
{
    /* Липин Дмитрий
    Задание 4
    На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
    <Фамилия> <Имя> <оценки>,
    где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
    Иванов Петр 4 5 3
    Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.*/

    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("students.txt");
            List<Student> students = new List<Student>();

            foreach (string line in lines)
                students.Add(Student.Parse(line));

            Student[] sortedStudents = students.OrderBy(x => x.AvarageMark).ToArray();
            int studentsCount = sortedStudents.Length;
            int currentLevel = 0;
            int maxLevel = 3;
            Console.WriteLine(sortedStudents.First().Name);
            int i = 1;

            while (currentLevel < maxLevel && i < studentsCount)
            {
                Console.WriteLine(sortedStudents[i].Name);
                i++;
                while (sortedStudents[i].AvarageMark == sortedStudents[i-1].AvarageMark && i < studentsCount)
                {
                    Console.WriteLine(sortedStudents[i].Name);
                    i++;
                }
                currentLevel++;
            }
        }
    }
}
