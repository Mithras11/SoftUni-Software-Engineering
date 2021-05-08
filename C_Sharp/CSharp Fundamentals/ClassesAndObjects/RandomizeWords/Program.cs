using System;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = rnd.Next(0, words.Length);

                string currentWord = words[i];

                words[i] = words[randomIndex];
                words[randomIndex] = currentWord;


            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
