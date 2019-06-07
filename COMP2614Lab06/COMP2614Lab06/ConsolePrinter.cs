using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Lab06
{
    class ConsolePrinter
    {
        public static void PrintSongCollection(GroceryItemCollection songs)
        {
            string divider = new string('-', 70);
            Console.WriteLine($"{"Artist",-30} {"Title",-30} {"Length"}\n{divider}");

            foreach (GroceryItem song in songs)
            {
                PrintSong(song);
            }

            TimeSpan length = new TimeSpan(0, 0, songs.TotalLength);
            Console.WriteLine(divider);
            Console.WriteLine($"{"Total:",-30} {string.Empty,-30} {length.Hours:D2}:{length.Minutes:D2}:{length.Seconds:D2}\n\n");
        }

        public static void PrintSong(GroceryItem song)
        {
            TimeSpan length = new TimeSpan(0, 0, song.Length);
            Console.WriteLine($"{song.Artist,-30} {song.Title,-30} {length.Hours:D2}:{length.Minutes:D2}:{length.Seconds:D2}");
        }
    }
}
