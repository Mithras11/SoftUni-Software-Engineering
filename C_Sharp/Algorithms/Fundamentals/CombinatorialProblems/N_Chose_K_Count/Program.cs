using System;

namespace N_Chose_K_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var result = Solve(n, k);
            Console.WriteLine(result);

        }

        private static int Solve(int n, int k)
        {
            if (k > n)
            {
                return 0;
            }
            else if (k == n || k == 0)
            {
                return 1;
            }

            return Solve(n - 1, k - 1) + Solve(n - 1, k);

        }
    }
}
