using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            int positionIndex = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Love!")
                {
                    break;
                }
                else
                {
                    string[] commands = input.Split();
                    int jumpLength = int.Parse(commands[1]);

                    positionIndex += jumpLength;

                    if (positionIndex > neighborhood.Count - 1)
                    {
                        positionIndex = 0;
                    }



                    if (neighborhood[positionIndex] == 0)
                    {
                        Console.WriteLine($"Place {positionIndex} already had Valentine's day.");
                    }
                    else
                    {
                        neighborhood[positionIndex] -= 2;

                        if (neighborhood[positionIndex] == 0)
                        {
                            Console.WriteLine($"Place {positionIndex} has Valentine's day.");
                        }
                    }
                }
            }

            Console.WriteLine($"Cupid's last position was {positionIndex}.");

            int failedHouseCount = 0;

            foreach (var item in neighborhood)
            {
                if (item > 0)
                {
                    failedHouseCount++;
                }
            }

            if (failedHouseCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedHouseCount} places.");
            }

        }
    }
}
