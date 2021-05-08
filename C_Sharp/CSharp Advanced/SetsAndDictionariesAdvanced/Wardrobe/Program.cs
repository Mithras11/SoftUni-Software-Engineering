using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                //Blue -> dress,jeans,hat

                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];

                if (wardrobe.ContainsKey(color) == false)
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                string[] clothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                foreach (string cloth in clothes)
                {
                    if (wardrobe[color].ContainsKey(cloth) == false)
                    {
                        wardrobe[color][cloth] = 1;
                    }
                    else
                    {
                        wardrobe[color][cloth]++;
                    }
                }

            }

            string[] clothWanted = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in wardrobe)
            {

                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cloth in color.Value)
                {
                    if (clothWanted[0] == color.Key && clothWanted[1] == cloth.Key)
                    {

                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                        continue;
                    }

                    Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                }
            }
        }
    }
}
