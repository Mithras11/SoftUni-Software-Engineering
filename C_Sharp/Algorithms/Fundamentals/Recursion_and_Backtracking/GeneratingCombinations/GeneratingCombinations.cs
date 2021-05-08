using System;
using System.Linq;

namespace GeneratingCombinations
{
    class GeneratingCombinations
    {
        static void Main(string[] args)
        {
            int[] set = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            var vector = new int[k];

            Generate(set, vector, 0, 0);

        }

        static void Generate(int[] set, int[] vector, int index, int border)
        {
            if (index == vector.Length)
            {
                Console.WriteLine((string.Join(' ', vector)));
                
            }
            else
            {
                for (int i = border; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    Generate(set, vector, index + 1, i + 1);
                }
            }



        }
    }
}
