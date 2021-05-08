using System;

namespace RecursiveFactorial
{
    class RecursiveFactorial
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var result = Factorial(num);

            Console.WriteLine(result);

        }

        static long Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }

    }
}
