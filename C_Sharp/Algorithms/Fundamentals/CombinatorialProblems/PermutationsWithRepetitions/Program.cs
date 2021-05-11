using System;
using System.Collections.Generic;
using System.Linq;

namespace PermutationsWithRepetitions_Swap
{
    class Program
    {
        static char[] elements;
        static HashSet<string> result;

        static void Main(string[] args)
        {
            elements = ReadElements();
            result = new HashSet<string>();

            Permute(0);

            Print(result);
        }

        private static void Permute(int index)
        {
            if (index == elements.Length)
            {
                result.Add(string.Join(' ', elements));

            }
            else
            {
                Permute(index + 1);

               var swapped = new HashSet<char>() { elements[index] };

                for (int i = index + 1; i < elements.Length; i++)
                {
                    if (!swapped.Contains(elements[i]))
                    {
                        Swap(index, i);
                        Permute(index + 1);
                        Swap(index, i);

                        swapped.Add(elements[i]);
                    }
                }
            }

        }

        private static void Swap(int index, int i)
        {
            var temp = elements[index];
            elements[index] = elements[i];
            elements[i] = temp;
        }

        private static void Print(HashSet<string> elements)
        {
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }

        private static char[] ReadElements()
        {
            return Console.ReadLine().Split().Select(char.Parse).ToArray();
        }
    }
}
