using System;

namespace TypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a;
            double b;
            bool c;
            char d;

            while (input != "END")
            {
                if (int.TryParse(input, out a))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out b))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (bool.TryParse(input, out c))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (char.TryParse(input, out d))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }


                input = Console.ReadLine();
            }
        }
    }
}
