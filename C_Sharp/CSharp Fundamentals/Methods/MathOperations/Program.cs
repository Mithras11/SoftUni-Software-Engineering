using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int result = CalculateNums(num1,sign, num2);

            Console.WriteLine($"{result}");
        }

        static int CalculateNums(int num1, char sign, int num2)
        {
            int result = 0;

            switch (sign)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    result = num1 / num2;
                    break;
            }

            return result;

        }
    }
}
