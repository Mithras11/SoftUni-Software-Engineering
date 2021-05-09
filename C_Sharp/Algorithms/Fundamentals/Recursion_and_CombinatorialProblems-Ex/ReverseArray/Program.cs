using System;
using System.Linq;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int size = arr.Length;

            int[] result = new int[size];

            Reverse(arr, result, size - 1, 0);


        }

        static void Reverse(int[] arr, int[] result, int border, int index)
        {
            if (index == result.Length)
            {
                Print(result);
                return;
            }

            result[index] = arr[border];

            Reverse(arr, result, border - 1, index + 1);

        }

        static void Print(int[] result)
        {
            Console.WriteLine(string.Join(' ', result));

        }
    }
}
