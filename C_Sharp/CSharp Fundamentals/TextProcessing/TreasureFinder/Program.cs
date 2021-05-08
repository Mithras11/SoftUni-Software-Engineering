using System;
using System.Linq;
using System.Text;

namespace TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string text = string.Empty;
            string decryptedText = string.Empty;

            while ((text = Console.ReadLine()) != "find")
            {
                int counter = 0;
                StringBuilder sb = new StringBuilder();
                bool isDecrypted = false;

                while (isDecrypted == false)
                {
                    for (int i = 0; i < key.Length; i++)
                    {
                        int encryptedCode = text[counter] - key[i];
                        sb.Append((char)encryptedCode);
                        counter++;

                        if (counter > text.Length - 1)
                        {
                            decryptedText = sb.ToString();
                            isDecrypted = true;

                            break;
                        }
                    }
                }

                int firstTypeIndex = decryptedText.IndexOf('&') + 1;
                int lastTypeIndex = decryptedText.LastIndexOf('&');
                string type = decryptedText.Substring(firstTypeIndex, lastTypeIndex - firstTypeIndex);

                int firstCoordinatesIndex = decryptedText.IndexOf('<') + 1;
                int lastCoordinatesIndex = decryptedText.LastIndexOf('>');
                string coordinates = decryptedText
                    .Substring(firstCoordinatesIndex, lastCoordinatesIndex - firstCoordinatesIndex);

                Console.WriteLine($"Found {type} at {coordinates}");

            }



        }
    }
}
