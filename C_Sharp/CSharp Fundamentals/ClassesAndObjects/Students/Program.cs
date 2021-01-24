using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] studentData = input.Split();

                Student currentStudent = new Student(studentData[0],
                    studentData[1],
                    studentData[2],
                    studentData[3]);

                students.Add(currentStudent);

                input = Console.ReadLine();
            }

            string city = Console.ReadLine();

            List<Student> filteredStudents = students.Where(n => n.HomeTown == city).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string HomeTown { get; set; }

            public Student(string firstName, string lastName, string age, string homeTown)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                HomeTown = homeTown;
            }
        }
    }
}
