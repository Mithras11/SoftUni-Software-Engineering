using System;
using System.Collections.Generic;

namespace CitiesByContinentsAndCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!continents.ContainsKey(input[0]))
                {
                    continents.Add(input[0], new Dictionary<string, List<string>>());

                }

                if (!continents[input[0]].ContainsKey(input[1]))
                {
                    continents[input[0]].Add(input[1], new List<string>());
                }

                continents[input[0]][input[1]].Add(input[2]);
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }


        }
    }
}
