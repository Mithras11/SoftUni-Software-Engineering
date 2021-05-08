using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
