using System;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printNames = n => Console.WriteLine($"Sir {n}");

            Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .ToList()
               .ForEach(printNames);
        }
    }
}
