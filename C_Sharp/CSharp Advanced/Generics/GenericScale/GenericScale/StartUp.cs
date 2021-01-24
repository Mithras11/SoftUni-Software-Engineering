using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            EqualityScale<int> scale = new EqualityScale<int>(a, b);

            var result = scale.AreEqual();
            Console.WriteLine(result);
        }
    }
}
