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
        public decimal Title { get; }
        public DateTime ExpirationDate { get; }

        public GroceryItem(int songId, string artist, decimal title, DateTime expirationDate)
        {
            SongId = songId;
            Artist = artist;
            Title = title;
            ExpirationDate = expirationDate;
        }

        public override string ToString()
        {
            return string.Format($"{Title} by {Artist} Expiration Date: {ExpirationDate}");
        }
    }
}
