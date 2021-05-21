using System;

namespace Fibonacci_withMemoization
{
    class Program
    {
        static int n;
        static long[] memo;
        static long result;
        static long Fib(int n)
        {
            if (memo[n] != 0)
            {
                return memo[n];
            }
            if (n == 1 || n == 2)
            {
                return 1;
            }

            result = Fib(n - 1) + Fib(n - 2);
            memo[n] = result;

            return result;
        }

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            memo = new long[n + 1];

            Console.WriteLine(Fib(n));
        }
    }
}
