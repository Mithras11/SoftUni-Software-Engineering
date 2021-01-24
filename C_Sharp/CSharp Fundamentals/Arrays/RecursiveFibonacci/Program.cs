using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(n));
        }

        static int GetFibonacci(int number)
        {
            int result = 0;

            if (number <= 2)
            {
                result = 1;
            }
            else
            {
                result = GetFibonacci(number - 2) + GetFibonacci(number - 1);
            }

            return result;
        }
    }
}
