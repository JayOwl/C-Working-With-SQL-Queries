using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Lab06
{
    class ConsolePrinter
    {
        public static void PrintSongCollection(GroceryItemCollection groceries)
        {
            string divider = new string('-', 70);
            Console.WriteLine($"{"Description",-30} {"Price",-30} {"ExpirationDate"}\n{divider}");

            foreach (GroceryItem song in groceries)
            {
                PrintSong(song);
            }         
        }

        public static void PrintSong(GroceryItem song)
        {
            //TimeSpan length = new TimeSpan(0, 0, song.Length);
            Console.WriteLine($"{song.Description,-30} {song.Price,-30} {song.ExpirationDate}");
        }
    }
}
