using System;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            double fuelQuantity1 = double.Parse(carInfo[1]);
            double liters1 = double.Parse(carInfo[2]);

            var car = new Car(fuelQuantity1, liters1);


            var truckInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            double fuelQuantity2 = double.Parse(truckInfo[1]);
            double liters2 = double.Parse(truckInfo[2]);

            var truck = new Truck(fuelQuantity2, liters2);



            int n = int.Parse(Console.ReadLine());
            string[] command = null;

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Drive")
                {
                    double distance = double.Parse(command[2]);

                    if (command[1] == "Car")
                    {
                        car.Drive(distance);


                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Drive(distance);
                    }

                }
                else if (command[0] == "Refuel")
                {
                    double liters = double.Parse(command[2]);

                    if (command[1] == "Car")
                    {
                        car.Refuel(liters);

                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Refuel(liters);
                    }

                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");


        }
    }
}


