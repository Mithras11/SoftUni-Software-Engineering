using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private double fuelConsumption;
        private const double airConditioning = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }


        protected override double FuelConsumption
        {
            get => this.fuelConsumption;
            set => this.fuelConsumption = value + airConditioning;
        }

        protected override double AirConditioning => airConditioning;


    }
}
