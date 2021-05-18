using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortestPath
{
    class Program
    {
        static List<int>[] graph;
        static bool[] visited;
        static int[] parents;
        static Stack<int> path;
        static int source;
        static int destination;
        static void Main(string[] args)
        {
            ReadGraph();

            source = int.Parse(Console.ReadLine());
            destination = int.Parse(Console.ReadLine());

            visited = new bool[graph.Length];
            parents = new int[graph.Length];
            path = new Stack<int>();

            Array.Fill(parents, -1);

            Bfs(source, destination);
            PrintResult();

        }

        private static void PrintResult()
        {
            Console.WriteLine($"Shortest path length is: {path.Count - 1}");
            Console.WriteLine(string.Join(" ", path));
        }

        static void Bfs(int source, int destination)
        {
            if (visited[source])
            {
                return;
            }


            var queue = new Queue<int>();

            queue.Enqueue(source);
            visited[source] = true;

            while (queue.Count != 0)
            {
                var currNode = queue.Dequeue();

                if (currNode == destination)
                {
                    GetPath();
                }

                foreach (var child in graph[currNode])
                {
                    if (!visited[child])
                    {
                        parents[child] = currNode;
                        queue.Enqueue(child);
                        visited[child] = true;
                    }
                }


            }
        }

        private static void GetPath()
        {
            int index = destination;

            while (index != -1)
            {
                path.Push(index);
                index = parents[index];

            }

        }

        private static void ReadGraph()
        {
            var nodeNum = int.Parse(Console.ReadLine());
            graph = new List<int>[nodeNum + 1];

            for (int i = 1; i < graph.Length; i++)
            {
                graph[i] = new List<int>();
            }

            var edgeNum = int.Parse(Console.ReadLine());

            List<int> currLine;

            for (int i = 1; i <= edgeNum; i++)
            {
                currLine = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();


                graph[currLine[0]].Add(currLine[1]);
            }


        }
    }
}
