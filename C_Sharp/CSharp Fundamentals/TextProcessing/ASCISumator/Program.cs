using System;

namespace ASCISumator
{
    class Program
    {
        static void Main(string[] args)
        {
            int charBefore = char.Parse(Console.ReadLine());
            int charAfter = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i] > charBefore && (int)text[i] < charAfter)
                {
                    sum += (int)text[i];
                }
            }




            Console.WriteLine(sum);





        }
    }
}
