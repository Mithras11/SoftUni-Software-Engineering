using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = CalculatePower(number, power);

            Console.WriteLine(result);
        }

        static double CalculatePower(double number, int power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
