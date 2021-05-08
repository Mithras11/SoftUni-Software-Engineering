using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    public class MuscleCar : Car
    {
        public MuscleCar(string model, int horsePower) 
            : base(model, horsePower, 5000, 400, 600)
        {
            if (400 > horsePower || 600 < horsePower)
            {
                throw new ArgumentException($"Invalid horse power: {horsePower}.");
            }
        }
    }
}
