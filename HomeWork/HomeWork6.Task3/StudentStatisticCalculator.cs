using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6.Task3
{
    /// <summary>
    /// Класс для сбора статистики по студентам.
    /// </summary>
    public class StudentStatisticCalculator
    {
        private readonly IEnumerable<Student> students;

        public IEnumerable<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public StudentStatisticCalculator(IEnumerable<Student> students)
        {
            this.students = students;
        }

        /// <summary>
        /// Получить количество студентов, учащихся на указанном курсе.
        /// </summary>
        /// <param name="course">Курс.</param>
        /// <returns></returns>
        public int GetStudentsEnrolledInTheCourse(int course)
        {
            return this.Students.Where(x => x.Course == course).Count();
        }

        /// <summary>
        /// Получить распределение студентов по курсам для указанного возрастного диапазона.
        /// </summary>
        /// <param name="minAge">Минимальный возраст студента.</param>
        /// <param name="maxAge">Максимальный возраст студента.</param>
        /// <returns></returns>
        public Dictionary<string, int> GetDistributionOfStudentsByAgeByCourse(int minAge, int maxAge)
        {
            var groupedStudents = students.Where(x => minAge <= x.Age && x.Age <= maxAge)
                .Select(x => new { x.Age, x.Course})
                .GroupBy(x => new { x.Age, x.Course });
            Dictionary<string, int> studentsDistributionDictionary = new Dictionary<string, int>();
            foreach (var group in groupedStudents.OrderBy(x => x.Key.Course).ThenBy(x => x.Key.Age))
            {
                string dictionaryKey = $"{group.Key.Course} курс, {group.Key.Age} лет";
                studentsDistributionDictionary.Add(dictionaryKey, group.Count());
            }
            return studentsDistributionDictionary;
        }

        /// <summary>
        /// Получить студентов, отсортированных по возрасту.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> GetStudentsSortByAge()
        {
            return this.Students.OrderBy(x => x.Age);
        }

        /// <summary>
        /// Получить студентов, отсортированных по курсу и возврасту.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> GetStudentsSortByCourseAndAge()
        {
            return this.Students.OrderBy(x => x.Course).ThenBy(x => x.Age);
        }
    }
}
