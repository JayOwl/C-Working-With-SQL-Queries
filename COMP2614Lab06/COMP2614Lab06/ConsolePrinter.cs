using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Lab06
{
    class ConsolePrinter
    {
       
        public static void PrintGroceryCollection(GroceryItemCollection groceries)
        {
            string divider = new string('-', 70);
           // Console.WriteLine("Natural Order:");
            Console.WriteLine($"{"Description",-30} {"Price",-30} {"ExpirationDate"}\n{divider}");
         
            decimal totalPrice = 0;

            foreach (GroceryItem groceryItem in groceries)
            {
                PrintGroceries(groceryItem);
               
                totalPrice += groceryItem.Price;
            }
        
            Console.WriteLine(divider);
            Console.WriteLine($"{"Total: ",-30} {totalPrice,-30} ");

            Console.WriteLine("\n");
        }

        public static void PrintGroceries(GroceryItem groceryItem)
        {
            string divider = new string('-', 70);
            DateTime dateTimeExpiry = groceryItem.ExpirationDate;
            string stringDateTime;
            if (groceryItem.ExpirationDate == DateTime.MinValue)
            {
                stringDateTime = "<Never>";
            }
            else
            {
                stringDateTime = dateTimeExpiry.ToString("ddd") + " " + dateTimeExpiry.ToString("MMM dd, yyyy");
            }


            Console.WriteLine($"{groceryItem.Description,-30} {groceryItem.Price,-30} {stringDateTime}");

          


            

          
        }
    }
}
