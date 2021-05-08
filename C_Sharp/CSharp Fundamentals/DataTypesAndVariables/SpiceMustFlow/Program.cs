using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            int days = 0;

            while (yield >= 100)
            {
                totalAmount += yield;
                days++;
                yield -= 10;

                if (totalAmount >= 26)
                {
                    totalAmount -= 26;
                }
            }
            if (totalAmount >= 26)
            {
                totalAmount -= 26;
            }

            Console.WriteLine($"{days}\n{totalAmount}");


        }
    }
}
