using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public class SaltwaterFish : Fish
    {
        public SaltwaterFish(string name, string species, decimal price)
           : base(name, species, price)
        {
            this.Size = 5;
            this.SuitableAquarium = "SaltwaterAquarium";
        }

        public override void Eat()
        {
            this.Size += 2;
        }
    }
}
