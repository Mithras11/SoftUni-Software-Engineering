using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("../../../input.txt");
            using var writer = new StreamWriter("../../../output.txt");

            int counter = 0;

            while (true)
            {
                var line = reader.ReadLine();

                if (line == null || line == string.Empty)
                {
                    break;
                }

                if (counter % 2 != 0)
                {
                    writer.WriteLine(line);
                }

                counter++;

            }




        }
    }
}
