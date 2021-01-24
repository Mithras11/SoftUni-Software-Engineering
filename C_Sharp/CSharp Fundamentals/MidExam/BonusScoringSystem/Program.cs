using System;
using System.Linq;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());

            int[] StudentAttendances = new int[countOfStudents];

            for (int i = 0; i < countOfStudents; i++)
            {
                int currentAttendances = int.Parse(Console.ReadLine());
                StudentAttendances[i] = currentAttendances;
            }

            double[] totalBonuses = new double[countOfStudents];

            for (int i = 0; i < countOfStudents; i++)
            {
                
                double currentTotalBonus = StudentAttendances[i] * 1.0 / countOfLectures * (5 + initialBonus);
                totalBonuses[i] = currentTotalBonus;
                

            }

            double maxBonus = totalBonuses.Max();

            int indexOfStudent = Array.FindIndex(totalBonuses, bonus => bonus == maxBonus);

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {StudentAttendances[indexOfStudent]} lectures.");



        }
    }
}
