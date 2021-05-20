using System;
using System.Collections.Generic;
using System.Linq;

namespace CyclesInGraph
{
    class Program
    {
        static Dictionary<char, List<char>> graph;
        static HashSet<char> visited;
        static HashSet<char> cycles;
        static bool isCyclic;

        static void Main(string[] args)
        {
            graph = new Dictionary<char, List<char>>();
            visited = new HashSet<char>();
            cycles = new HashSet<char>();
            isCyclic = false;

            string input = Console.ReadLine();
            char[] tokens;

            while (input != "End")
            {
                tokens = input.Split('-')
                    .Select(char.Parse)
                    .ToArray();

                var node = tokens[0];
                var child = tokens[1];

                if (!graph.ContainsKey(node))
                {
                    graph.Add(node, new List<char>());
                }

                graph[node].Add(child);

                if (!graph.ContainsKey(child))
                {
                    graph.Add(child, new List<char>());
                }

                input = Console.ReadLine();
            }


            foreach (var node in graph.Keys)
            {
                Dfs(node);
            }

            if (isCyclic)
            {
                Console.WriteLine("Acyclic: No");
            }
            else
            {
                Console.WriteLine("Acyclic: Yes");
            }


        }


        static void Dfs(char n)
        {
            if (cycles.Contains(n))
            {
                isCyclic = true;
                return;
            }


            if (!visited.Contains(n))
            {
                visited.Add(n);
                cycles.Add(n);

                var children = graph[n];

                foreach (var child in children)
                {
                    Dfs(child);
                }

                cycles.Remove(n);
            }
        }
    }
}
