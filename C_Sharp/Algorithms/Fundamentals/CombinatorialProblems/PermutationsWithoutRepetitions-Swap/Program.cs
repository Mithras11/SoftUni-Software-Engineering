using System;
using System.Linq;

namespace PermutationsWithoutRepetitions_Swap
{
    class Program
    {
        static char[] elements;

        static void Main(string[] args)
        {
            elements = ReadElements();

            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index == elements.Length)
            {
                Print(elements);
                return;
            }

            Permute(index + 1);

            for (int i = index + 1; i < elements.Length; i++)
            {
                Swap(index, i);
                Permute(index + 1);
                Swap(index, i);
            }

        }

        private static void Swap(int index, int i)
        {
            var temp = elements[index];
            elements[index] = elements[i];
            elements[i] = temp;
        }

        private static void Print(char[] elements)
        {
            Console.WriteLine(string.Join(' ', elements));
        }

        private static char[] ReadElements()
        {
            return Console.ReadLine().Split().Select(char.Parse).ToArray();
        }
    }
}
