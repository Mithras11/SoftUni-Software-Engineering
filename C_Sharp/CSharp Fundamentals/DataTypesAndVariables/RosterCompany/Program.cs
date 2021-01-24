using System;
using System.Collections.Generic;
using System.Linq;

namespace RosterCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Employee>> departments = new Dictionary<string, List<Employee>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Employee currEmployee = new Employee(data[0], decimal.Parse(data[1]));

                if (departments.ContainsKey(data[2]))
                {
                    departments[data[2]].Add(currEmployee);
                }
                else
                {
                    departments.Add(data[2], new List<Employee> { currEmployee });
                }

            }

            decimal maxAverage = 0;
            string topDepartment = string.Empty;

            foreach (var item in departments)
            {
                decimal averageSalary = item.Value.Average(x => x.Salary);

                if (averageSalary > maxAverage)
                {
                    maxAverage = averageSalary;
                    topDepartment = item.Key;
                }
            }

            Console.WriteLine($"Highest Average Salary: {topDepartment}");

            List<Employee> winner = departments[topDepartment].OrderByDescending(x => x.Salary).ToList();

            foreach (var item in winner)
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2}");
            }




        }


        class Employee
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }


            public Employee(string name, decimal salary)
            {
                this.Name = name;
                this.Salary = salary;

            }
        }
    }
}
