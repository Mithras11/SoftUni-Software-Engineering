using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new RandomList() { "abc", "efg" };

            var str = list.RandomString();

            Console.WriteLine(str);
        }
    }
}
