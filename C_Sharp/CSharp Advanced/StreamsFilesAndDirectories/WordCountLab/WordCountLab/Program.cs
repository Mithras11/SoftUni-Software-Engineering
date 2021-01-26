using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WordCountLab
{
    class Program
    {

        static void Main(string[] args)
        {
            var words = File.ReadAllText(@"../../../words.txt")
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> counts = CreateDict(words);

            var input = File.ReadAllText(@"../../../input.txt")
                .Split(new char[] { ' ', ',', '.', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var word in input)
            {
                if (counts.ContainsKey(word.ToLower()))
                {
                    counts[word.ToLower()]++;

                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (var count in counts.OrderByDescending(x => x.Value))
            {
                sb.AppendLine($"{count.Key} - {count.Value}");
            }

            File.WriteAllText(@"../../../output.txt", sb.ToString());

        }


        public static Dictionary<string, int> CreateDict(string[] words)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!counts.ContainsKey(word))
                {
                    counts.Add(word, 0);
                }
            }

            return counts;
        }
    }
}
