using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = int.Parse(Console.ReadLine());
            long b = int.Parse(Console.ReadLine());

            a = Factorial(a);
            b = Factorial(b);

            double c = a * 1.0 / b;

            Console.WriteLine($"{c:F2}");


        }

        static long Factorial(long number)
        {
            long fact = number;

            for (long i = number - 1; i >= 1; i--)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
