using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Reg
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string keyPattern = @"[starSTAR]";
            Regex keyRegex = new Regex(keyPattern);

            int key = keyRegex.Matches(message).Count;
            StringBuilder sb = new StringBuilder();

            for (int j = 0; j < message.Length; j++)
            {
                sb.Append((char)(message[j] - key));
            }

            string newMesage = sb.ToString();
        }
    }
}
