using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private double fuelConsumption;
        private const double airConditioning = 1.6;
        private const double hole = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
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
            this.FuelQuantity +=  liters * hole;
        }
    }

}

