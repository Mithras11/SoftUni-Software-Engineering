using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "merge")
                {
                    if (text.Count == 1)
                    {
                        continue;
                    }

                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    List<string> result = new List<string>();

                    if (startIndex < 0 || startIndex > text.Count - 1)
                    {
                        startIndex = 0;
                    }

                    if (endIndex > text.Count - 1 || endIndex < 0)
                    {
                        endIndex = text.Count - 1;
                    }




                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        result.Add(text[i]);
                    }

                    string word = string.Concat<string>(result);

                    text.RemoveRange(startIndex, endIndex - startIndex + 1);
                    text.Insert(startIndex, word);


                }

                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);

                    List<string> newParts = new List<string>();

                    string word = text[index];

                    bool lengthIsOdd = false;
                    string last = string.Empty;

                    if (word.Length % partitions != 0)
                    {
                        int remainder = word.Length % partitions;

                        lengthIsOdd = true;

                        last = word.Substring(word.Length - remainder);

                    }

                    int partitionsLength = word.Length / partitions;

                    string newPartition = string.Empty;

                    int counter = 0;
                    int i = 0;

                    while (counter < partitions)
                    {
                        newPartition = word.Substring(i, partitionsLength);

                        newParts.Add(newPartition);

                        counter++;
                        i += partitionsLength;
                    }


                    if (lengthIsOdd)
                    {
                        newParts[newParts.Count - 1] += last;
                    }

                    text.RemoveAt(index);
                    text.InsertRange(index, newParts);
                }

            }

            Console.WriteLine(string.Join(' ', text));
        }
    }
}
