using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalog2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                else
                {
                    string[] data = input.Split();

                    Vehicle vehicle = new Vehicle(data[0], data[1], data[2], double.Parse(data[3]));
                    vehicles.Add(vehicle);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();


                if (command == "Close the Catalogue")
                {
                    break;
                }
                else
                {
                    foreach (var item in vehicles)
                    {
                        if (item.Model == command)
                        {
                            Vehicle currentVehicle = item;

                            Console.WriteLine(currentVehicle.ToString());


                        }
                    }

                }
            }

            double carSumOfHorsePower = 0.0;
            int carCount = 0;
            double truckSumOfHorsePower = 0.0;
            int truckCount = 0;

            foreach (var item in vehicles)
            {
                if (item.Type == "car")
                {
                    carSumOfHorsePower += item.HorsePower;
                    carCount++;
                }
                else
                {
                    truckSumOfHorsePower += item.HorsePower;
                    truckCount++;
                }
            }

            double carAverageHorsePower = 0;
            if (carCount > 0)
            {
                carAverageHorsePower = carSumOfHorsePower  / carCount;
            }
            double truckAverageHorsePower = 0;
            if (truckCount > 0)
            {
                truckAverageHorsePower = truckSumOfHorsePower  / truckCount;
            }


            Console.WriteLine($"Cars have average horsepower of: {carAverageHorsePower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAverageHorsePower:F2}.");

        }

        public class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double HorsePower { get; set; }

            public Vehicle(string type, string model, string color, double horsePower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower;
            }

            public override string ToString()
            {
                if (Type == "car")
                {
                    return $"Type: Car \nModel: {Model} \nColor: {Color} \nHorsepower: {HorsePower}";

                }
                else
                {
                    return $"Type: Truck \nModel: {Model} \nColor: {Color} \nHorsepower: {HorsePower}";
                }

            }
        }
    }
}