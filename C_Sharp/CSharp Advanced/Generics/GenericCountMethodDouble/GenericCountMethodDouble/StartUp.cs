using System;

namespace GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double item = double.Parse(Console.ReadLine());

                box.Add(item);
            }

            double element = double.Parse(Console.ReadLine());

            box.Compare(element);
        }
    }
}
