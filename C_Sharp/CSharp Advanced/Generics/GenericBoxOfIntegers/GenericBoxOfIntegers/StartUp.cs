using System;

namespace GenericBoxOfIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                Box<int> box = new Box<int>(num);
                Console.WriteLine(box.ToString());
            }
        }
    }
}


