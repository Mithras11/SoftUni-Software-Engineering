using System;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToArray();

            var listyIterator = new ListyIterator<string>(command);

            while (true)
            {
                string token = Console.ReadLine();

                if (token == "END")
                {
                    break;
                }

                try
                {
                    if (token == "Move")
                    {
                        Console.WriteLine(listyIterator.Move());
                    }
                    else if (token == "HasNext")
                    {
                        Console.WriteLine(listyIterator.HasNext());
                    }
                    else if (token == "Print")
                    {
                        listyIterator.Print();
                    }
                    else if (token == "PrintAll")
                    {
                        listyIterator.PrintAll();
                    }

                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }







            }



        }
    }
}
