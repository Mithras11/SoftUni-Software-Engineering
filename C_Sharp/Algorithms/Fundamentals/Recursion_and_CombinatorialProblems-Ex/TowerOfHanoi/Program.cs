using System;

namespace TowerOfHanoi
{
    class Program
    {
        static int diskNum;
        static void Main(string[] args)
        {
            diskNum = int.Parse(Console.ReadLine());

            MoveDsks(diskNum, 'A', 'B', 'C');
        }

        private static void MoveDsks(int diskNum, char start, char end, char aux)
        {
            if (diskNum == 1)
            {
                PrintMove(diskNum, start, end);
            }
            else
            {
                MoveDsks(diskNum - 1, start, aux, end);
                PrintMove(diskNum, start, end);

                MoveDsks(diskNum - 1, aux, end, start);

            }


        }

        private static void PrintMove(int diskNum, char start, char end)
        {
            Console.WriteLine($"Move disks {diskNum} from {start} to {end}.");
        }
    }
}
