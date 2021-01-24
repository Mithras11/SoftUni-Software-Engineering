using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;
            string reverseWord = string.Empty;

            while ((word = Console.ReadLine()) != "end")
            {
                reverseWord = new string(word.Reverse().ToArray());

                Console.WriteLine($"{word} = {reverseWord}");
            }
        }
    }
}
