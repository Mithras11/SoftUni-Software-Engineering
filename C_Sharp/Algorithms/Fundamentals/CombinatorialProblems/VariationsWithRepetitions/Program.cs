using System;
using System.Linq;

namespace VariationsWithRepetitions
{
    class Program
    {
        static char[] elements;
        static char[] variation;
        static int varSize;

        static void Main(string[] args)
        {
            elements = ReadElements();
            varSize = int.Parse(Console.ReadLine());
                      
            variation = new char[varSize];

            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index == varSize)
            {
                Print(variation);
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {               

                variation[index] = elements[i];
                
                Permute(index + 1);
                
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
