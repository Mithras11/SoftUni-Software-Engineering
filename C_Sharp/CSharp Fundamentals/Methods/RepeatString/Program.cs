using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());

            string result = RepeatString(input, counter);

            Console.WriteLine(result);

        }

        static string RepeatString(string input, int counter)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < counter; i++)
            {
                result.Append(input);
            }


            return result.ToString();
        }
    }
}
