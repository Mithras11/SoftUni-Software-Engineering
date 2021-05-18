using System;
using System.Collections.Generic;
using System.Linq;

namespace DistanceBetweenVertices
{
    class Program
    {
        static Dictionary<int, List<int>> graph;
        static List<string> pairs;
        static Dictionary<int, int> parents;

        static int nodesNum;
        static int pairsNum;


        static void Main(string[] args)
        {
            nodesNum = int.Parse(Console.ReadLine());
            pairsNum = int.Parse(Console.ReadLine());

            ReadGraph();
            ReadPairs();

            for (int i = 0; i < pairs.Count; i++)
            {
                var tokens = pairs[i].Split('-').Select(int.Parse).ToArray();

                var source = tokens[0];
                var destination = tokens[1];

                var steps = GetPath(source, destination);

                Console.WriteLine($"{{{source}, {destination}}} -> {steps}");
            }


        }

        private static int GetPath(int source, int destination)
        {
            parents = new Dictionary<int, int>();

            parents.Add(source, 0);

            var queue = new Queue<int>();
            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                if (parents.Any(x => x.Key == destination))
                {
                    //var end = parents.FirstOrDefault(x => x.Key == destination).Key;

                    //return CountSteps(end);
                    
                    return CountSteps(destination);
                }

                foreach (var child in graph[node])
                {

                    if (!parents.ContainsKey(child))
                    {
                        queue.Enqueue(child);
                        parents.Add(child, node);
                    }
                }
            }

            return -1;

        }

        private static int CountSteps(int end)
        {
            var steps = 0;
            var currNode = parents[end];

            while (currNode != 0)
            {
                steps++;

                currNode = parents[currNode];
            }

            return steps;


        }

        private static void ReadPairs()
        {

            pairs = new List<string>();

            for (int i = 0; i < pairsNum; i++)
            {
                pairs.Add(Console.ReadLine());
            }


        }

        private static void ReadGraph()
        {
            graph = new Dictionary<int, List<int>>();

            string[] input;
            int currNode;

            for (int i = 0; i < nodesNum; i++)
            {
                input = Console.ReadLine()
                    .Split(':');

                currNode = int.Parse(input[0]);

                if (!graph.ContainsKey(currNode))
                {
                    graph.Add(currNode, new List<int>());
                }

                if (!String.IsNullOrEmpty(input[1]))
                {
                    graph[currNode] = input[1]
                        .Split()
                        .Select(int.Parse)
                        .ToList();
                }
            }


        }
    }
}
