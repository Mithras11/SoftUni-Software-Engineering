using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int battery;


        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Model
        {
            get => this.model;

            private set => this.model = value;
        }

        public string Color
        {
            get => this.color;

            private set => this.color = value;
        }

        public int Battery
        {
            get => this.battery;
            private set => this.battery = value;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} batteries");
            sb.AppendLine(this.Start());
            sb.AppendLine(this.Stop());

            return sb.ToString().TrimEnd();
        }
    }

    //Red Tesla Model 3 with 2 Batteries
}
