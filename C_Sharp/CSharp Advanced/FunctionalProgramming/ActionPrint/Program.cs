using System;
using System.Linq;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printNames = n => Console.WriteLine(n);

            Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .ToList()
               .ForEach(printNames);


        }
    }
}
