using System;

namespace TextFIlter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var item in bannedWords)
            {
                string replacement = new string('*', item.Length);

                text = text.Replace(item, replacement);
            }

            Console.WriteLine(text);
        }
    }
}
