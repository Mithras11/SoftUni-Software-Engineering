using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {

        public class PlantInfo
        {
            public int Rarity { get; set; }
            public List<double> Ratings { get; set; }

            public double averageRating { get; set; }


            public PlantInfo(int rarity)
            {
                this.Rarity = rarity;
                this.Ratings = new List<double>();
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, PlantInfo> allPlants = new Dictionary<string, PlantInfo>();

            for (int i = 0; i < n; i++)
            {
                string[] newPlant = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = newPlant[0];
                int rarity = int.Parse(newPlant[1]);

                if (allPlants.ContainsKey(name))
                {
                    allPlants[name].Rarity = rarity;
                }
                else
                {
                    allPlants.Add(name, new PlantInfo(rarity));

                }
            }

            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                string[] command = input.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Rate")
                {
                    string currentPlant = command[1];
                    double rating = double.Parse(command[2]);

                    if (allPlants.ContainsKey(currentPlant))
                    {
                        allPlants[currentPlant].Ratings.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "Update")
                {
                    string currentPlant = command[1];
                    int newRarity = int.Parse(command[2]);

                    if (allPlants.ContainsKey(currentPlant))
                    {
                        allPlants[currentPlant].Rarity = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "Reset")
                {
                    string currentPlant = command[1];

                    if (allPlants.ContainsKey(currentPlant))
                    {
                        allPlants[currentPlant].Ratings.Clear();

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");

                }

                input = Console.ReadLine();
            }

            foreach (var plant in allPlants)
            {
                if (plant.Value.Ratings.Count != 0)
                {
                    plant.Value.averageRating = plant.Value.Ratings.Average();
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            Dictionary<string, PlantInfo> sortedPlants = allPlants
                .OrderByDescending(x => x.Value.Rarity)
                .ThenByDescending(x => x.Value.averageRating)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedPlants)
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {item.Value.averageRating:F2}");
            }






        }
    }
}
