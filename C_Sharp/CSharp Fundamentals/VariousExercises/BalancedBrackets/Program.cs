using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isOpened = false;
            bool isBalanced = true;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (isOpened == false)
                    {
                        isOpened = true;

                    }
                    else
                    {
                        isBalanced = false;
                    }

                }
                else if (input == ")")
                {
                    if (isOpened == true)
                    {

                        isOpened = false;
                    }
                    else
                    {
                        isBalanced = false;

                    }
                }

            }

            if (isBalanced && isOpened == false)
            {
                Console.WriteLine("BALANCED");
            }
            else 
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
