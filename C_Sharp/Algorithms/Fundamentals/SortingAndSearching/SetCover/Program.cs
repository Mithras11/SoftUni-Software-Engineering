using System;
using System.Collections.Generic;
using System.Linq;

namespace SetCover
{
    class Program
    {
        static List<int> sequence;
        static int numOfSets;
        static List<int[]> allSets;
        static int[] currLine;
        static List<int[]> result;
        static int[] currSet;




        static void Main(string[] args)
        {
            sequence = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();

            numOfSets = int.Parse(Console.ReadLine());

            allSets = new List<int[]>();

            for (int i = 0; i < numOfSets; i++)
            {
                currLine = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();


                allSets.Add(currLine);
            }


            result = new List<int[]>();

            while (sequence.Count > 0)
            {
                currSet = allSets
                    .OrderByDescending(s => s
                    .Count(
                        e => sequence.Contains(e)))
                    .FirstOrDefault();

                result.Add(currSet);

                allSets.Remove(currSet);

                sequence.RemoveAll(
                    x => currSet.Contains(x));

            }

            Console.WriteLine($"Sets to take ({result.Count}):");

            foreach (var item in result)
            {
                Console.WriteLine(string.Join(", ", item));
            }







        }
    }
}
