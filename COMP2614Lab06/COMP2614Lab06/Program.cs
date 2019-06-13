using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace COMP2614Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP2614Lab03";
           
            try
            {
                Console.WriteLine("Natural Order: ");
                GroceryItemCollection groceries = GroceryItemRepository.GetAllGroceries();
                ConsolePrinter.PrintGroceryCollection(groceries);


                Console.WriteLine("Descending Order: ");
                GroceryItemCollection groceries2 = GroceryItemRepository.GetAllGroceriesByPrice();
                ConsolePrinter.PrintGroceryCollection(groceries2);
            }


            catch (SqlException ex)
            {
                Console.WriteLine($"Data Access Error\n\n{ex.Message}\n\n{ex.StackTrace}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Processing Error\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
      
        }
    }
}
