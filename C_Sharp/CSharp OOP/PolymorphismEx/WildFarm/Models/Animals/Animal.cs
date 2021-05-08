using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public abstract class Animal
    {
        public  Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten= 0;

        }



        public string Name { get; private set; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }



        public abstract void AskForFood();

        public abstract void Eat(Food food);


        
    }
}
