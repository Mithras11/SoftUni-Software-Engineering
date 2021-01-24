using System;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Where(w => w.Length % 2 == 0)
                                .ToArray();

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
