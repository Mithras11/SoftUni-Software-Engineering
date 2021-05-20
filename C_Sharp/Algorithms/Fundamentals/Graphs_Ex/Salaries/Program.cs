using System;
using System.Collections.Generic;

namespace Salaries
{
    class Program
    {
        static List<int>[] graph;
        static int totalSalary;

        static void Main(string[] args)
        {
            ReadGraph();

            totalSalary = 0;

            for (int i = 0; i < graph.Length; i++)
            {
                totalSalary += Dfs(i);
            }

            Console.WriteLine(totalSalary);
        }

        private static int Dfs(int node)
        {
            int salary = 0;

            if (graph[node].Count == 0)
            {
                return 1;
            }

            foreach (var child in graph[node])
            {
                salary += Dfs(child);
            }

            return salary;
        }

        private static void ReadGraph()
        {
            int size = int.Parse(Console.ReadLine());
            graph = new List<int>[size];

            char[] line;

            for (int i = 0; i < size; i++)
            {
                graph[i] = new List<int>();

                line = Console.ReadLine().ToCharArray();

                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == 'Y')
                    {
                        graph[i].Add(j);
                    }
                }
            }
        }
    }
}
