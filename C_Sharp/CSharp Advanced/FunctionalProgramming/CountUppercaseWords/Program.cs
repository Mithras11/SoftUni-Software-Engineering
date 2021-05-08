using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = s => char.IsUpper(s[0]);

            string[] text =
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToArray();

            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
