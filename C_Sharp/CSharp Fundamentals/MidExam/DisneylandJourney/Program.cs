using System;

namespace DisneylandJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalCost = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double saved = totalCost * 0.25;
            double totalSaved = 0;

            for (int i = 1; i <= months; i++)
            {
                if (i % 2 != 0 && i > 1)
                {
                    totalSaved *= 0.84;
                }
                else if (i % 4 == 0)
                {
                    totalSaved *= 1.25;
                }
                totalSaved += saved;
            }

            if (totalCost <= totalSaved)
            {
                double leftMoney = totalSaved - totalCost;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {leftMoney:f2}lv. for souvenirs.");
            }
            else
            {
                double neededMoney = totalCost - totalSaved;
                Console.WriteLine($"Sorry. You need {neededMoney:f2}lv. more.");
            }

        }
    }
}
