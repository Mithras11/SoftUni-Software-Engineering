using System;

namespace GenericBoxOfString
{
   public  class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var newString = Console.ReadLine();

                Box<string> box = new Box<string>(newString);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
