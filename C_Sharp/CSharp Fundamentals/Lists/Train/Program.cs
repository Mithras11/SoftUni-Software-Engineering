using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input.StartsWith("Add"))
                {
                    string[] command = input.Split();
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    int newPassengers = int.Parse(input);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (newPassengers + wagons[i] <= maxCapacity)
                        {
                            wagons[i] += newPassengers;
                            break;
                        }
                    }

                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ',wagons));
        }
    }
}
