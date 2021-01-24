using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public Person(string name, string id, int age)
            {
                this.Name = name;
                this.ID = id;
                this.Age = age;
            }

        }
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string input= Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                else
                {
                    string[] data = input.Split();

                    Person newPerson = new Person(data[0], data[1], int.Parse(data[2]));
                    persons.Add(newPerson);
                }

            }

            List<Person> orderedList = persons.OrderBy(person => person.Age).ToList();

            foreach (var item in orderedList)
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }
    }
}
