using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        //fields
        
        private string type;
        private double wight;

        //constructor
        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;

        }

        //properties
        public string Type
        {
            get
            {
                return type;
            }

            private set
            {


                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                type = value;
            }
        }


        public double Weight
        {
            get
            {
                return wight;
            }

            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }
                wight = value;
            }
        }


        //methods
        public double CalculateCalories()
        {
            double modifier = 1;

            switch (type.ToLower())
            {
                case "meat":
                    modifier = 1.2;
                    break;

                case "veggies":
                    modifier = 0.8;
                    break;

                case "cheese":
                    modifier *= 1.1;
                    break;

                case "sauce":
                    modifier *= 0.9;
                    break;

            }


            return 2 * this.wight * modifier;


        }


    }
}
