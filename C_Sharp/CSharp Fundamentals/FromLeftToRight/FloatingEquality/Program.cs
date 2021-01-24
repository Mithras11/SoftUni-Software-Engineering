using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double precisionEps = 0.000001;

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if ((a-b>precisionEps)||(b-a>precisionEps))
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
