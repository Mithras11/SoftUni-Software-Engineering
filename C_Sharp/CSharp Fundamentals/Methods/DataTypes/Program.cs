using System;
using System.Text;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int a = int.Parse(input);
                    Console.WriteLine(ElaborateInput(a));
                    break;

                case "real":
                    double b = double.Parse(input);
                    Console.WriteLine($"{ElaborateInput(b):F2}");
                    break;

                case "string":

                    Console.WriteLine(ElaborateInput(input));
                    break;

            }

        }

        static int ElaborateInput(int num)
        {
            int result = num * 2;
            return result;
        }

        static double ElaborateInput(double num)
        {
            double result = num * 1.5;
            return result;
        }

        static string ElaborateInput(string input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("$");
            sb.Append(input);
            sb.Append("$");

            string result = sb.ToString();

            return result;
        }
    }
}
