using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();

            switch (inputType)
            {
                case "int":

                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());

                    int result = GetMax(num1, num2);
                    Console.WriteLine(result);

                    break;

                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());

                    char resultChar = GetMax(char1, char2);
                    Console.WriteLine(resultChar);

                    break;



                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    
                    string resultString = GetMax(str1, str2);
                    Console.WriteLine(resultString);

                    break;
            }




        }

        static int GetMax(int num1, int num2)
        {
            int result = 0;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }

        static char GetMax(char char1, char char2)
        {
            char resultChar = (char)0x00;
            if (char1 > char2)
            {
                resultChar = char1;

            }
            else
            {
                resultChar = char2;
            }

            return resultChar;

        }

        static string GetMax(string str1, string str2)
        {
            string resultString = String.Empty;
            int cmpVal = str1.CompareTo(str2);

            if (cmpVal>=0)
            {
                resultString = str1;
            }
            else
            {
                resultString = str2;
            }

            return resultString;


        }
    }
}
