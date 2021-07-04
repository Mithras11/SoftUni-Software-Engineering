using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ImplementedList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i * 5);
            }

            Console.WriteLine(list.InternalArrayCount);
            Console.WriteLine(list.Count);
            Console.WriteLine(list[5]);

        }
    }
}
