using System;

namespace Person
{
    public class Person
    {
        //fields

        private string name;
        private int age;

        //constructor

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        //properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }



        public  int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age could not be negative number");
                }
                else
                {
                    this.age = value;

                }
            }
        }


        //methods

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }




    }
}
