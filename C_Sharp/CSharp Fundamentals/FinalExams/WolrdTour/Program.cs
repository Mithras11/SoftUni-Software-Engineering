using System;
using System.Linq;

namespace WolrdTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] newCommand = command.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (newCommand[0])
                {
                    case "Add Stop":

                        int index = int.Parse(newCommand[1]);
                        string newString = newCommand[2];

                        if (index >= 0 && index < stops.Length)
                        {
                            stops = stops.Insert(index, newString);
                        }

                        Console.WriteLine(stops);

                        break;

                    case "Remove Stop":

                        int start = int.Parse(newCommand[1]);
                        int end = int.Parse(newCommand[2]);

                        if (start >= 0 && start < stops.Length && end >= 0 && end < stops.Length)
                        {
                            stops = stops.Remove(start, end - start + 1);
                        }

                        Console.WriteLine(stops);

                        break;

                    case "Switch":

                        string oldSubstring = newCommand[1];
                        string newSubstring = newCommand[2];

                        if (stops.Contains(oldSubstring))
                        {
                           stops = stops.Replace(oldSubstring, newSubstring);
                        }

                        Console.WriteLine(stops);


                        break;
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");


        }
    }
}
