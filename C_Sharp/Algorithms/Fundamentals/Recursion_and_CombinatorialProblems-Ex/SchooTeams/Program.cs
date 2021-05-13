using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchooTeams
{
    class Program
    {
        static string[] girls;
        static string[] boys;

        static int girlsSize;
        static int boysSize;

        static string[] girlsVariation;
        static string[] boysVariation;

        static List<string> girlsResult;
        static List<string> boysResult;



        static void Main(string[] args)
        {
            girls = ReadStudents();
            boys = ReadStudents();

            girlsSize = 3;
            boysSize = 2;

            girlsVariation = new string[girlsSize];
            boysVariation = new string[boysSize];

            girlsResult = new List<string>();
            boysResult = new List<string>();


            GenerateVariations(girlsResult, girls, girlsVariation, girlsSize, 0, 0);
            GenerateVariations(boysResult, boys, boysVariation, boysSize, 0, 0);

            PrintResult();


        }

        private static void GenerateVariations(List<string> result, string[] students, string[] variation, int varSize, int index, int start)
        {
            if (index == varSize)
            {
                result.Add(string.Join(", ", variation));
            }
            else
            {
                for (int i = start; i < students.Length; i++)
                {
                    variation[index] = students[i];
                    GenerateVariations(result, students, variation, varSize, index + 1, i + 1);
                }
            }

        }

        private static string[] ReadStudents()
        {
            return Console.ReadLine().Split(", ").ToArray();
        }

        private static void PrintResult()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < girlsResult.Count; i++)
            {
                for (int j = 0; j < boysResult.Count; j++)
                {
                    sb.AppendJoin(", ", girlsResult[i], boysResult[j]);
                    sb.AppendLine();
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
