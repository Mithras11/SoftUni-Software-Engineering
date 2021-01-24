using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char input;
            string output = "";

            for (int i = 0; i < 3; i++)
            {
                input = char.Parse(Console.ReadLine());
                output += input;
            }

            Console.WriteLine(output);
        }
    }
}
