using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Lab06
{
    class GroceryItem
    {
        public int SongId { get; set; }
        public string Artist { get; }
        public string Title { get; }
        public int Length { get; }

        public GroceryItem(int songId, string artist, string title, int length)
        {
            SongId = songId;
            Artist = artist;
            Title = title;
            Length = length;
        }

        public override string ToString()
        {
            return string.Format($"{Title} by {Artist} Length: {Length}");
        }
    }
}
