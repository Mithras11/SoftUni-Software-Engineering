using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {

        static void Main(string[] args)
        {
            var family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var person = new Person(info[0], int.Parse(info[1]));

                family.AddMember(person);
            }


            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }


    }
}
