using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drumSet = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> currentDrumSet = new List<int>();

            for (int i = 0; i < drumSet.Count; i++)
            {
                int currentDrum = drumSet[i];
                currentDrumSet.Add(currentDrum);
            }

            string input = Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);



                for (int i = 0; i < currentDrumSet.Count; i++)
                {
                    currentDrumSet[i] -= hitPower;

                    if (currentDrumSet[i] <= 0)
                    {
                        int price = drumSet[i] * 3;

                        if (price > savings)
                        {
                            currentDrumSet.RemoveAt(i);
                            drumSet.RemoveAt(i);

                            i--;

                        }
                        else
                        {
                            currentDrumSet[i] = drumSet[i];
                            savings -= price;

                        }


                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', currentDrumSet));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");










        }
    }
}
