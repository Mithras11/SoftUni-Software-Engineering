using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstDistance = CalculateDistance(x1, y1, x2, y2);

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double secondDistance = CalculateDistance(x3, y3, x4, y4);

            if (firstDistance >= secondDistance)
            {
                ComparePoints(x1, y1, x2, y2);

            }
            else if (secondDistance > firstDistance)
            {
                ComparePoints(x3, y3, x4, y4);
            }


        }

        static void ComparePoints(double x1, double y1, double x2 , double y2 )
        {
            double firstPointLine = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondPointLine = Math.Sqrt(x2 * x2 + y2 * y2);

            if (firstPointLine <= secondPointLine)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }

            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

        static double CalculateDistance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}

