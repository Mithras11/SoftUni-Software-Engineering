using System;
using System.Linq;

namespace InsertionSort
{
    class Program
    {
        static int[] arr;
        static int element;

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
                element = arr[k];

                for (int i = k - 1; i >= 0;)
                {
                    if (element < arr[i])
                    {
                        arr[i + 1] = arr[i];
                        i--;
                        arr[i + 1] = element;
                    }
                    else
                    {
                        break;
                    }
                }
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
