using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema
{
    class Program
    {
        static List<string> names;
        static string[] cinema;

        static void Main(string[] args)
        {
            names = Console.ReadLine().Split(", ").ToList();
            var size = names.Count;

            cinema = new string[size];

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


            Permute(0);

        }

        private static void Permute(int index)
        {
            if (index == names.Count)
            {
                Print();

            }
            else
            {
                Permute(index + 1);

                for (int i = index + 1; i < names.Count; i++)
                {
                    Swap(index, i);
                    Permute(index + 1);
                    Swap(index, i);
                }
            }

        }

        private static void Swap(int index, int i)
        {
            var temp = names[index];
            names[index] = names[i];
            names[i] = temp;
        }



        private static void Print()
        {
            var sb = new StringBuilder();
            int index = 0;

            for (int i = 0; i < cinema.Length; i++)
            {
                if (cinema[i] == null)
                {
                    sb.Append(names[index]);
                    index++;
                }
                else
                {
                    sb.Append(cinema[i]);
                }

                sb.Append(' ');

            }

            var result = sb.ToString().TrimEnd();

            Console.WriteLine(result);
        }
    }
}
