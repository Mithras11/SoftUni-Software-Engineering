using System;
using System.Collections.Generic;

namespace Binomial_Coefficients
{
    class Program
    {
        private static Dictionary<string, long> memo;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            memo = new Dictionary<string, long>();
            Console.WriteLine(GetBinomialCoefficient(n, k));
        }

        private static long GetBinomialCoefficient(int n, int k)
        {
            string paramsAsString = $"{n}-{k}";
            if (memo.ContainsKey(paramsAsString))
            {
                return memo[paramsAsString];
            }
            if (n <= 1 || k == 0 || k == n)
            {
                return 1;
            }

            var result = GetBinomialCoefficient(n - 1, k - 1)
                + GetBinomialCoefficient(n - 1, k);
            memo[paramsAsString] = result;
            return result;
        }
    }
}
