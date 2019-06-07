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
        private decimal TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    }
}
