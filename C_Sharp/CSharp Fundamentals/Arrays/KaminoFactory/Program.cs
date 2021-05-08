using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int sequenceCounter = 0;

            int bestLength = 1;
            int bestIndex = 0;
            int bestSum = 0;
            int bestSequenceIndex = 0;
            int[] bestSequence = new int[length];

            while (input != "Clone them!")
            {
                int[] array = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceCounter++;

                int currentLength = 1;
                int biggestCurrentLegth = 1;
                int currentIndex = 0;
                int currentSum = 0;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] == array[i + 1])
                    {
                        currentLength++;
                    }
                    else
                    {
                        currentLength = 1;
                    }

                    if (currentLength > biggestCurrentLegth)
                    {
                        biggestCurrentLegth = currentLength;
                        currentIndex = i;
                    }

                    currentSum += array[i];
                }

                currentSum += array[length - 1];

                if (biggestCurrentLegth > bestLength)
                {
                    bestLength = biggestCurrentLegth;
                    bestIndex = currentIndex;
                    bestSum = currentSum;
                    bestSequenceIndex = sequenceCounter;
                    bestSequence = array.ToArray();
                }

                else if (biggestCurrentLegth == bestLength)
                {
                    if (currentIndex < bestIndex)
                    {
                        bestLength = biggestCurrentLegth;
                        bestIndex = currentIndex;
                        bestSum = currentSum;
                        bestSequenceIndex = sequenceCounter;
                        bestSequence = array.ToArray();
                    }
                    else if (currentIndex == bestIndex)
                    {
                        if (currentSum > bestSum)
                        {
                            bestLength = biggestCurrentLegth;
                            bestIndex = currentIndex;
                            bestSum = currentSum; 
                            bestSequenceIndex = sequenceCounter;
                            bestSequence = array.ToArray();
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(' ',bestSequence));















        }
    }
}
