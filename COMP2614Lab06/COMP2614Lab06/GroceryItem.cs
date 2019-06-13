using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Lab06
{
    class GroceryItem
    {
        public string Description { get; }
        public decimal Price { get; }
        public DateTime ExpirationDate { get; }

        public GroceryItem(string description, decimal price, DateTime expirationDate)
        {         
            Description = description;
            Price = price;
            ExpirationDate = expirationDate;
        }       
    }
}
