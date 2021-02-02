using System;
using System.Linq;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myStack = new CustomStack<int>();

            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (tokens[0] == "END")
                {
                    break;
                }



                if (tokens[0] == "Push")
                {
                    var elements = tokens.Skip(1).Select(int.Parse).ToArray();

                    for (int i = 0; i < elements.Length; i++)
                    {
                        myStack.Push(elements[i]);
                    }

                }
                else if (tokens[0] == "Pop")
                {
                    myStack.Pop();
                }
            }

            PrintAll(myStack);

            

        }

        private static void PrintAll(CustomStack<int> myStack)
        {
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }






    }
}
