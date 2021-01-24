using System;

namespace DecrytpingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int newLetter = (int)letter + key;
                message += (char)newLetter;
            }
            Console.WriteLine(message);
            
        }
    }
}
