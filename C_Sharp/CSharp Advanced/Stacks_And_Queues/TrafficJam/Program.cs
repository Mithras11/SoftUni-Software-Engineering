using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            int counter = 0;

            Queue<string> cars = new Queue<string>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    for (int i = 0; i < numberOfCars; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Peek()} passed!");
                            cars.Dequeue();
                            counter++;
                        }


                    }
                }
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
