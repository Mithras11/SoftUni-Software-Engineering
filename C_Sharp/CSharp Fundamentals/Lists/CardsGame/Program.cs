using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            List<int> secondDeck = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();



            for (int i = 0; i < firstDeck.Count; i++)
            {
                int currentCard1 = firstDeck[i];
                int currentCard2 = secondDeck[i];

                if (currentCard1 > currentCard2)
                {
                    firstDeck.Add(currentCard2);
                    firstDeck.Insert(firstDeck.Count - 1, currentCard1);
                    firstDeck.RemoveAt(i);

                    secondDeck.Remove(currentCard2);

                    i--;

                }
                else if (currentCard2 > currentCard1)
                {
                    secondDeck.Add(currentCard1);
                    secondDeck.Insert(secondDeck.Count - 1, currentCard2);
                    secondDeck.RemoveAt(i);

                    firstDeck.Remove(currentCard1);
                    i--;
                }
                else if (currentCard1 == currentCard2)
                {
                    firstDeck.Remove(currentCard1);
                    secondDeck.Remove(currentCard2);
                    i--;
                }

                if (firstDeck.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
                    break;
                }
                else if (secondDeck.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
                    break;
                }
                
            }
        }


    }
}
