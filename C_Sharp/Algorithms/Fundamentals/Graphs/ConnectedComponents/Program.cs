using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedComponents
{
    class Program
    {
        static List<int>[] graph;
        static bool[] visited;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            graph = new List<int>[n];
            visited = new bool[n];

            ReadGraph(n);
            FindConnectedCOmponents();

        }

        private static void FindConnectedCOmponents()
        {
            for (int i = 0; i < graph.Length; i++)
            {
                if (!visited[i])
                {
                    Console.Write("Connected component:");
                    Dfs(i);
                    Console.WriteLine();

                }

            }
        }

        private static void Dfs(int node)
        {
            if (!visited[node])
            {
                visited[node] = true;

                foreach (var child in graph[node])
                {
                    Dfs(child);
                }

                Console.Write($" {node}");
            }
        }

        private static void ReadGraph(int n)
        {

            List<int> currNode;

            for (int i = 0; i < n; i++)
            {
                currNode = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                graph[i] = currNode;

            }
        }
    }
}
