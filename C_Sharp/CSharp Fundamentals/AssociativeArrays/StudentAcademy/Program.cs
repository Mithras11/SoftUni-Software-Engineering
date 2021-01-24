using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGrades = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfGrades; i++)
            {
                string currentStudent = Console.ReadLine();
                double currentGrade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(currentStudent))
                {
                    students[currentStudent].Add(currentGrade);
                }
                else
                {
                    students.Add(currentStudent, new List<double>() { currentGrade });

                }
            }

            var sortedStudents = new Dictionary<string, double>();

            foreach (var student in students)
            {
                double averageGrade = student.Value.Average(x => x);

                if (averageGrade >= 4.50)
                {
                    sortedStudents.Add(student.Key, averageGrade);
                }
            }

            

            foreach (var student in sortedStudents.OrderByDescending(pair => pair.Value))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }






        }
    }
}
