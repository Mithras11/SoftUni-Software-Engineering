using System;
using System.Collections.Generic;
using System.Text;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints =  new List<int>() { 1, 2, 3, 4, 5 };

            StringBuilder sb = new StringBuilder();

            foreach (var item in ints)
            {
                sb.Append(item);
            }

            string integers = sb.ToString();
            Console.WriteLine(integers);
        }
    }
}