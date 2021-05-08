using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals.Felines
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight,  string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("ROAR!!!");
        }


        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                this.Weight += 1.00 * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
        }

        
    }
}
