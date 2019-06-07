using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Lab06
{
    class ConsolePrinter
    {
        public static void PrintGroceryCollection(GroceryItemCollection groceries, string header)
        {
            foreach (GroceryItem grocery in groceries)
            {
                DateTime dateTimeExpiry = grocery.ExpriationDate;
                string stringDateTime;
                stringDateTime = Convert.ToString(dateTimeExpiry);

                if (grocery.ExpriationDate == DateTime.MinValue)
                {
                    stringDateTime = "<Never>";
                }
                else
                {
                    stringDateTime = dateTimeExpiry.ToString("ddd") + " " + dateTimeExpiry.ToString("MMM dd, yyyy");
                }

                Console.WriteLine($"{grocery.Description,-20} {grocery.Price,20:N2}   {stringDateTime,-15}");
            }
        }
    }
}
