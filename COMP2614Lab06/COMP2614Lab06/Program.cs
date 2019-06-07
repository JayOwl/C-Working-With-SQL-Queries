using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace COMP2614Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP2614 Assignment 04 A00838629";

            string path = @"...\\...\\groceries.csv";

            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist.");
            }

            if (path == null)
            {
                Console.WriteLine("File Path not found.");
            }

            string[] readLinesArray = File.ReadAllLines(path);

            decimal totalPrice = 0;

            GroceryItemCollection groceryItems = new GroceryItemCollection();
            foreach (string line in readLinesArray)
            {
                string[] splitLine = line.Split(',');
                string description = GetValueOrEmpty(splitLine, 0);
                string price = GetValueOrEmpty(splitLine, 1);
                string dateTime = GetValueOrEmpty(splitLine, 2);
                decimal convertedGroceryPrice = Convert.ToDecimal(price);
                DateTime convertedGroceryExpriation = Convert.ToDateTime(dateTime);
                groceryItems.Add(new GroceryItem { Description = description, Price = convertedGroceryPrice, ExpriationDate = convertedGroceryExpriation });
                totalPrice += convertedGroceryPrice;
            }

            Console.WriteLine("Natural Order:");
            Console.WriteLine($"{"Grocery Item",-20} {"Price",20:N2}   {"Expires",-15}");
            Console.WriteLine(new string('-', 60));
            ConsolePrinter.PrintGroceryCollection(groceryItems, "");
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"{"Total:",-20} {totalPrice,20}");
            Console.WriteLine("\n");

            groceryItems.Sort();

            Console.WriteLine("Sorder Order: [Price Descending]");
            Console.WriteLine($"{"Grocery Item",-20} {"Price",20:N2}   {"Expires",-15}");
            Console.WriteLine(new string('-', 60));
            ConsolePrinter.PrintGroceryCollection(groceryItems, "");
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"{"Total:",-20} {totalPrice,20}");
        }

        /// <summary>
        /// Used to handle 'Index out of bounds 
        /// Checks  to see if the array defaulted value, has a value. If not, return to type null

        /// </summary>
        /// <param name="items"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        static string GetValueOrEmpty(string[] items, int index)
        {
            string value = items.ElementAtOrDefault(index);
            if (value != null)
            {
                return value;
            }
            else
            {
                return null;
            }
        }
    }
}
