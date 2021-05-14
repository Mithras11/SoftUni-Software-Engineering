using System;
using System.Linq;

namespace QuickSort
{
    class Program
    {
        static int[] arr;
        static int pivot;
        static void Main(string[] args)
        {
            ReadArray();
            QuickSort(arr, 0, arr.Length - 1);
            Print();
        }


        private static void QuickSort(int[] arr, int first, int last)
        {
            if (first < last)
            {
                pivot = Partition(arr, first, last);
                QuickSort(arr, first, pivot - 1);
                QuickSort(arr, pivot + 1, last);

            }
        }

        private static int Partition(int[] arr, int first, int last)
        {
            pivot = arr[last];

            int smallest = first - 1;

            for (int i = first; i < last; i++)
            {
                if (arr[i] < pivot)
                {
                    smallest++;

                    int temp1 = arr[smallest];
                    arr[smallest] = arr[i];
                    arr[i] = temp1;
                }
            }

            smallest++;

            int temp2 = arr[smallest];
            arr[smallest] = arr[last];
            arr[last] = temp2;

            return smallest;
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
