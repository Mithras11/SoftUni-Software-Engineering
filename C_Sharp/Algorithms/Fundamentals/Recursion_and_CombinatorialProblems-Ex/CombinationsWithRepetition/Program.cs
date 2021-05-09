using System;

namespace CombinationsWithRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var arr = new int[k];

            GetCombinations(arr, n, 0, 1);
        }

        private static void GetCombinations(int[] arr, int n, int index, int border)
        {
            if (index == arr.Length)
            {
                Print(arr);
                return;
            }

            for (int i = border; i <= n; i++)
            {
                arr[index] = i;

                GetCombinations(arr, n, index + 1, border);

                border++;
            }
        }

        private static void Print(int[] arr)
        {
            Console.WriteLine(string.Join(' ', arr));
        }
    }
}
