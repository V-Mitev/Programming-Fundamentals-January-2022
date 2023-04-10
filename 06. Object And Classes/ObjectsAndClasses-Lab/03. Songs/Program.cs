using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Song
    {
        public string TypeOfList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] tokens = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);

                string typeOfList = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                Song song = new Song()
                {
                    TypeOfList = typeOfList,
                    Name = name,
                    Time = time
                };

               songs.Add(song);
            }

            string typeListToSearch = Console.ReadLine();

            if (typeListToSearch == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = songs.FindAll(song => song.TypeOfList == typeListToSearch);

                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
