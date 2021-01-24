using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> occurences = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (occurences.ContainsKey(word.ToLower()))
                {
                    occurences[word.ToLower()]++;
                }
                else
                {
                    occurences.Add(word.ToLower(), 1);
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (var word in occurences)
            {
                if (word.Value % 2 != 0)
                {
                    sb.Append(word.Key + ' ');
                }
            }
            string result = sb.ToString();

            Console.WriteLine(result);

        }
    }
}
