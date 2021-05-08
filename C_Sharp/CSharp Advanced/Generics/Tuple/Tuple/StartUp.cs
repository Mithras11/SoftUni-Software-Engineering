using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] firstLine = Console.ReadLine().Split();

            string person = $"{firstLine[0]} {firstLine[1]}";
            string address = firstLine[2];

            Tuple<string, string> firstTuple = new Tuple<string, string>(person, address);



            string[] secondLine = Console.ReadLine().Split();

            string name = secondLine[0];
            int beer = int.Parse(secondLine[1]);

            Tuple<string, int> secondTuple = new Tuple<string, int>(name, beer);




            string[] thirdLine = Console.ReadLine().Split();

            int integerNum = int.Parse(thirdLine[0]);
            double doubleNum = double.Parse(thirdLine[1]);

            Tuple<int, double> thirdTuple = new Tuple<int, double>(integerNum, doubleNum);


            firstTuple.PrintInfo();
            secondTuple.PrintInfo();
            thirdTuple.PrintInfo();


        }
    }
}
