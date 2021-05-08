using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>();

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);

            list.RemoveAt(1);
            list.RemoveAt(2);

            list.InsertAt(0, 50);

            Console.WriteLine(list.Contains(30));


            list.Add(60);
            list.Add(70);

            list.Swap(3, 4);

            Console.WriteLine();



        }
    }
}
