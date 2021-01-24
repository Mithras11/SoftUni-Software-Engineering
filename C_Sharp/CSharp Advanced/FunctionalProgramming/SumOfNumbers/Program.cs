using System;
using System.Linq;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Action<int[]> processNumbers = n =>
            {
                Console.WriteLine(n.Length);

                Console.WriteLine(n.Sum());
            };

            processNumbers(numbers);
        }
    }
}
