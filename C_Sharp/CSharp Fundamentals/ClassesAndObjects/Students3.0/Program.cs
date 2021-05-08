using System;
using System.Collections.Generic;
using System.Linq;

namespace Students3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>(countOfStudents);

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                Student student = new Student(data[0], data[1], double.Parse(data[2]));

                students.Add(student);
            }

            List<Student> orderedStudents = students.OrderByDescending(student => student.Grade).ToList();

            foreach (Student student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:f2}");
            }


        }

        public class Student
        {
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string secondName, double grade)
            {
                this.FirstName = firstName;
                this.SecondName = secondName;
                this.Grade = grade;
            }
        }
    }
}
