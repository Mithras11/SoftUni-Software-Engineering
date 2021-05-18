using System;
using System.Collections.Generic;
using System.Linq;

namespace SourceRemoval
{
    class Program
    {
        static List<int>[] graph;

        static void Main(string[] args)
        {
            graph = new List<int>[]
            {
                new List<int>{1, 2},
                new List<int>{3 ,4},
                new List<int>{5},
                new List<int>{2, 5},
                new List<int>{3},
                new List<int>{ }
            };


            var result = new List<int>();
            var nodes = new HashSet<int>();

            var nodesWithIncomingEdges = GetNodesWithIncomingEdges();

            for (int i = 0; i < graph.Length; i++)
            {
                if (!nodesWithIncomingEdges.Contains(i))
                {
                    nodes.Add(i);
                }
            }

            List<int> children;


            while (nodes.Count != 0)
            {
                var currNode = nodes.First();

                nodes.Remove(currNode);
                result.Add(currNode);

                children = graph[currNode].ToList();
                graph[currNode] = new List<int>();

                var leftNodesWithIncomingEdges = GetNodesWithIncomingEdges();

                foreach (var child in children)
                {
                    if (!leftNodesWithIncomingEdges.Contains(child))
                    {
                        nodes.Add(child);
                    }
                }
            }


            if (graph.SelectMany(e => e).Any())
            {
                Console.WriteLine("Sorry!");
            }
            else
            {
                Console.WriteLine(string.Join(' ', result));
            }

        }

        private static HashSet<int> GetNodesWithIncomingEdges()
        {
            var nodesWithIncomingEdges = new HashSet<int>();

            graph
                .SelectMany(e => e)
                .ToList()
                .ForEach(e => nodesWithIncomingEdges.Add(e));

            return nodesWithIncomingEdges;
        }
    }
}
