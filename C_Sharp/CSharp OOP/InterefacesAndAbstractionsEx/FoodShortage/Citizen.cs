using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Citizen : IBuyer
    {

        private string name;
        private int age;
        private string id;
        private string birthdate;
        private int food;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.age = age;
            this.id = id;
            this.birthdate = birthdate;
            this.Food = 0;
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
            this.Food += 10;

        }
    }

}
