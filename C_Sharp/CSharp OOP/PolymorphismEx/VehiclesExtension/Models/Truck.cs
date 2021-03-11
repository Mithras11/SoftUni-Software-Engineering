using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Models
{
    public class Truck : Vehicle
    {
        private double fuelConsumption;
        private const double airConditioning = 1.6;
        private const double hole = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }


        protected override double FuelConsumption
        {
            get => this.fuelConsumption;
            set => this.fuelConsumption = value + airConditioning;
        }



        protected override double AirConditioning => airConditioning;

        public double Hole => hole;



        public override void Refuel(double liters)
        {
            if (this.FuelQuantity + liters * hole > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {

                this.FuelQuantity += liters * hole;

            }

        }
    }

}

