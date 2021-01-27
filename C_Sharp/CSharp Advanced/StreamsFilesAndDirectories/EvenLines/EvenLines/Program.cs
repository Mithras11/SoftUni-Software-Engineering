using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EvenLines
{
    public class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader(@"../../../text.txt");

            int counter = 0;

            string line = reader.ReadLine();

            while (line != null)
            {
                if (counter % 2 == 0)
                {

                    line = Regex.Replace(line, "[-,.!?]", "@");

                    var arr = line.Split().ToArray().Reverse();

                    Console.WriteLine(string.Join(' ', arr));
                }

                counter++;

                line = reader.ReadLine();

            }


        }
    }
}
