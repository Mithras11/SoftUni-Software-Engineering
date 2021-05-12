using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(", ").ToList();
            var size = names.Count;
            var cinema = new string[size];

            var input = string.Empty;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "generate")
                {
                    break;
                }


                var tokens = input.Split(" - ").ToArray();
                var person = tokens[0];
                var seat = int.Parse(tokens[1]);

                cinema[seat - 1] = person;
                names.Remove(person);

            }


            GenerateCombinations(names, cinema, 0, 0);

        }

        private static void GenerateCombinations(List<string> names, string[] cinema, int index, int border)
        {
           

            for (int i = border; i < names.Count; i++)
            {
                

                if (cinema[index]!=null)
                {
                   index++;
                   
                }

                if (index == cinema.Length)
                {
                    Print(cinema);

                }

                cinema[index] = names[i];

                GenerateCombinations(names, cinema, index + 1, border + 1);

                

                border++;
                
            }



        }

        private static void Print(string[] cinema)
        {
            Console.WriteLine(string.Join(' ', cinema));
        }
    }
}
