using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = GetFibonacci(n);

            Console.WriteLine(result);
        }

        static int GetFibonacci(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            int result = GetFibonacci(n - 1) + GetFibonacci(n - 2);

            return result;
        }
    }
}
