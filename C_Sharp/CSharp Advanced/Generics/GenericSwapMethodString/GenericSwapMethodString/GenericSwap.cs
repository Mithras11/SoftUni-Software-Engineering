using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodString
{
    public class GenericSwap
    {

        public static void SwapList<T>(List<T> list, int[] command)
        {

            int firstIndex = command[0];
            int secondIndex = command[1];

            T temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;

            foreach (var box in list)
            {
                Console.WriteLine($"{box.GetType()}: {box}");
            }
        }
    }
}
