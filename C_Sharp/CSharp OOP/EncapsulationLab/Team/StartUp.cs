using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int players = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < players; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                var person = new Person(tokens[0], tokens[1], int.Parse(tokens[2]), decimal.Parse(tokens[3]));

                persons.Add(person);
            }



            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

        }
    }
}
