using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WordCount
{
    public class Program
    {
        static void Main()
        {
            var words = File.ReadAllLines("../../../words.txt");

            var dict = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                dict.Add(words[i].ToLower(), 0);
            }



            var text = File
                .ReadAllText("../../../text.txt")
                .ToLower()
                .Split(new char[] { '.', ' ', '!', '?', '-', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (dict.ContainsKey(text[i]))
                {
                    dict[text[i]]++;
                }
            }



            StringBuilder unsortedSb = new StringBuilder();

            foreach (var item in dict)
            {
                unsortedSb.AppendLine($"{item.Key} - {item.Value}");
            }

            File.WriteAllText("../../../actualResult.txt", unsortedSb.ToString());



            StringBuilder sortedSb = new StringBuilder();

            foreach (var item in dict.OrderByDescending(x => x.Value))
            {
                sortedSb.AppendLine($"{item.Key} - {item.Value}");
            }


            File.WriteAllText("../../../expectedResult.txt", sortedSb.ToString());

        }
    }
}