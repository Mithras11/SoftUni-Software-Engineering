using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var digits = Regex.Matches(input, @"\d").Cast<Match>().Select(x => int.Parse(x.Value));
            BigInteger coolTreshold = 1;

            foreach (var digit in digits)
            {
                coolTreshold *= digit;
            }

            MatchCollection validEmojis = Regex.Matches(input, @"(::|\*\*)(?<emoji>[A-Z][a-z][a-z]+)\1");


            List<string> coolEmojis = new List<string>();

            foreach (Match emoji in validEmojis)
            {

                string currentEmoji = emoji.Groups["emoji"].Value;
                
                int coolness = currentEmoji.Sum(x => x);

                if (coolness >= coolTreshold)
                {
                    coolEmojis.Add(emoji.ToString());
                }
            }

            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{validEmojis.Count} emojis found in the text. The cool ones are:");

            Console.WriteLine(string.Join(Environment.NewLine, coolEmojis));








        }
    }
}
