using System;
using System.Linq;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    sb.Append(item);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
