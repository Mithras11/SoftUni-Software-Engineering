using System;
using System.Text;

namespace GeneratingVectors
{
    class GeneratingVectors
    {
        static void Main(string[] args)
        {
            var index = int.Parse(Console.ReadLine());
            var vector = new int[index];

            Generate(vector, 0);
        }

        static void Generate(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                Print(vector);
                return;
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    Generate(vector, index + 1);
                }
            }
        }

        static void Print(int[] vector)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < vector.Length; i++)
            {
                sb.Append(vector[i]);
            }

            
            Console.WriteLine(sb.ToString());
        }
    }
}
