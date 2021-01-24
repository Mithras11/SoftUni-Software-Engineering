using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace SpellingWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"([@#])(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1");

            MatchCollection validPairs = regex.Matches(text);

            if (validPairs.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
                return;
            }
            else
            {
                Console.WriteLine($"{validPairs.Count} word pairs found!");
            }


            List<string> mirrorPairs = new List<string>();

            foreach (Match pair in validPairs)
            {
                string mirrorVersion = new string(pair.Groups["firstWord"].Value.Reverse().ToArray());

                if (mirrorVersion == pair.Groups["secondWord"].Value)
                {
                    string mirrorPair = string.Concat(pair.Groups["firstWord"].Value, " <=> ", pair.Groups["secondWord"].Value);
                    mirrorPairs.Add(mirrorPair);
                }

            }

            if (mirrorPairs.Count == 0)
            {
                Console.WriteLine("No mirror words!");

            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorPairs));
            }

        }
    }
}
