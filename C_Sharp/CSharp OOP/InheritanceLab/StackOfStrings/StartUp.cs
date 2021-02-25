using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new StackOfStrings();

            stack.AddRange(new string[] { "ab", "cd" });

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
