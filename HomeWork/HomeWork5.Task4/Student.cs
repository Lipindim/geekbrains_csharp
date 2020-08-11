namespace HomeWork5.Task4
{
    public class Student
    {
        public string Name { get; set; }
        public double AvarageMark { get; set; }

        public static Student Parse(string input)
        {
            string[] splitInput = input.Split(' ');
            Student student = new Student()
            {
                Name = $"{splitInput[0]} {splitInput[1]}"
            };
            int sumMarks = int.Parse(splitInput[2]) + int.Parse(splitInput[3]) + int.Parse(splitInput[4]);
            student.AvarageMark = sumMarks / 3.0;
            return student;
        }
    }
}
