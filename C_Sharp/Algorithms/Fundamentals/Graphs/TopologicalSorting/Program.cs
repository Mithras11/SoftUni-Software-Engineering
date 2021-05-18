using System;
using System.Collections.Generic;
using System.Linq;

namespace TopologicalSorting
{
    class Program
    {
        static Dictionary<string, List<string>> graph;
        static Dictionary<string, int> predecessors;
        static List<string> sorted;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            graph = new Dictionary<string, List<string>>();
            predecessors = new Dictionary<string, int>();
            sorted = new List<string>();

            ReadGraph(n);
            GetPredecessors();
            TopologicalSorting();
                        
        }

        private static void TopologicalSorting()
        {

            while (predecessors.Count != 0)
            {
                var node = predecessors.FirstOrDefault(x => x.Value == 0);

                if (node.Key == null)
                {
                    break;
                }

                var children = graph[node.Key];

                foreach (var child in children)
                {
                    predecessors[child]--;
                }

                sorted.Add(node.Key);
                predecessors.Remove(node.Key);

            }

            if (predecessors.Count != 0)
            {
                Console.WriteLine("Invalid topological sorting");
            }
            else
            {
                Console.WriteLine($"Topological sorting: {string.Join(", ", sorted)}");

            }


        }

        private static void GetPredecessors()
        {
            string key;
            List<string> children;

            foreach (var node in graph)
            {
                key = node.Key;
                children = node.Value;

                if (!predecessors.ContainsKey(key))
                {
                    predecessors.Add(key, 0);
                }

                foreach (var child in children)
                {
                    if (!predecessors.ContainsKey(child))
                    {
                        predecessors.Add(child, 0);
                    }

                    predecessors[child]++;
                }

            }
        }

        private static void ReadGraph(int n)
        {

            string[] input;
            string node;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine()
                   .Split(" ->");

                node = input[0];

                graph.Add(node, new List<string>());

                if (input.Length > 1)
                {
                    graph[node] = input[1]
                        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                }
            }

        }
    }
}
