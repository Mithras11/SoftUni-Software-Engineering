using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        //fields
        private string flowerType;
        private string bakingTechnique;
        private double weight;

        //constructor



        public Dough()
        {

        }


        public Dough(string flowerType, string bakingTechnique, double weight)
        {
            this.FlowerType = flowerType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }


        //properties
        public string FlowerType
        {
            get
            {
                return flowerType;
            }

            private set
            {
                

                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flowerType = value;
            }
        }


        public string BakingTechnique
        {
            get
            {
                return bakingTechnique;
            }

            private set
            {
                

                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }

            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }


        //methods

        public double CalculateCalories()
        {
            double modifier = 1;

            switch (flowerType.ToLower())
            {
                case "white":
                    modifier = 1.5;
                    break;

                case "wholegrain":
                    modifier = 1.0;
                    break;
            }


            switch (bakingTechnique.ToLower())
            {
                case "crispy":
                    modifier *= 0.9;
                    break;

                case "chewy":
                    modifier *= 1.1;
                    break;

                case "homemade":
                    modifier *= 1.0;
                    break;
            }


            return 2 * this.weight * modifier;


        }
    }
}
