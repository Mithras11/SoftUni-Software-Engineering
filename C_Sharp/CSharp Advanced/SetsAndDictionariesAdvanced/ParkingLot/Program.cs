using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string currCar = tokens[1];

                if (tokens[0] == "IN")
                {
                    cars.Add(currCar);

                }
                else if (tokens[0] == "OUT")
                {
                    cars.Remove(currCar);
                }

            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                Environment.Exit(0);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}
