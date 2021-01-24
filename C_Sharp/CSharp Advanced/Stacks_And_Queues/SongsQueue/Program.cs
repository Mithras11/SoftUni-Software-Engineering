using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries));

            while (songs.Count > 0)
            {
                string input = Console.ReadLine();
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Play":

                        songs.Dequeue();

                        break;

                    case "Add":

                        string currentSong = input.Substring(4);

                        if (songs.Contains(currentSong))
                        {
                            Console.WriteLine($"{currentSong} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(currentSong);
                        }

                        break;

                    case "Show":

                        Console.WriteLine(string.Join(", ", songs));

                        break;
                }

            }

            Console.WriteLine("No more songs!");

        }
    }
}
