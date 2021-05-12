using System;
using System.Linq;

namespace SelectionSort
{
    class Program
    {
        static int[] arr;
        static int minIndex;

        static void Main(string[] args)
        {
            ReadArray();

            for (int i = 0; i < arr.Length; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Compare(arr[j], arr[minIndex]))
                    {
                        minIndex = j;
                    }

                }

                Swap(i, minIndex);
            }


            Print();
        }

        private static void Print()
        {
            Console.WriteLine(string.Join(' ', arr));
        }

        private static void ReadArray()
        {
            arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        private static void Swap(int currIndex, int minIndex)
        {
            var temp = arr[currIndex];
            arr[currIndex] = arr[minIndex];
            arr[minIndex] = temp;
        }

        private static bool Compare(int n2, int n1)
        {
            return n2 < n1;
        }
    }
}
