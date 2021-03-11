using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Cluck");
        }

        public override void Eat(Food food)
        {
            this.Weight += 0.35 * food.Quantity;
            this.FoodEaten += food.Quantity;
        }
    }
}
