using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<char> symbols = new List<char>();

            Regex regex = new Regex(@"(?<symbols>\D+)(?<count>[0-1]?[0-9]?|[20])");

            MatchCollection matches = regex.Matches(text);

            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                int count = int.Parse(match.Groups["count"].Value);

                for (int i = 0; i < count; i++)
                {
                    sb.Append(match.Groups["symbols"]);
                }

                foreach (char item in match.Groups["symbols"].Value)
                {
                    if ((!symbols.Contains(Char.ToLowerInvariant(item))) && item != ' ')
                    {
                        symbols.Add(Char.ToLowerInvariant(item));
                    }
                }
            }


            Console.WriteLine($"Unique symbols used: {symbols.Count}");
            Console.WriteLine(sb.ToString().ToUpper());


        }
    }
}
