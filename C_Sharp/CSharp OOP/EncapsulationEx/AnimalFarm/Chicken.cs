using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        //fields
        private const int minAge = 0;
        private const int maxAge = 15;

        protected string name;
        internal int age;


        //constructor
        internal Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        //properties
        public static int MinAge => minAge;

        public static int MaxAge => maxAge;

        public string Name
        {
            get
            {
                return this.name;
            }

            internal set
            {
                if (string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            protected set
            {
                if (value < minAge || value > maxAge)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }

                this.age = value;
            }
        }

        public double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
        }



        //methods
        private double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}
