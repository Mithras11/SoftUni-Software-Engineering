using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Car> allCars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string car = data[0];
                int mileage = int.Parse(data[1]);
                int fuel = int.Parse(data[2]);

                allCars.Add(car, new Car(mileage, fuel));
            }


            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] comamnd = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (comamnd[0] == "Drive")
                {
                    string car = comamnd[1];
                    int distance = int.Parse(comamnd[2]);
                    int neededFuel = int.Parse(comamnd[3]);

                    if (neededFuel <= allCars[car].Fuel)
                    {
                        Console.WriteLine($"{car} driven for {distance} kilometers. {neededFuel} liters of fuel consumed.");
                        allCars[car].Mileage += distance;
                        allCars[car].Fuel -= neededFuel;

                        if (allCars[car].Mileage >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");

                            allCars.Remove(car);

                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }


                }
                else if (comamnd[0] == "Refuel")
                {
                    string car = comamnd[1];
                    int moreFuel = int.Parse(comamnd[2]);

                    if (allCars[car].Fuel + moreFuel > 75)
                    {
                        moreFuel = 75 - allCars[car].Fuel;
                    }

                    allCars[car].Fuel += moreFuel;
                    Console.WriteLine($"{car} refueled with {moreFuel} liters");
                }
                else if (comamnd[0] == "Revert")
                {
                    string car = comamnd[1];
                    int kilometers = int.Parse(comamnd[2]);

                    allCars[car].Mileage -= kilometers;

                    if (allCars[car].Mileage < 10000)
                    {
                        allCars[car].Mileage = 10000;

                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");

                    }
                }
                input = Console.ReadLine();
            }


            Dictionary<string, Car> sortedCars = allCars
                .OrderByDescending(x => x.Value.Mileage)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedCars)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Mileage} kms, Fuel in the tank: {item.Value.Fuel} lt.");
            }
        }

        public class Car
        {
            public int Mileage { get; set; }
            public int Fuel { get; set; }

            public Car(int mileage, int fuel)
            {
                this.Mileage = mileage;
                this.Fuel = fuel;
            }


        }

    }
}
