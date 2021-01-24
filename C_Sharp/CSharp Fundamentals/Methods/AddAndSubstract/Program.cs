using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = Sum(a, b);
            int subtraction = Subtraction(sum, c);

            Console.WriteLine(subtraction);
        }

        static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;

        }

        static int Subtraction(int num1, int num2)
        {
            int subtraction = num1 - num2;
            return subtraction;
        }
    }
}
