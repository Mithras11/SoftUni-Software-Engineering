using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                Person newMember = new Person(data[0], int.Parse(data[1]));

                family.AddMember(newMember);

            }
            family.GetOldestMember(family.Members);

        }


        class Family
        {
            public List<Person> Members { get; set; }

            public Family()
            {
                List<Person> members = new List<Person>();
                this.Members = members;
            }

            public void AddMember(Person member)
            {
                Members.Add(member);
            }

            public void GetOldestMember(List<Person> members)
            {
                Person oldest = members.OrderByDescending(x => x.Age).ToList()[0];
                Console.WriteLine($"{oldest.Name} {oldest.Age}");
            }
        }

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
    }
}
