using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterial = new Dictionary<string, int>(){
                { "shards", 0 },
                { "fragments", 0},
                { "motes", 0}
            };


            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            bool isObtained = false;


            while (isObtained == false)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int i = 0, j = 1; i <= input.Length - 2 && j <= input.Length - 1; i += 2, j += 2)
                {
                    string currentMaterial = input[j].ToLower();
                    int currentQuantity = int.Parse(input[i]);

                    if (currentMaterial == "shards"
                        || currentMaterial == "fragments"
                        || currentMaterial == "motes")

                    {
                        if (keyMaterial.ContainsKey(currentMaterial))
                        {
                            keyMaterial[currentMaterial] += currentQuantity;

                        }


                        if (keyMaterial[currentMaterial] >= 250)
                        {
                            isObtained = true;
                            keyMaterial[currentMaterial] -= 250;

                            switch (currentMaterial)
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;

                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;

                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                            }

                            break;

                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(currentMaterial))
                        {
                            junk[currentMaterial] += currentQuantity;
                        }
                        else
                        {
                            junk.Add(currentMaterial, currentQuantity);
                        }
                    }


                }

            }

            var sortedKeyMaterial = keyMaterial.OrderByDescending(pair => pair.Value)
                .ThenBy(pair => pair.Key)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var material in sortedKeyMaterial)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in junk)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }


        }
    }
}
