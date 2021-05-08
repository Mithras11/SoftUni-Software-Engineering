using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                else
                {
                    string[] commands = command.Split();
                    int index = int.Parse(commands[1]);

                    switch (commands[0])
                    {
                        case "Shoot":
                            int power = int.Parse(commands[2]);

                            if (index >= targets.Count || index < 0)
                            {
                                continue;
                            }

                            targets[index] -= power;

                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }

                            break;

                        case "Add":
                            int value = int.Parse(commands[2]);

                            if (index >= targets.Count || index < 0)
                            {
                                Console.WriteLine("Invalid placement!");
                                continue;
                            }

                            targets.Insert(index, value);

                            break;

                        case "Strike":
                            int radius = int.Parse(commands[2]);

                            int startingIndexOfRange = index - radius;
                            int range = (radius * 2) + 1;

                            if (startingIndexOfRange < 0 || (index + radius) >= targets.Count)
                            {
                                Console.WriteLine("Strike missed!");
                                continue;
                            }

                            targets.RemoveRange(startingIndexOfRange, range);
                            break;
                    }
                }
            }

            Console.WriteLine(string.Join('|', targets));
        }
    }
}
