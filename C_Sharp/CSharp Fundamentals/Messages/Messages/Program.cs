using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            int numOfDigits = 0;
            int mainDigit = 0;
            int offset = 0;
            int letterIndex = 0;

            int codeValue = 0;
            string input = "";
            string output = "";

            for (int i = 0; i < counter; i++)

            {
                input = Console.ReadLine();

                if (input == "0" )
                {
                    output += " ";
                    continue;
                }

                numOfDigits = input.Length;
                mainDigit = (int.Parse(input)) % 10;

                offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                letterIndex = offset + numOfDigits - 1;
                codeValue = 97 + letterIndex;

               

                output += (char)codeValue;
            }




            Console.WriteLine(output);

        }
    }
}
