using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "End")
            {
                string value = "" + input.GetType();
                switch (value)
                {
                    case "System.Int32":
                        Console.WriteLine($"{input} is integer type");
                        break;

                    case "System.Double":
                        Console.WriteLine($"{input} is floating point type");
                        break;

                    case "System.Char":
                        Console.WriteLine($"{input} is character type");
                        break;

                    case "System.Boolean":
                        Console.WriteLine($"{input} is boolean type");
                        break;

                    case "System.String":
                        Console.WriteLine($"{input} is string type");
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
