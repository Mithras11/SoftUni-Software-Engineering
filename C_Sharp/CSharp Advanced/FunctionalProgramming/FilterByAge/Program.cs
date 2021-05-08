using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine()
                     .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                people.Add(new Person(person[0], int.Parse(person[1])));

            }

            string filter = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<Person, bool> processPeople = filter switch
            {
                "older" => p => p.Age >= age,
                "younger" => p => p.Age <= age,
                _ => null

            };


            string outputFormat = Console.ReadLine();

            Func<Person, string> output = outputFormat switch
            {
                "name age" => p => $"{p.Name} - {p.Age}",
                "name" => p => $"{p.Name}",
                "age" => p => $"{p.Age}",
                _ => null
            };


            people.Where(processPeople)
                .Select(output)
                .ToList()
                .ForEach(Console.WriteLine);























        }
    }
}
