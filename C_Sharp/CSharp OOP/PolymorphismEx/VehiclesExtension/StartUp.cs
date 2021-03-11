using System;
using System.Linq;
using VehiclesExtension.Models;

namespace VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] info = null;
            double fuelQuantity = 0;
            double fuelConsumption = 0;
            double tankCapacity = 0;

            Car car = null;
            Truck truck = null;
            Bus bus = null;

            for (int i = 0; i < 3; i++)
            {
                 info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                 fuelQuantity = double.Parse(info[1]);
                 fuelConsumption = double.Parse(info[2]);
                 tankCapacity = double.Parse(info[3]);

                if (info[0]=="Car")
                {
                     car = new Car(fuelQuantity, fuelConsumption, tankCapacity);
                }
                else if (info[0]=="Truck")
                {
                     truck = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                }
                else if (info[0]=="Bus")
                {
                     bus = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
                }

            }


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
                    else if (command[1]=="Bus")
                    {
                        bus.Drive(distance);
                    }


                }
                else if (command[0]=="DriveEmpty")
                {
                    double distance = double.Parse(command[2]);

                    bus.DriveEmpty(distance);
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
                    else if (command[1]=="Bus")
                    {
                        bus.Refuel(liters);
                    }

                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");


        }
    }
}
