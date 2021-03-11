using System;
using System.Collections.Generic;
using System.Text;

using WildFarm.Models.Animals;
using WildFarm.Models.Animals.Birds;
using WildFarm.Models.Animals.Mammals;
using WildFarm.Models.Animals.Mammals.Felines;

namespace WildFarm.Common
{
    public class AnimalGenerator
    {
        public static Animal Generate(params string[] data)
        {
            Animal result = null;

            string type = data[0];
            string name = data[1];
            double weight = double.Parse(data[2]);

            if (type == "Hen" || type == "Owl")
            {

                double wingSize = double.Parse(data[3]);

                if (type == "Hen")
                {
                    result = new Hen(name, weight, wingSize);
                }
                else if (type == "Owl")
                {
                    result = new Owl(name, weight, wingSize);
                }
            }
            else if (type == "Cat" || type == "Tiger")
            {

                string livingRegion = data[3];
                string breed = data[4];

                if (type == "Cat")
                {
                    result = new Cat(name, weight, livingRegion, breed);
                }
                else if (type == "Tiger")
                {
                    result = new Tiger(name, weight, livingRegion, breed);
                }
            }
            else if (type == "Dog" || type == "Mouse")
            {
                string livingRegion = data[3];

                if (type == "Dog")
                {
                    result = new Dog(name, weight, livingRegion);
                }
                else if (type == "Mouse")
                {
                    result = new Mouse(name, weight, livingRegion);
                }
            }





            return result;


        }
    }
}
