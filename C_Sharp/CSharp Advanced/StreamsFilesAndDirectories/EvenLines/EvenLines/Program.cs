using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                
                    string line = reader.ReadLine();
                    int counter = 0;

                    while (line != null)
                    {
                        if (counter % 2 == 0)
                        {
                            Regex pattern = new Regex("[-,.!?]");
                            line = pattern.Replace(line, "@");

                            var arr = line.Split().ToArray().Reverse();

                            Console.WriteLine(string.Join(' ', arr));
                        }

                        counter++;
                        line = reader.ReadLine();
                    
                }
            }

        }
    }
}
