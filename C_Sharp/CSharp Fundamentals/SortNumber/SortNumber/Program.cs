using System;

namespace SortNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int min = 0;
            int med = 0;
            int max = 0;


            if (a < b && a < c)
            {
                min = a;
            }
            else if (a > b && a < c)
            {
                med = a;
            }
            else if (a > b && a > c)
            {
                max = a;
            }

            if (b < a && b < c)
            {
                min = b;
            }
            else if (b > a && b < c)
            {
                med = b;
            }
            else if (b > a && b > c)
            {
                max = b;
            }

            if (c < a && c < b)
            {
                min = c;
            }
            else if (c > a && c < b)
            {
                med = c;
            }
            else if (c > a && c > b)
            {
                max = c;
            }

            Console.WriteLine(max);
            Console.WriteLine(med);
            Console.WriteLine(min);
        }
    }
}
