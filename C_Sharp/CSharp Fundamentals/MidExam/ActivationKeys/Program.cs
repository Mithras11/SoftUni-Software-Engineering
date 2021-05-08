using System;
using System.Collections.Generic;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            List<char> rawKey = new List<char>();

            for (int i = 0; i < key.Length; i++)
            {
                char currentChar = key[i];
                rawKey.Add(currentChar);
            }



            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Generate")
                {
                    break;
                }
                else
                {
                    string[] toDo = command.Split(">>>");

                    switch (toDo[0])
                    {
                        case "Contains":
                            string substring = toDo[1];
                            string currentKey = string.Empty;
                            foreach (var item in rawKey)
                            {
                                currentKey += item;
                            }

                            if (currentKey.Contains(substring))
                            {
                                Console.WriteLine($"{currentKey} contains {substring}");
                            }
                            else
                            {
                                Console.WriteLine("Substring not found!");
                            }
                            break;

                        case "Flip":

                            string size = toDo[1];
                            int start = int.Parse(toDo[2]);
                            int end = int.Parse(toDo[3]);

                            if (size == "Upper")
                            {
                                for (int i = start; i < end; i++)
                                {

                                    char toUpper = Char.ToUpper(rawKey[i]);
                                    rawKey[i] = toUpper;
                                }
                            }
                            else
                            {
                                for (int i = start; i < end; i++)
                                {

                                    char toLower = Char.ToLower(rawKey[i]);
                                    rawKey[i] = toLower;
                                }
                            }

                            foreach (var item in rawKey)
                            {
                                Console.Write(item);
                            }
                                Console.WriteLine();

                            break;


                        case "Slice":

                            int startIndex = int.Parse(toDo[1]);
                            int endIndex = int.Parse(toDo[2]);
                            int range = endIndex - startIndex;


                            rawKey.RemoveRange(startIndex, range);


                            foreach (var item in rawKey)
                            {
                                Console.Write(item);
                            }
                            Console.WriteLine();
                            break;
                    }

                }
            }
            string finalKey = string.Empty;
            foreach (var item in rawKey)
            {
                finalKey += item;
            }

            Console.WriteLine($"Your activation key is: {finalKey}");


        }
    }
}
