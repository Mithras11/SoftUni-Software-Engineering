using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            for (int i = 0; i < array.Length; i++)
            {

                bool isTopInt = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isTopInt = false;
                        break;
                    }
                }

                if (isTopInt)
                {
                    Console.Write(array[i] + " ");
                }
            }


        }
    }
}
