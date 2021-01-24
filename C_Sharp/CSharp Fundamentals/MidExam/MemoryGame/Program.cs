using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .ToList();



            int moves = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                else
                {
                    moves++;

                    int[] indexes = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    if (indexes[0] == indexes[1]
                        || indexes[0] < 0 || indexes[1] < 0
                        || indexes[0] >= sequence.Count || indexes[1] >= sequence.Count)
                    {
                        Console.WriteLine("Invalid input! Adding additional elements to the board");
                        string newElement = "-" + moves + "a";

                        sequence.Insert(sequence.Count / 2, newElement);
                        sequence.Insert(sequence.Count / 2, newElement);
                        continue;

                    }


                    if (sequence[indexes[0]] == sequence[indexes[1]])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {sequence[indexes[0]]}!");

                        if (indexes[0] < indexes[1])
                        {
                            sequence.RemoveAt(indexes[1]);
                            sequence.RemoveAt(indexes[0]);
                        }
                        else
                        {
                            sequence.RemoveAt(indexes[0]);
                            sequence.RemoveAt(indexes[1]);
                        }

                    }

                    else
                    {

                        Console.WriteLine("Try again!");
                    }


                    if (sequence.Count == 0)
                    {
                        Console.WriteLine($"You have won in {moves} turns!");
                        return;
                    }

                }

            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(' ', sequence));

        }
    }
}
