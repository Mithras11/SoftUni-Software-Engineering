using System;
using System.Linq;

namespace ArcheryTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int points = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Game over")
                {
                    break;
                }
                else
                {
                    string[] command = input.Split('@');

                    switch (command[0])
                    {
                        case "Shoot Left":
                            int index = int.Parse(command[1]);
                            int length = int.Parse(command[2]);

                            if (index >= targets.Length || index < 0)
                            {
                                continue;
                            }

                            for (int i = 1; i <= length; i++)
                            {
                                index--;
                                if (index < 0)
                                {
                                    index = targets.Length - 1;
                                }
                            }


                            if (targets[index] < 5)
                            {
                                points += targets[index];
                                targets[index] = 0;
                            }
                            else
                            {
                                points += 5;
                                targets[index] -= 5;

                            }
                            break;

                        case "Shoot Right":
                            int indexator = int.Parse(command[1]);
                            int distance = int.Parse(command[2]);

                            if (indexator >= targets.Length || indexator < 0)
                            {
                                continue;
                            }

                            for (int i = 1; i <= distance; i++)
                            {
                                indexator++;
                                if (indexator >= targets.Length)
                                {
                                    indexator = 0;
                                }
                            }


                            if (targets[indexator] < 5)
                            {
                                points += targets[indexator];
                                targets[indexator] = 0;
                            }
                            else
                            {
                                points += 5;
                                targets[indexator] -= 5;

                            }

                            break;

                        case "Reverse":
                            targets = targets.Reverse().ToArray();

                            break;

                    }
                }
            }

            Console.WriteLine(string.Join(" - ", targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}
