using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);

                    if (index >= arr.Length || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        arr = Exchange(arr, index);
                    }

                }
                else if (command[0] == "max")
                {
                    string type = command[1];

                    Maximum(arr, type);
                }
                else if (command[0] == "min")
                {
                    string type = command[1];

                    Minimum(arr, type);
                }
                else if (command[0] == "first")
                {
                    int count = int.Parse(command[1]);
                    string type = command[2];

                    First(arr, count, type);

                }
                else if (command[0] == "last")
                {
                    int count = int.Parse(command[1]);
                    string type = command[2];

                    Last(arr, count, type);
                }


            }


            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }


        public static int[] Exchange(int[] arr, int index)
        {

            List<int> temp = new List<int>();

            for (int i = index + 1; i < arr.Length; i++)
            {
                temp.Add(arr[i]);
            }
            for (int i = 0; i <= index; i++)
            {
                temp.Add(arr[i]);
            }

            arr = temp.ToArray();

            return arr;





        }

        public static void Maximum(int[] arr, string type)
        {
            if (type == "even")
            {
                int[] maxEven = arr.Where(x => x % 2 == 0).ToArray();

                if (maxEven.Length == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {

                    int max = maxEven.Max();
                    int index = Array.LastIndexOf(arr, max);

                    Console.WriteLine(index);

                }
            }
            else if (type == "odd")
            {
                int[] maxOdd = arr.Where(x => x % 2 != 0).ToArray();

                if (maxOdd.Length == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {

                    int max = maxOdd.Max();
                    int index = Array.LastIndexOf(arr, max);

                    Console.WriteLine(index);

                }
            }
        }

        public static void Minimum(int[] arr, string type)
        {
            if (type == "even")
            {
                int[] minEven = arr.Where(x => x % 2 == 0).ToArray();

                if (minEven.Length == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {

                    int min = minEven.Min();
                    int index = Array.LastIndexOf(arr, min);

                    Console.WriteLine(index);

                }
            }
            else if (type == "odd")
            {
                int[] minOdd = arr.Where(x => x % 2 != 0).ToArray();

                if (minOdd.Length == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {

                    int min = minOdd.Max();
                    int index = Array.LastIndexOf(arr, min);

                    Console.WriteLine(index);

                }
            }
        }

        public static void First(int[] arr, int count, string type)
        {
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> result = new List<int>();

                if (type == "even")
                {
                    List<int> evenNums = arr.Where(x => x % 2 == 0).ToList();

                    if (evenNums.Count <= count)
                    {
                        result = evenNums;

                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            result.Add(evenNums[i]);

                        }
                    }


                }
                else if (type == "odd")
                {
                    List<int> oddNums = arr.Where(x => x % 2 != 0).ToList();

                    if (oddNums.Count <= count)
                    {
                        result = oddNums;

                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            result.Add(oddNums[i]);

                        }
                    }

                }
                if (result.Count == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {

                    Console.WriteLine($"[{string.Join(", ", result)}]");
                }
            }
        }

        public static void Last(int[] arr, int count, string type)
        {
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> result = new List<int>();

                if (type == "even")
                {
                    List<int> evenNums = arr.Where(x => x % 2 == 0).ToList();

                    if (evenNums.Count <= count)
                    {
                        result = evenNums;

                    }
                    else
                    {
                        for (int i = evenNums.Count - 1 - count; i <= evenNums.Count - 1; i++)
                        {
                            result.Add(evenNums[i]);

                        }
                    }


                }
                else if (type == "odd")
                {
                    List<int> oddNums = arr.Where(x => x % 2 != 0).ToList();

                    if (oddNums.Count <= count)
                    {
                        result = oddNums;

                    }
                    else
                    {
                        for (int i = oddNums.Count - 1 - count; i <= oddNums.Count - 1; i++)
                        {
                            result.Add(oddNums[i]);

                        }
                    }

                }
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }
    }
}
