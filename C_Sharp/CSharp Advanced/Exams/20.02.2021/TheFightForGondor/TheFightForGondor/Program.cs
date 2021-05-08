using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWaves = int.Parse(Console.ReadLine());

            Queue<Plate> plates = new Queue<Plate>();

            int[] platesStrength = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var item in platesStrength)
            {
                plates.Enqueue(new Plate(item));
            }

            Stack<int> orcs = new Stack<int>();


            bool orcsWin = false;

            for (int i = 0; i < numOfWaves; i++)
            {
                int[] orcsStrength = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                foreach (var item in orcsStrength)
                {
                    orcs.Push(item);
                }


                if ((i + 1) % 3 == 0)
                {
                    plates.Enqueue(new Plate(int.Parse(Console.ReadLine())));

                }


                while (orcs.Any() && plates.Any())
                {
                    if (orcs.Peek() > plates.Peek().Value)
                    {
                        int temp = orcs.Pop() - plates.Dequeue().Value;

                        orcs.Push(temp);
                    }
                    else if (orcs.Peek() == plates.Peek().Value)
                    {
                        orcs.Pop();
                        plates.Dequeue();
                    }
                    else if (orcs.Peek() < plates.Peek().Value)
                    {
                        plates.Peek().Value -= orcs.Pop();
                    }

                }

                if (plates.Count == 0)
                {
                    orcsWin = true;
                    break;
                }


            }


            if (orcsWin)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
            }

            if (orcs.Any())
            {
                Console.WriteLine($"Orcs left: { string.Join(", ", orcs)}");
            }
            else if (plates.Any())
            {
                //var sb = new StringBuilder();

                //foreach (var item in plates)
                //{
                //    sb.AppendJoin(", ", plates.Select(p => p.Value));
                //}

                Console.WriteLine($"Plates left: { string.Join(", ", plates.Select(p => p.Value))}");
            }

        }



    }

    public class Plate
    {
        public Plate(int value)
        {
            this.Value = value;

        }
        public int Value { get; set; }
    }
}

