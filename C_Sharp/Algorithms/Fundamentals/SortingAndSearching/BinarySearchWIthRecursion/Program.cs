using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static int[] arr;
        static int key;

        static int start;
        static int end;
        static int mid;

        static void Main(string[] args)
        {
            ReadArray();
            key = int.Parse(Console.ReadLine());

            var result = Search(arr, key);

            Console.WriteLine(result);


        }

        public static int Search(int[] arr, int key)
        {
            start = 0;
            end = arr.Length - 1;

            return Search(arr, key, start, end);

        }

        private static int Search(int[] arr, int key, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }

            mid = (start + end) / 2;

            if (key == arr[mid])
            {
                return mid;
            }
            else if (key < arr[mid])
            {
                return Search(arr, key, start, mid - 1);
            }
            else
            {
                return Search(arr, key, mid + 1, end);
            }
        }

        private static void Print()
        {
            Console.WriteLine(string.Join(' ', arr));
        }

        private static void ReadArray()
        {
            arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
    }
}
