using System;

namespace SoftUniRecetion
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int totalEfficiency = firstEmployee + secondEmployee + thirdEmployee;

            int studentsCount = int.Parse(Console.ReadLine());
            int timeCount = 0;

            while (studentsCount > 0)
            {
                timeCount++;

                if (timeCount % 4 != 0)
                {
                    studentsCount -= totalEfficiency;
                    if (studentsCount < 0)
                    {
                        studentsCount = 0;
                    }

                }

            }

            Console.WriteLine($"Time needed: {timeCount}h.");

        }
    }
}
