using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Queue<Pump> pumps = new Queue<Pump>();

            for (int i = 0; i < num; i++)
            {
                long[] newPump = Console.ReadLine().Split().Select(long.Parse).ToArray();
                pumps.Enqueue(new Pump(newPump[0], newPump[1], i));
            }

            long fuel = 0;
            bool isFound = false;
            int start = 0;

            while (isFound == false)
            {
                Pump currentPump = pumps.Peek();
                fuel += currentPump.Petrol;

                if (fuel >= currentPump.Distance)
                {
                    fuel -= currentPump.Distance;
                    pumps.Enqueue(pumps.Dequeue());

                    if (pumps.Peek().Index == start)
                    {
                        isFound = true;

                    }
                }
                else
                {
                    fuel = 0;
                    pumps.Enqueue(pumps.Dequeue());
                    start = pumps.Peek().Index;
                }

            }

            Console.WriteLine(start);

        }


        class Pump
        {
            public long Petrol { get; set; }
            public long Distance { get; set; }
            public int Index { get; set; }

            public Pump(long petrol, long distance, int i)
            {
                this.Petrol = petrol;
                this.Distance = distance;
                this.Index = i;
            }

        }
    }
}
