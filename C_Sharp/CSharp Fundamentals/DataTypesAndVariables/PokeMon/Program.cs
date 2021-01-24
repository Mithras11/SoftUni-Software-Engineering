using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double x = n / 2;
            int count = 0;

            while (n >= m)
            {
                n -= m;
                count++;

                if (n == x && y != 0)
                {
                    n /= y;
                }
            }

            Console.WriteLine($"{n}\n{count}");
        }
    }
}
