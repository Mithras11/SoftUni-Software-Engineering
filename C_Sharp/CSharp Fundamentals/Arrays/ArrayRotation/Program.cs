using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation; i++)
            {
                int firstElement = arr[0];

                int[] temp = new int[arr.Length];

                for (int j = 1; j < arr.Length; j++)
                {
                    temp[j - 1] = arr[j];
                }

                temp[temp.Length-1] = firstElement;

                arr = temp;
            }

            Console.WriteLine(string.Join(" ", arr));







        }
    }
}
