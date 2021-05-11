using System;
using System.Linq;

namespace CombinationsWithRepetitions
{
    class Program
    {
        static char[] elements;
        static int elemSize;

        static char[] variation;
        static int varSize;


        static void Main(string[] args)
        {
            elements = ReadElements();
            elemSize = elements.Length;

            varSize = int.Parse(Console.ReadLine());
            variation = new char[varSize];

            Permute(0, 0);
        }

        private static void Permute(int index, int border)
        {
            if (index == varSize)
            {
                Print();
            }
            else
            {
                for (int i = border; i < elemSize; i++)
                {
                    variation[index] = elements[i];
                    Permute(index + 1, i);
                }
            }

        }

        private static void Print()
        {
            Console.WriteLine(string.Join(' ', variation));
        }

        private static void Print(char[] variation)
        {
            Console.WriteLine(string.Join(' ', variation));
        }

        private static char[] ReadElements()
        {
            return Console.ReadLine().Split().Select(char.Parse).ToArray();
        }
    }
}
