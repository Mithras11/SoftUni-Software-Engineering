using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                else
                {
                    string[] command = input.Split();

                    switch (command[0])
                    {
                        case "swap":
                            int index1 = int.Parse(command[1]);
                            int index2 = int.Parse(command[2]);

                            int temporary = numbers[index1];
                            numbers[index1] = numbers[index2];
                            numbers[index2] = temporary;

                            break;


                        case "multiply":
                            int ind1 = int.Parse(command[1]);
                            int ind2 = int.Parse(command[2]);

                            numbers[ind1] *= numbers[ind2];

                            break;

                        case "decrease":
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                numbers[i] -= 1;
                            }

                            break;
                    }
                }
            }

            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
