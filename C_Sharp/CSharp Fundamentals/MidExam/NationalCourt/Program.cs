using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int efficiency1 = int.Parse(Console.ReadLine());
            int efficiency2 = int.Parse(Console.ReadLine());
            int efficiency3 = int.Parse(Console.ReadLine());

            int peopleCount = int.Parse(Console.ReadLine());

            int efficiencyPerHour = efficiency1 + efficiency2 + efficiency3;
            int hourCount = 0;

            while (peopleCount > 0)
            {
                hourCount++;

                if (hourCount % 4 == 0)
                {
                    
                    continue;
                }
                peopleCount -= efficiencyPerHour;
            }


            Console.WriteLine($"Time needed: {hourCount}h.");


        }
    }
}
