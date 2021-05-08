using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootForTheWIn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int count = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                else
                {
                    int index = int.Parse(input);

                    if (index >= targets.Count)
                    {
                        continue;
                    }
                    else
                    {

                        if (targets[index] == -1)
                        {
                            continue;
                        }
                        else
                        {

                            for (int i = 0; i < targets.Count; i++)
                            {
                                if (i==index)
                                {
                                    continue;
                                }
                                if (targets[i] > targets[index])
                                {
                                    targets[i] -= targets[index];
                                }
                                else if (targets[i] <= targets[index] && targets[i] != -1)
                                {
                                                          
                                    targets[i] += targets[index];
                                }
                            }

                            targets[index] = -1;
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(' ', targets)}");








        }
    }
}
