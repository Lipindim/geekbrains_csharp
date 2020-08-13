using System;

namespace HomeWork6.Task3
{
    public class Student : IEquatable<Student>, IComparable<Student>
    {
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string University { get; private set; }
        public string Faculty { get; private set; }
        public int Course { get; private set; }
        public string Department { get; private set; }
        public int Group { get; private set; }
        public string City { get; private set; }
        public int Age { get; private set; }
        
        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.University = university;
            this.Faculty = faculty;
            this.Department = department;
            this.Course = course;
            this.Age = age;
            this.Group = group;
            this.City = city;
        }

        public int CompareTo(Student other)
        {
            return string.Compare($"{this.FirstName} {this.LastName}", 
                $"{other.FirstName} {other.LastName}");
        }

        public bool Equals(Student other)
        {
            return this.CompareTo(other) == 0;
        }
    }
}
