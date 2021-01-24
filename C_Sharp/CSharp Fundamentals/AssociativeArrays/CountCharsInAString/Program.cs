using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> occurences = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]!=' ')
                {
                    if (occurences.ContainsKey(input[i]))
                    {
                        occurences[input[i]]++;
                    }
                    else
                    {
                        occurences.Add(input[i], 1);
                    }
                }
            }

            foreach (var item in occurences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
