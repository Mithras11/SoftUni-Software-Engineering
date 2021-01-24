using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Arrays = Console.ReadLine()
              .Split("|")
              .ToList();

            List<int> newList = new List<int>();

            for (int i = Arrays.Count - 1; i >= 0; i--)
            {
                int[] currentArray = Arrays[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                newList.AddRange(currentArray);

            }

            Console.WriteLine(string.Join(' ', newList));



        }
    }
}

