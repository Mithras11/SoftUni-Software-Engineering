using System;
using System.Collections.Generic;
using System.Linq;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int index = 2;

            List<int> arr2 = new List<int>();

            for (int i = index+1; i < arr1.Length; i++)
            {
                arr2.Add(arr1[i]);
            }
            for (int i = 0; i <=index; i++)
            {
                arr2.Add(arr1[i]);
            }

            arr1 = arr2.ToArray();

            Console.WriteLine(string.Join(" ", arr1));

        }
    }
}
