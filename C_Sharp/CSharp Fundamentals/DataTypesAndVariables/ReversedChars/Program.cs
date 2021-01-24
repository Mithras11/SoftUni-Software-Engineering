using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            char input3 = char.Parse(Console.ReadLine());

            Console.WriteLine("{2} {1} {0}", input1, input2, input3);

        }
    }
}
