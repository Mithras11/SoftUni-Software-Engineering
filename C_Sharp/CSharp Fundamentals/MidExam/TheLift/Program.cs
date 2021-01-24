using System;
using System.Collections.Generic;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> lift = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < lift.Count; i++)
            {
                int currentWagon = lift[i];
                int availableSpace = 4 - currentWagon;

                if (availableSpace == 0)
                {
                    continue;
                }
                else
                {
                    if (peopleWaiting > 4)
                    {
                        int currentPassengers = availableSpace;
                        lift[i] += currentPassengers;
                        peopleWaiting -= currentPassengers;

                    }
                    else
                    {
                        if (availableSpace < peopleWaiting)
                        {
                            int currentPassengers = availableSpace;
                            lift[i] += currentPassengers;
                            peopleWaiting -= currentPassengers;
                        }
                        else
                        {
                            lift[i] += peopleWaiting;
                            peopleWaiting = 0;

                        }
                    }

                }
            }

            bool isEmpty = false;

            foreach (int wagon in lift)
            {
                if (wagon < 4)
                {
                    isEmpty = true;
                    break;
                }

            }

            if (isEmpty)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', lift));
            }
            else
            {
                if (peopleWaiting > 0)
                {
                    Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                    Console.WriteLine(string.Join(' ', lift));
                }
                else
                {
                    Console.WriteLine(string.Join(' ', lift));
                }
            }









        }
    }
}
