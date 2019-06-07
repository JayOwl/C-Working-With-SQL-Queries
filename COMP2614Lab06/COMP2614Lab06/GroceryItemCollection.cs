using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Lab06
{
    class GroceryItemCollection : List<GroceryItem>
    {
        private decimal totalPrice;
        public int TotalLength
        {
            get
            {
                int total = 0;

                foreach (GroceryItem song in this)
                {
                    total += song.Length;
                }

                return total;
            }
        }
    }
}
