using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = tokens[0];
                decimal grade = decimal.Parse(tokens[1]);

                if (students.ContainsKey(name) == false)
                {
                    students.Add(name, new List<decimal>());

                }

                students[name].Add(grade);
            }

            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.WriteLine($"(avg: { student.Value.Average():F2}) ");

            }





        }
    }
}


