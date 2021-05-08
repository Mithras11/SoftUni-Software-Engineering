using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Models
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;

        }


        public double FuelQuantity
        {
            get => this.fuelQuantity;

            set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }

            }
        }

        protected abstract double FuelConsumption { get; set; }

        protected abstract double AirConditioning { get; }

        public double TankCapacity { get; protected set; }




        public virtual void Drive(double distance)
        {
            if (this.FuelQuantity >= this.FuelConsumption * distance)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;

                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }

        }


        public virtual void Refuel(double liters)
        {
            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                this.FuelQuantity += liters;

            }

        }


    }
}
