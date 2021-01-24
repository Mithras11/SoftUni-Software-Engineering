using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"!(?<command>[A-Z][a-z]{2,})!:\[(?<message>[A-Za-z]{8,})\]");

            string text = string.Empty;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                text = Console.ReadLine();

                Match match = regex.Match(text);

                if (match.Success)
                {
                    List<int> ascii = new List<int>();

                    string message = match.Groups["message"].Value;

                    for (int j = 0; j < message.Length; j++)
                    {
                        int code = (int)message[j];
                        ascii.Add(code);
                    }

                    string command = match.Groups["command"].Value;

                    Console.WriteLine($"{command}: {string.Join(' ',ascii)}");



                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
