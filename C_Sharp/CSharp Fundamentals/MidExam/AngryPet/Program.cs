using System;
using System.Collections.Generic;
using System.Linq;

namespace AngryPet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> priceRatings = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int entryPoint = int.Parse(Console.ReadLine());

            int leftDamage = 0;
            int rightDamage = 0;

            string typeToBreak = Console.ReadLine();
            string typeOfPrice = Console.ReadLine();

            if (typeToBreak == "cheap")
            {
                switch (typeOfPrice)
                {
                    case "positive":
                        for (int i = 0; i < entryPoint; i++)
                        {
                            if (priceRatings[i] > 0 && priceRatings[i] < priceRatings[entryPoint])
                            {
                                leftDamage += priceRatings[i];
                            }
                        }

                        for (int j = entryPoint + 1; j < priceRatings.Count; j++)
                        {
                            if (priceRatings[j] > 0 && priceRatings[j] < priceRatings[entryPoint])
                            {
                                rightDamage += priceRatings[j];
                            }
                        }

                        break;

                    case "negative":
                        for (int i = 0; i < entryPoint; i++)
                        {
                            if (priceRatings[i] < 0 && priceRatings[i] < priceRatings[entryPoint])
                            {
                                leftDamage += priceRatings[i];
                            }
                        }

                        for (int j = entryPoint + 1; j < priceRatings.Count; j++)
                        {
                            if (priceRatings[j] < 0 && priceRatings[j] < priceRatings[entryPoint])
                            {
                                rightDamage += priceRatings[j];
                            }
                        }

                        break;

                    case "all":
                        for (int i = 0; i < entryPoint; i++)
                        {
                            if (priceRatings[i] < priceRatings[entryPoint])
                            {
                                leftDamage += priceRatings[i];
                            }
                        }

                        for (int j = entryPoint + 1; j < priceRatings.Count; j++)
                        {
                            if (priceRatings[j] < priceRatings[entryPoint])
                            {
                                rightDamage += priceRatings[j];
                            }
                        }

                        break;
                }


            }
            else if (typeToBreak == "expensive")
            {
                switch (typeOfPrice)
                {
                    case "positive":
                        for (int i = 0; i < entryPoint; i++)
                        {
                            if (priceRatings[i] > 0 && priceRatings[i] >= priceRatings[entryPoint])
                            {
                                leftDamage += priceRatings[i];
                            }
                        }

                        for (int j = entryPoint + 1; j < priceRatings.Count; j++)
                        {
                            if (priceRatings[j] > 0 && priceRatings[j] >= priceRatings[entryPoint])
                            {
                                rightDamage += priceRatings[j];
                            }
                        }

                        break;

                    case "negative":
                        for (int i = 0; i < entryPoint; i++)
                        {
                            if (priceRatings[i] < 0 && priceRatings[i] >= priceRatings[entryPoint])
                            {
                                leftDamage += priceRatings[i];
                            }
                        }

                        for (int j = entryPoint + 1; j < priceRatings.Count; j++)
                        {
                            if (priceRatings[j] < 0 && priceRatings[j] >= priceRatings[entryPoint])
                            {
                                rightDamage += priceRatings[j];
                            }
                        }

                        break;

                    case "all":
                        for (int i = 0; i < entryPoint; i++)
                        {
                            if (priceRatings[i] >= priceRatings[entryPoint])
                            {
                                leftDamage += priceRatings[i];
                            }
                        }

                        for (int j = entryPoint + 1; j < priceRatings.Count; j++)
                        {
                            if (priceRatings[j] >= priceRatings[entryPoint])
                            {
                                rightDamage += priceRatings[j];
                            }
                        }

                        break;
                }
            }


            if (leftDamage>rightDamage)
            {
                Console.WriteLine($"Left - {leftDamage}");
            }
            else if (rightDamage>leftDamage)
            {
                Console.WriteLine($"Right - {rightDamage}");
            }
            else if (leftDamage==rightDamage)
            {
                Console.WriteLine($"Left - {leftDamage}");
            }

        }
    }
}
