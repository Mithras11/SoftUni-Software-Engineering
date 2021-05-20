using System;
using System.Collections.Generic;
using System.Linq;

namespace BreakCycles
{
    class Edge
    {
        public Edge(string start, string end)
        {
            this.Start = start;

            this.End = end;
        }

        public string Start { get; set; }
        public string End { get; set; }
    }

    class Program
    {
        static Dictionary<string, List<string>> graph;
        static List<Edge> edges;
        static List<Edge> removedEdges;
        static HashSet<string> visited;
        static Queue<string> queue;

        static void Main(string[] args)
        {
            ReadGraph();
            GetEdges();
            CheckForCycles();
            PrintResult();



        }

        private static void PrintResult()
        {
            Console.WriteLine($"Edges to remove: {removedEdges.Count}");

            foreach (var edge in removedEdges)
            {
                Console.WriteLine($"{edge.Start} - {edge.End}");
            }
        }

        private static void CheckForCycles()
        {
            removedEdges = new List<Edge>();


            foreach (var edge in edges)
            {
                var source = edge.Start;
                var destination = edge.End;

                graph[source].Remove(destination);
                graph[destination].Remove(source);

                if (Bfs(source, destination))
                {
                    removedEdges.Add(edge);
                }
            }


        }

        private static bool Bfs(string source, string destination)
        {
            queue = new Queue<string>();
            visited = new HashSet<string>();

            queue.Enqueue(source);

            while (queue.Count > 0)
            {
                var currNode = queue.Dequeue();
                visited.Add(currNode);

                if (currNode == destination)
                {
                    return true;
                }

                var children = graph[currNode];

                foreach (var child in children)
                {
                    if (!visited.Contains(child))
                    {
                        visited.Add(child);
                        queue.Enqueue(child);

                    }

                }

            }

            return false;

        }


        private static void GetEdges()
        {
            edges = new List<Edge>();

            foreach (var node in graph)
            {
                foreach (var child in node.Value)
                {
                    edges.Add(new Edge(node.Key, child));
                }
            }

            edges = edges.OrderBy(x => x.Start).ThenBy(x => x.End).ToList();
        }

        private static void ReadGraph()
        {
            graph = new Dictionary<string, List<string>>();
            string[] tokens;

            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                tokens = Console.ReadLine().Split(" -> ").ToArray();
                var node = tokens[0];
                var children = tokens[1].Split().ToList();


                graph.Add(node, children);

            }


        }
    }
}
