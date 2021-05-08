using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            Song[] songs = new Song[numberOfSongs];

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] currentSong = Console.ReadLine().Split("_");

                string typeList = currentSong[0];
                string name = currentSong[1];
                string time = currentSong[2];

                Song song = new Song(currentSong[0], currentSong[1], currentSong[2]);
               
                songs[i] = song;
            }

            string print = Console.ReadLine();

            if (print == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }

            }
            else
            {
               
                    List<Song> filtered = songs.Where(x => x.TypeList == print).ToList();

                

                foreach (var item in filtered)
                {
                    Console.WriteLine(item.Name);
                }
                    
            }




        }

        public class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }


            public Song(string typeList, string name, string time)
            {
                this.TypeList = typeList;
                this.Name = name;
                this.Time = time;

            }


        }

    }
}
