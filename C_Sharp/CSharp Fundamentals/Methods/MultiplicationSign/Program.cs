using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Sign(a, b, c);

        }

        public static void Sign(int a, int b, int c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("zero");
            }
            else if ((a < 0 && b > 0 && c > 0)
                || (a > 0 && b < 0 && c > 0)
                || (a > 0 && b > 0 && c < 0)
                || (a < 0 && b < 0 && c < 0))

            {
                Console.WriteLine("negative");



            }
            else
            {
                Console.WriteLine("positive");
            }

        }
    }
}
