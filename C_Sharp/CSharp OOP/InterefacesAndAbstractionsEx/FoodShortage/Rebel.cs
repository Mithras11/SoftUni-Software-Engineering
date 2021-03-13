using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food = 0;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.age = age;
            this.group = group;

        }


        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }

        public int Food
        {
            get => this.food;
            private set => this.food = value;
        }

        public void BuyGood()
        {
            this.Food += 5;

        }
    }
}
