using System;
using System.Collections.Generic;

namespace DFS
{
    class Program
    {

        static List<int>[] graph;
        static bool[] visited;

        static void Dfs(int n)
        {
            if (!visited[n])
            {
                visited[n] = true;

                foreach (var child in graph[n])
                {
                    Dfs(child);
                }

                Console.Write($"{n} ");

            }
        }

        static void Main(string[] args)
        {
            graph = new List<int>[]
            {
                new List<int>{3,6},
                new List<int>{2,3,4,5,6},
                new List<int>{1,4,5},
                new List<int>{0,1,5},
                new List<int>{1,2,6},
                new List<int>{1,2,3},
                new List<int>{0,1,4}
            };

            visited = new bool[graph.Length];

            for (int i = 0; i < graph.Length; i++)
            {
                Dfs(i);
            }
        }
    }
}
