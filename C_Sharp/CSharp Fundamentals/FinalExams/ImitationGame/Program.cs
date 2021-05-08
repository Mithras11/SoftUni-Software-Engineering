using System;
using System.Linq;

namespace ImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMaessage = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] command = input.Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Move")
                {
                    int numberOfLetters = int.Parse(command[1]);
                    string tempSubstring = encryptedMaessage.Substring(0, numberOfLetters);
                    encryptedMaessage = encryptedMaessage.Remove(0, numberOfLetters);
                    encryptedMaessage += tempSubstring;
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];

                    encryptedMaessage = encryptedMaessage.Insert(index, value);


                }
                else if (command[0] == "ChangeAll")
                {
                    string subString = command[1];
                    string replacement = command[2];

                    encryptedMaessage = encryptedMaessage.Replace(subString, replacement);
                }



                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {encryptedMaessage}");
        }
    }
}
