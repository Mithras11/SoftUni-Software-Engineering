using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Meow");
        }


        public override void Eat(Food food)
        {
            string type = food.GetType().Name;

            if (food.GetType().Name != "Meat" &&
                food.GetType().Name != "Vegetable") 
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                this.Weight += 0.30 * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
        }


    }
}
