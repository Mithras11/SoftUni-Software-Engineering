using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();

            string[] text = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var item in text)
            {
                participants.Add(item, 0);
            }

            string input = Console.ReadLine();
            string pattern = @"[A-za-z\d]";
            Regex regex = new Regex(pattern);


            while (input != "end of race")
            {
                MatchCollection data = regex.Matches(input);
                StringBuilder sb = new StringBuilder();

                int sum = 0;

                foreach (var item in data)
                {
                    char currentChar = char.Parse(item.ToString());
                    if (Char.IsLetter(currentChar))
                    {
                        sb.Append(currentChar);
                    }
                    else if (Char.IsDigit(currentChar))
                    {
                        sum += int.Parse(currentChar.ToString());
                    }
                }
                string name = sb.ToString();

                if (participants.ContainsKey(name))
                {
                    participants[name] += sum;

                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> winners = participants.OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            List<string> topThree = new List<string>();

            int count = 0;

            foreach (var item in winners)
            {
                topThree.Add(item.Key);

                count++;

                if (count == 3)
                {
                    break;
                }
            }

            Console.WriteLine($"1st place: {topThree[0]}");
            Console.WriteLine($"2nd place: {topThree[1]}");
            Console.WriteLine($"3rd place: {topThree[2]}");
        }
    }
}
