using System;

namespace RawData
{
    public class Cargo
    {
        private int weight;
        private string type;

        public int Weight { get; set; }
        public string Type { get; set; }

        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
    }
}
