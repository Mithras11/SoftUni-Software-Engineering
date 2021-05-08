<<<<<<< HEAD
﻿using System;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;


        public string Make
        {
            get { return this.make; }

            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }

            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }

            set { this.year = value; }
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }

            set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }

            set { this.fuelConsumption = value; }
        }


        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }


        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelComsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelComsumption;
        }





        public void Drive(double distance)
        {
            bool canContinue = this.FuelQuantity - (distance * this.FuelConsumption) >= 0;

            if (canContinue)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }





    }
}
=======
﻿using System;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;


        public string Make
        {
            get { return this.make; }

            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }

            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }

            set { this.year = value; }
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }

            set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }

            set { this.fuelConsumption = value; }
        }


        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }


        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelComsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelComsumption;
        }





        public void Drive(double distance)
        {
            bool canContinue = this.FuelQuantity - (distance * this.FuelConsumption) >= 0;

            if (canContinue)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }





    }
}
>>>>>>> refs/remotes/origin/master
