using System;
using System.Collections.Generic;
using System.Linq;

namespace PermutationsWithoutRepetitions
{
    class Program
    {
        static char[] elements;
        static bool[] used;
        static char[] permutaion;

        static void Main(string[] args)
        {
            elements = ReadElements();
            used = new bool[elements.Length];
            permutaion = new char[elements.Length];

            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index == elements.Length)
            {
                Print(permutaion);
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (used[i])
                {
                    continue;
                }

                permutaion[index] = elements[i];
                used[i] = true;

                Permute(index + 1);
                used[i] = false;
            }

        }

        private static void Print(char[] permutaion)
        {
            Console.WriteLine(string.Join(' ', permutaion));
        }

        private static char[] ReadElements()
        {
            return Console.ReadLine().Split().Select(char.Parse).ToArray();
        }


    }
}
