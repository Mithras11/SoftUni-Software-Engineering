using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            BigInteger coolThreshold = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    coolThreshold *= (int)Char.GetNumericValue(input[i]);
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");

            List<string> text = input.Split().ToList();
            
            List<string> validEmojis = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                string word = text[i];
                char lastChar = word[word.Length - 1];
                if (lastChar != ':' || lastChar != '*')
                {
                    word = word.Remove(word.Length - 1, 1);
                    text[i] = word;
                }
                if (word.Length >= 7
                                   && word[0] == ':' && word[1] == ':'
                                   && word[word.Length - 1] == ':' && word[word.Length - 2] == ':'
                                   && ((int)word[2] >= 65 && (int)word[2] <= 90))
                {
                    bool invalid = false;
                    for (int j = 3; j < word.Length - 2; j++)
                    {
                        if (word[j] < 97 && word[j] > 122)
                        {
                            invalid = true;
                            break;
                        }
                    }

                    if (invalid == false)
                    {
                        validEmojis.Add(word);

                    }
                }



                else if (word.Length >= 7
                     && word[0] == '*' && word[1] == '*'
                     && word[word.Length - 1] == '*' && word[word.Length - 2] == '*'
                     && ((int)word[2] >= 65 && (int)word[2] <= 90))
                {
                    bool invalid = false;
                    for (int j = 3; j < word.Length - 2; j++)
                    {
                        if (word[j] < 97 && word[j] > 122)
                        {
                            invalid = true;
                            break;
                        }
                    }
                    if (invalid == false)
                    {
                        validEmojis.Add(word);
                    }
                }
            }

                List<string> coolEmojis = new List<string>();

                foreach (string emoji in validEmojis)
                {
                    int currentSumOfChars = 0;
                    for (int k = 2; k < emoji.Length - 2; k++)
                    {
                        int currentChar = (int)emoji[k];
                        currentSumOfChars += currentChar;

                    }

                    if (currentSumOfChars >= coolThreshold)
                    {
                        coolEmojis.Add(emoji);
                    }
                }








            }
        }
    }
