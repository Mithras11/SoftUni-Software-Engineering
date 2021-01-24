using System;
using System.ComponentModel.DataAnnotations;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double min = double.MaxValue;
            double max = double.MinValue;
            double medium = 0;

            for (int i = 1; i <=3; i++)
            {
                double n = double.Parse(Console.ReadLine());

                if (n < min)
                {
                    min = n;
                }
                else if (n > max)
                {
                    max = n;
                }
                else
                {
                    medium = n;
                }

            }

            Console.WriteLine($"{min}/n{medium}/n{max}");




        }




    }
}
}
