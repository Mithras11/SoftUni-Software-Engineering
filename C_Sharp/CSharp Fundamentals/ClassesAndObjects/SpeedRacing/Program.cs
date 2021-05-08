using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                cars.Add(new Car(data[0], double.Parse(data[1]), double.Parse(data[2])));
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = command[1];
                double amountOfKm = double.Parse(command[2]);

                Car currCar = cars.Find(x => x.Model == model);

                currCar.Drive(amountOfKm);

            }

            foreach (Car car in cars)
            {

                Console.WriteLine($"{string.Join(' ', car.Model, (car.FuelAmount).ToString("F2"), car.TraveledDistance)}");
            }




        }

        class Car
        {
            public string Model { get; set; }
            public double FuelAmount { get; set; }
            public double ConsumptionPerKm { get; set; }
            public double TraveledDistance { get; set; }

            public Car(string model, double fuelAmount, double consumptionPerKm)
            {
                double traveledDistance = 0;

                this.Model = model;
                this.FuelAmount = fuelAmount;
                this.ConsumptionPerKm = consumptionPerKm;
                this.TraveledDistance = traveledDistance;

            }


            public void Drive(double amountOfKm)
            {
                if (amountOfKm <= (FuelAmount / ConsumptionPerKm))
                {
                    FuelAmount -= (amountOfKm * ConsumptionPerKm);
                    TraveledDistance += amountOfKm;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
        }
    }
}
