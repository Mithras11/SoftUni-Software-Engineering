using System;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerWorker = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int competingFactoryBiscuits = int.Parse(Console.ReadLine());

            int totalBiscuits = 0;
            int biscuitsPerDay = 0;



            for (int i = 1; i <= 30; i++)
            {
                biscuitsPerDay = biscuitsPerWorker * countOfWorkers;

                if (i % 3 == 0)
                {
                    biscuitsPerDay = (int)Math.Floor(biscuitsPerDay * 0.75);
                }
                totalBiscuits += biscuitsPerDay;
            }
            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");

            int difference = Math.Abs(totalBiscuits - competingFactoryBiscuits);
            double percentage = difference * 1.0 / competingFactoryBiscuits * 100;

            if (totalBiscuits > competingFactoryBiscuits)
            {
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }

        }
    }
}
