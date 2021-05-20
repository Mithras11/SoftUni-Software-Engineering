using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadReconstruction
{
    class Edge
    {
        public Edge(int start, int end)
        {
            this.Start = start;

            this.End = end;
        }

        public int Start { get; set; }
        public int End { get; set; }
    }

    class Program
    {
        static Dictionary<int, List<int>> graph;
        static List<Edge> edges;
        static List<Edge> importantEdges;
        static HashSet<int> visited;
        static Queue<int> queue;

        static void Main(string[] args)
        {
            ReadGraph();
            CheckForCycles();
            PrintResult();
        }

        private static void PrintResult()
        {
            Console.WriteLine("Important streets:");

            foreach (var edge in importantEdges)
            {
                if (edge.Start <= edge.End)
                {
                    Console.WriteLine($"{edge.Start} {edge.End}");
                }
                else
                {
                    Console.WriteLine($"{edge.End} {edge.Start}");
                }

            }
        }

        private static void CheckForCycles()
        {
            importantEdges = new List<Edge>();

            foreach (var edge in edges)
            {
                var source = edge.Start;
                var destination = edge.End;

                graph[source].Remove(destination);
                graph[destination].Remove(source);

                if (!Bfs(source, destination))
                {
                    importantEdges.Add(edge);
                }

                graph[source].Add(destination);
                graph[destination].Add(source);
            }




        }

        private static bool Bfs(int source, int destination)
        {
            queue = new Queue<int>();
            visited = new HashSet<int>();

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
                    if (!visited.Contains(child))//?
                    {
                        visited.Add(child);
                        queue.Enqueue(child);

                    }

                }

            }

            return false;

        }



        private static void ReadGraph()
        {
            graph = new Dictionary<int, List<int>>();
            edges = new List<Edge>();


            int numOfNodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfNodes; i++)
            {
                graph[i] = new List<int>();

            }


            int numOfEdges = int.Parse(Console.ReadLine());
            int[] tokens;

            for (int i = 0; i < numOfEdges; i++)
            {
                tokens = Console.ReadLine().Split(" -").Select(int.Parse).ToArray();
                var node = tokens[0];
                var child = tokens[1];

                graph[node].Add(child);
                graph[child].Add(node);


                edges.Add(new Edge(node, child));

            }


        }
    }
}
