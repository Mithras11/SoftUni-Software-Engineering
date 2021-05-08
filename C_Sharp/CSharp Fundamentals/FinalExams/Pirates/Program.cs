using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            while (input != "Sail")
            {
                string[] currentCity = input.Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string cityName = currentCity[0];
                int population = int.Parse(currentCity[1]);
                int gold = int.Parse(currentCity[2]);

                if (cities.ContainsKey(cityName))
                {
                    cities[cityName][0] += population;
                    cities[cityName][1] += gold;
                }
                else
                {
                    cities.Add(cityName, new List<int> { population, gold });

                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string[] currentEvent = input.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string eventType = currentEvent[0];

                if (eventType == "Plunder")
                {
                    string town = currentEvent[1];
                    int people = int.Parse(currentEvent[2]);
                    int gold = int.Parse(currentEvent[3]);

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    cities[town][0] -= people;
                    cities[town][1] -= gold;

                    if (cities[town][0] == 0 || cities[town][1] == 0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }

                else if (eventType == "Prosper")
                {
                    string town = currentEvent[1];
                    int gold = int.Parse(currentEvent[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");

                        input = Console.ReadLine();
                        continue;
                    }

                    cities[town][1] += gold;

                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
                }

                input = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                Dictionary<string, List<int>> sortedCities = cities
                    .OrderByDescending(x => x.Value[1])
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine($"Ahoy, Captain! There are {sortedCities.Count} wealthy settlements to go to:");

                foreach (var city in sortedCities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }


        }
    }
}
