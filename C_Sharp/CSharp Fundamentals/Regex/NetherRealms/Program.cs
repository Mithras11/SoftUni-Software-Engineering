using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            SortedDictionary<string, double[]> demons = new SortedDictionary<string, double[]>();

            string healthPattern = @"[^\d*\+\-\*\/.]";
            Regex healthRegex = new Regex(healthPattern);

            string damagePattern = @"([+-]?[\d+]\.?\d*)";
            Regex damageRegex = new Regex(damagePattern);

            foreach (var item in input)
            {
                string demonName = item;

                MatchCollection healthMatches = healthRegex.Matches(item);
                int health = healthMatches.Sum((x => char.Parse(x.ToString())));

                MatchCollection damageMatches = damageRegex.Matches(item);
                double damage = damageMatches.Sum((x => double.Parse(x.ToString())));

                int multiplcationCounter = item.Where(x => x == '*').Count();
                int divisionCounter = item.Where(x => x == '/').Count();

                for (int i = 0; i < multiplcationCounter; i++)
                {
                    damage *= 2;
                }

                for (int i = 0; i < divisionCounter; i++)
                {
                    damage /= 2;
                }

                demons.Add(demonName, new double[] { health, damage });
            }

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }








        }
    }
}
