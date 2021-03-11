using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Foods
{
   public abstract class Food
    {
        public Food(int qunatity)
        {
            this.Quantity = qunatity;
        }

        public int Quantity { get; set; }
    }
}
