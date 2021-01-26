using System;
using System.IO;

namespace LineNumbersLab
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("../../../input.txt");
            using var writer = new StreamWriter("../../../output.txt");

            int counter = 1;

            while (true)
            {
                var line = reader.ReadLine();

                if (line==null)
                {
                    break;
                }

                writer.WriteLine($"{counter}. {line}");

                counter++;
            }
        }
    }
}
