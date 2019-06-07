using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Lab06
{
    class GroceryItem
    {
        public int GroceryItemId { get; set; }
        public string Description { get; }
        public decimal Price { get; }
        public DateTime ExpirationDate { get; }

        public GroceryItem(int groceryItemId, string description, decimal price, DateTime expirationDate)
        {
            GroceryItemId = groceryItemId;
            Description = description;
            Price = price;
            ExpirationDate = expirationDate;
        }

        public override string ToString()
        {
            return string.Format($"{Price} by {Description} Expiration Date: {ExpirationDate}");
        }
    }
}
