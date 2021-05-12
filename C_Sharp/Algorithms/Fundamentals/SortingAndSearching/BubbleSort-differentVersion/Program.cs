using System;
using System.Linq;

namespace BubbleSort
{
    class Program
    {
        static int[] arr;

        static void Main(string[] args)
        {
            ReadArray();

            var border = 1;
            var isSorted = false;

            while (!isSorted)
            {

                for (int j = 0; j < arr.Length - border; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }

                border++;

                if (border == arr.Length)
                {
                    isSorted = true;
                }

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


    }
}
