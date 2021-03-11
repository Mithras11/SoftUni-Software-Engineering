using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Common
{
    public class FoodGenerator
    {
        public static Food Generate(string[] data)
        {
            Food result = null;
            string type = data[0];
            int quantity = int.Parse(data[1]);

            if (type == "Fruit")
            {
                result = new Fruit(quantity);
            }
            else if (type == "Vegetable")
            {
                result = new Vegetable(quantity);
            }
            else if (type == "Seeds")
            {
                result = new Seeds(quantity);
            }
            else if (type == "Meat")
            {
                result = new Meat(quantity);
            }

            return result;
        }
    }
}
