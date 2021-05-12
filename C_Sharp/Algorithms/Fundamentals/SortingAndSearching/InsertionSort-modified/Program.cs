using System;
using System.Linq;

namespace InsertionSort
{
    class Program
    {
        static int[] arr;
        
        static void Main(string[] args)
        {
            ReadArray();

            Insert();

            Print();
        }

        private static void Insert()
        {
            for (int k = 1; k < arr.Length; k++)
            {
                int element = arr[k];
                int i;

                for (i = k - 1; i >= 0 && arr[i] > element; i--)
                {
                    arr[i + 1] = arr[i];

                }

                arr[i + 1] = element;
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
