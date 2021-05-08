using System;
using System.Collections.Generic;
using System.Linq;

namespace midExamFinal
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            List<string> listOfGifts = Console.ReadLine().Split().ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "No Money")
            {
                string[] commandArray = command.Split();

                if (commandArray[0] == "OutOfStock")
                {
                    string gift = commandArray[1];
                    while (listOfGifts.Exists(x => x == gift))
                    {
                        int indexOfGift = listOfGifts.IndexOf(gift);
                        listOfGifts[indexOfGift] = "None";
                    }
                }

                else if (commandArray[0] == "Required")
                {
                    string gift = commandArray[1];
                    int index = int.Parse(commandArray[2]);
                    if (index >= 0 && index <= listOfGifts.Count - 1)
                    {
                        listOfGifts[index] = gift;
                    }
                }

                else if (commandArray[0] == "JustInCase")
                {
                    string gift = commandArray[1];
                    listOfGifts[listOfGifts.Count - 1] = gift;
                }

            }

            var result = listOfGifts.Where(x => x != "None");
            Console.WriteLine(string.Join(" ", result));
        }

    }

}