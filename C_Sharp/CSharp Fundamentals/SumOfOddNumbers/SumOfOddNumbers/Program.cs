using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var x = 1;
            var sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(x);
                sum += x;
                x += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
