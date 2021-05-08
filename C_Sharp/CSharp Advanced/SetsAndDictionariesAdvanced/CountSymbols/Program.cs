using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            string text = Console.ReadLine();

            foreach (char symbol in text)
            {
                if (!symbols.ContainsKey(symbol))
                {
                    symbols[symbol] = 1;
                }
                else
                {
                    symbols[symbol]++;
                }
            }

            foreach (var pair in symbols)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }
    }
}
