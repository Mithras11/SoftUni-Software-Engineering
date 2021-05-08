using System;

namespace EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());

            int cozonacs = 0;
            int coloredEggs = 0;

            double eggPrice = flourPrice * 0.75;
            double milkPricePerLiter = flourPrice * 1.25;
            double milkPerCozonac = milkPricePerLiter * 0.25;

            double cozonacPrice = eggPrice + flourPrice + milkPerCozonac;

            while (budget > 0)
            {
                if (budget - cozonacPrice >= 0)
                {
                    budget -= cozonacPrice;
                    cozonacs++;
                    coloredEggs += 3;

                    if (cozonacs % 3 == 0)
                    {
                        coloredEggs -= (cozonacs - 2);
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"You made {cozonacs} cozonacs! Now you have {coloredEggs} eggs and {budget:f2}BGN left.");





        }
    }
}
