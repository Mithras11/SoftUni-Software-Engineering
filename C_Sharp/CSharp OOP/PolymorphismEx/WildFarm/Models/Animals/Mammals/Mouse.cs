using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Squeak");
        }


        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetatble" &&
                food.GetType().Name != "Fruit")
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                this.Weight += 0.10 * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
        }


        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
