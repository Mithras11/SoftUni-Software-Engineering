using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> findSmallest = (arr) =>
               {
                   int minValue = int.MaxValue;

                   foreach (int num in arr)
                   {
                       if (num < minValue)
                       {
                           minValue = num;
                       }
                   }

                   return minValue;


               };

            Action<int> printNum = n => Console.WriteLine(n);

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            printNum(findSmallest(numbers));







        }
    }
}
