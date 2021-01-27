using System;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();

                box.Add(item);
            }

            string element = Console.ReadLine();

            box.Compare(element);
        }
    }
}
