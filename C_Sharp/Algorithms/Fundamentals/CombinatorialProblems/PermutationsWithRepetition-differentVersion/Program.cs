using System;
using System.Linq;

namespace PermutationsWithRepetition
{
    class Program
    {
        static char[] arr;
        static void Main(string[] args)
        {
            arr = ReadElements();

            Permute(arr, 0, arr.Length - 1);
        }

        private static void Permute(char[] arr, int start, int end)
        {
            Print(arr);

            for (int left = end - 1; left >= start; left--)
            {
                for (int right = left + 1; right <= end; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        Swap(left, right);
                    }

                    Permute(arr, left + 1, end);
                }

                var first = arr[left];
                for (int i = left; i <= end-1; i++)
                {
                    arr[i] = arr[i + 1];
                    arr[end] = first;
                }

            }
        }

        private static void Swap(int index, int i)
        {
            var temp = arr[index];
            arr[index] = arr[i];
            arr[i] = temp;
        }

        private static void Print(char[] arr)
        {
            Console.WriteLine(string.Join(' ', arr));
        }

        private static char[] ReadElements()
        {
            var result = Console.ReadLine().Split().Select(char.Parse).ToArray();
            Array.Sort(result);

            return result;
        }
    }
}
