using System;
using System.Collections.Generic;
using System.Linq;

namespace AreasInMatrix
{
    class Node
    {
        public Node(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }
        public int Col { get; set; }
    }

    class Program
    {
        static int rows;
        static int cols;

        static char[,] matrix;
        static bool[,] visited;
        static Dictionary<char, int> areas;

        static void Main(string[] args)
        {
            SetUp();
            ReadMatrix();
            ReadAreas();
            PrintResult();


        }

        private static void SetUp()
        {
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());

            matrix = new char[rows, cols];
            visited = new bool[rows, cols];
            areas = new Dictionary<char, int>();
        }

        private static void PrintResult()
        {
            int areaCount = areas.Values.Sum();

            Console.WriteLine($"Areas: {areaCount}");

            areas = areas
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var area in areas)
            {
                Console.WriteLine($"Letter '{area.Key}' -> {area.Value}");
            }
        }

        private static void ReadAreas()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!visited[i, j])
                    {
                        Dfs(i, j);

                        var areaName = matrix[i, j];

                        if (!areas.ContainsKey(areaName))
                        {
                            areas.Add(areaName, 0);
                        }

                        areas[matrix[i, j]]++;

                    }

                }

            }
        }

        static void Dfs(int row, int col)
        {
            var parent = new Node(row, col);

            visited[row, col] = true;

            var children = FindChildren(parent);

            foreach (var child in children)
            {
                Dfs(child.Row, child.Col);
            }

        }

        private static List<Node> FindChildren(Node parent)
        {
            var children = new List<Node>();

            int currRow = parent.Row;
            int currCol = parent.Col;


            if (IsChild(currRow, currCol + 1, parent))
            {
                var child = new Node(currRow, currCol + 1);
                children.Add(child);
            }
            if (IsChild(currRow, currCol - 1, parent))
            {
                var child = new Node(currRow, currCol - 1);
                children.Add(child);
            }
            if (IsChild(currRow + 1, currCol, parent))
            {
                var child = new Node(currRow + 1, currCol);
                children.Add(child);
            }
            if (IsChild(currRow - 1, currCol, parent))
            {
                var child = new Node(currRow - 1, currCol);
                children.Add(child);
            }


            return children;
        }

        private static bool IsChild(int row, int col, Node parent)
        {
            if (row < 0 || row >= matrix.GetLength(0))
            {
                return false;
            }
            if (col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }
            if (matrix[row, col] != matrix[parent.Row, parent.Col])
            {
                return false;
            }
            if (visited[row, col])
            {
                return false;
            }

            return true;
        }

        private static void ReadMatrix()
        {
            char[] line;

            for (int i = 0; i < rows; i++)
            {
                line = Console.ReadLine().ToCharArray();

                for (int j = 0; j < cols; j++)
                {

                    matrix[i, j] = line[j];
                }
            }


        }
    }
}
