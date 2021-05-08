using System;
using System.IO;
using System.Text;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = File.ReadAllLines(@"../../../input1.txt");
            var secondInput = File.ReadAllLines(@"../../../input2.txt");

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < firstInput.Length; i++)
            {
                sb.AppendLine(firstInput[i]);
                sb.AppendLine(secondInput[i]);
            }

            File.WriteAllText(@"../../../output.txt", sb.ToString());



        }
    }
}
