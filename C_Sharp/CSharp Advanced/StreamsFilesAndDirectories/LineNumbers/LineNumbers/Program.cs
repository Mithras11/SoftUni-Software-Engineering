using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");

            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                int countOfLetters = CountOfLetters(line);
                int countOfMarks = CountOfMarks(line);

                result[i] = $"Line {i + 1}: {lines[i]}({countOfLetters})({countOfMarks})";

            }

            File.WriteAllLines("../../../output.txt", result);
        }

        static int CountOfLetters(string line)
        {
            int counter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];

                if (Char.IsLetter(currentSymbol))
                {
                    counter++;
                }
            }

            return counter;
        }

        static int CountOfMarks(string line)
        {
            char[] marks = { '-', ',', '.', '!', '?', '\'' };

            int counter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];

                if (marks.Contains(currentSymbol))
                {
                    counter++;
                }
            }

            return counter;
        }

    }
}
