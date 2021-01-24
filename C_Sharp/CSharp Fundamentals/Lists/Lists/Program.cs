
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                else
                {
                    string[] command = input.Split();

                    switch (command[0])
                    {
                        case "Delete":

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == int.Parse(command[1]))
                                {
                                    numbers.RemoveAt(i);
                                }
                            }
                            break;
                        case "Insert":
                            numbers.Insert(int.Parse(command[2]),
                                           int.Parse(command[1]));
                            break;
                    }
                }
            }
            Console.WriteLine(string.Join(' ', numbers));

        }
    }
}