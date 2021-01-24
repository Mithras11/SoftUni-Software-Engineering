using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> rarities = new Dictionary<string, double>();
            Dictionary<string, List<double>> ratings = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] plant = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (rarities.ContainsKey(plant[0]))
                {
                    rarities[plant[0]] = double.Parse(plant[1]);
                }
                else
                {
                    rarities.Add(plant[0], double.Parse(plant[1]));
                }
            }

            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                string[] command = input.Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Rate")
                {
                    string[] data = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string plant = data[0];

                    double rating = double.Parse(data[1]);

                    if (ratings.ContainsKey(plant))
                    {
                        ratings[plant].Add(rating);

                    }
                    else
                    {
                        if (rarities.ContainsKey(data[1]))
                        {
                            ratings.Add(plant, new List<double>() { rating });
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                    }
                }
                else if (command[0] == "Update")
                {
                    string[] data = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string plant = data[0];
                    double rarity = double.Parse(data[1]);

                    if (rarities.ContainsKey(plant))
                    {
                        rarities[plant] = rarity;

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "Reset")
                {
                    string plant = command[1];

                    if (ratings.ContainsKey(plant))
                    {
                        ratings[plant].Clear();

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else
                {
                    Console.WriteLine("error");
                    continue;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            Dictionary<string, double> sortedRatings = new Dictionary<string, double>();

            foreach (var item in ratings)
            {
                if (item.Value.Count != 0)
                {
                    double average = item.Value.Average();
                    sortedRatings.Add(item.Key, average);
                }
                else
                {
                    sortedRatings.Add(item.Key, 0);
                }

            }


            Dictionary<string, List<double>> allPlants = new Dictionary<string, List<double>>();

            foreach (var item in rarities)
            {
                allPlants.Add(item.Key, new List<double>() { item.Value, sortedRatings[item.Key] });
            }

            allPlants = allPlants.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]).ToDictionary(x => x.Key, x => x.Value);




            foreach (var item in allPlants)
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[1]:f2}");
            }



        }
    }
}