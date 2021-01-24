using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> firstList = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            List<int> secondList = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .Reverse()
               .ToList();

            List<int> maxList = new List<int>();

            if (firstList.Count > secondList.Count)
            {
                maxList = firstList;
            }
            else
            {
                maxList = secondList;
            }

            List<int> rule = new List<int>();

            for (int i = maxList.Count - 2; i < maxList.Count; i++)
            {
                rule.Add(maxList[i]);
                
            }

            maxList.RemoveAt(maxList.Count - 2);
            maxList.RemoveAt(maxList.Count-1);

            rule.Sort();

            List<int> mixedList = new List<int>();
            secondList.Reverse();

            for (int i = 0; i < maxList.Count; i++)
            {
                mixedList.Add(firstList[i]);
                mixedList.Add(secondList[i]);
            }

            List<int> result = mixedList.FindAll(n => n > rule[0] && n < rule[1]);

            result.Sort();

            Console.WriteLine(string.Join(' ', result));




        }
    }
}
