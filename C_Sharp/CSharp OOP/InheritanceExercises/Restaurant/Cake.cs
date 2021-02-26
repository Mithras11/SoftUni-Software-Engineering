using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
   public  class Cake:Dessert
    {
        private const double grams = 250;
        private const double calories = 1000;
        private const decimal cakePrice= 5M;
        public Cake(string name)
            :base(name, 0, 0, 0)
        {

        }

        public override double Calories => calories;
        public override double Grams => grams;

        public override decimal Price => cakePrice;
    }
}
