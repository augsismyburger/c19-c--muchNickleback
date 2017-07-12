using System;
using System.Collections.Generic;
using System.Linq;

namespace tooMuchNickleback
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nickleback is the BEST!.. not");

            List<(string, string)> goodSongs = new List<(string, string)>();

            HashSet<(string artist,string song)> allSongs = new HashSet<(string, string)>()
            {
                ("Nickleback", "Photograph"),
                ("Phantogram", "Black Out Days"),
                ("Nickleback", "Rockstar"),
                ("MisterWives", "Drummer Boy"),
                ("Nickleback", "Animals"),
                ("Passion Pit", "Little Secrets"),
                ("Local Natives", "Masters")
            };
            foreach ((string artist, string song) song in allSongs) {
                if (song.artist == "Nickleback") {
                    Console.WriteLine($"Nickleback sucks. Especially the song {song.song}");
                } else {
                    goodSongs.Add(song);
                }
            }
            foreach ((string, string) item in goodSongs) {
                Console.WriteLine($"{item.Item2} by {item.Item1} is a good song");
            }
        }
    }
}
