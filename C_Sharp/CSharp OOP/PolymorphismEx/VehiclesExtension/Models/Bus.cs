using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Models
{

    public class Bus : Vehicle
    {
        private double fuelConsumption;
        private const double airConditioning = 1.4;


        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }


        protected override double FuelConsumption
        {
            get => this.fuelConsumption;
            set => this.fuelConsumption = value;
        }

        protected override double AirConditioning => airConditioning;


        public override void Drive(double distance)
        {
            if (this.FuelQuantity >= (this.FuelConsumption + this.AirConditioning) * distance)
            {
                this.FuelQuantity -= (this.FuelConsumption + this.AirConditioning) * distance;

                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }


        public void DriveEmpty(double distance)
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
    }
}
