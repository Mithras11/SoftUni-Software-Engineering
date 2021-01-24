using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[] triangle = new int[rows];
            triangle[0] = 1;

            int[] newTriangle = new int[rows];
            newTriangle[0] = 1;



            for (int i = 1; i <= rows; i++)
            {


                for (int j = 1; j <= i - 1; j++)
                {
                    int a = triangle[j - 1];
                    int b = triangle[j];
                    newTriangle[j] = a + b;
                }

                foreach (var item in newTriangle)
                {
                    if (item != 0)
                    {
                        Console.Write(item + " ");
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine();



                for (int k = 0; k < triangle.Length; k++)
                {
                    triangle[k] = newTriangle[k];
                }

            }



        }
    }
}
