using System;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();

            string person = $"{firstLine[0]} {firstLine[1]}";
            string address = firstLine[2];
            string town = string.Empty;

            if (firstLine.Length > 4)
            {
                town = $"{firstLine[3]} {firstLine[4]}";
            }
            else
            {
                town = firstLine[3];

            }

            Threeuple<string, string, string> firstThreeuple = new Threeuple<string, string, string>(person, address, town);



            string[] secondLine = Console.ReadLine().Split();

            string name = secondLine[0];
            int beer = int.Parse(secondLine[1]);
            string drunkOrNot = secondLine[2];

            bool drunk = false;

            if (drunkOrNot == "drunk")
            {
                drunk = true;
            }

            Threeuple<string, int, bool> secondThreeuple = new Threeuple<string, int, bool>(name, beer, drunk);




            string[] thirdLine = Console.ReadLine().Split();

            string client = thirdLine[0];
            double balance = double.Parse(thirdLine[1]);
            string bankName = thirdLine[2];

            Threeuple<string, double, string> thirdThreeuple = new Threeuple<string, double, string>(client, balance, bankName);


            firstThreeuple.PrintInfo();
            secondThreeuple.PrintInfo();
            thirdThreeuple.PrintInfo();

        }
    }
}
