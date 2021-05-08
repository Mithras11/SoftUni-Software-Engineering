using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int x = int.Parse(Console.ReadLine());


            Func<List<int>, List<int>> precessor = ((arr1) =>
             {
                 List<int> arr2 = new List<int>();

                 for (int i = arr1.Count - 1; i >= 0; i--)
                 {
                     if (arr1[i] % x != 0)
                     {
                         arr2.Add(arr1[i]);

                     }

                 }

                 return arr2;
             });

            

            numbers = precessor(numbers);

            Console.WriteLine(string.Join(' ', numbers));




            



        }


    }
}
