using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfCoins
{
    class Program
    {
        static int[] coins;
        static int target;
        static List<string> result;
        static int totalCount;
        static void Main(string[] args)
        {
            coins = Read().OrderByDescending(c => c).ToArray();
            target = int.Parse(Console.ReadLine());

            result = new List<string>();
            totalCount = 0;

            Solve();
            Print();
        }

        private static void Print()
        {
            if (totalCount > 0 && target == 0)
            {
                Console.WriteLine($"Number of coins to take: {totalCount}");

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Error");
            }

        }

        private static int[] Read()
        {
            return Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        }

        private static void Solve()
        {

            int index = 0;

            int currCoin;
            int coinsCount;

            while (target > 0 && index < coins.Length)
            {
                currCoin = coins[index];

                coinsCount = target / currCoin;

                if (coinsCount > 0)
                {
                    totalCount += coinsCount;
                    target -= currCoin * coinsCount;

                    result.Add($"{coinsCount} coin(s) with value {currCoin}");
                }

                index++;
            }


        }

    }
}
