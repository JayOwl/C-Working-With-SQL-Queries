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
            Console.Title = "ADO.NET Example";

            try
            {
                GroceryItemCollection songs = GroceryItemRepository.GetAllSongs();
                ConsolePrinter.PrintSongCollection(songs);
                Console.ReadLine();
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
