using System;

namespace RecursiveDrawing
{
    class RecursiveDrawing
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());
            Draw(index);
        }

        static void Draw(int index)
        {
            if (index == 0)
            {
                return;
            }


            Console.WriteLine(new string('*', index));

            Draw(index - 1);


            Console.WriteLine(new string('#', index));
        }
    }
}
