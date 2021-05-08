using System;
using System.Linq;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split().ToArray().Reverse()));
        }
    }
}
