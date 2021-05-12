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
        static int element;

        static void Main(string[] args)
        {
            ReadArray();
            key = int.Parse(Console.ReadLine());

            var result = Search();

            Console.WriteLine(result);


        }

        private static int Search()
        {
            start = 0;
            end = arr.Length - 1;


            while (start <= end)
            {
                mid = (start + end) / 2;

                element = arr[mid];

                if (element == key)
                {
                    return mid;
                }
                else if (element < key)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return -1;

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
