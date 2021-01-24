using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split()
                .ToArray();

            Predicate<string> determineLength = n => n.Length <= nameLength;

            Action<string[], Predicate<string>> print = ((arr, detirmenLength) =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (determineLength(arr[i]))
                    {
                        Console.WriteLine(arr[i]);
                    }
                }

            });

            print(names, determineLength);
        }
    }
}
