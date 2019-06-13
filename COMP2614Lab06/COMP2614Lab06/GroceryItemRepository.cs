using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Lab06
{
    class GroceryItemRepository
    {
        private static readonly string connString = @"Server=tcp:skeena.database.windows.net,1433; 
                                                      Initial Catalog=comp2614;
                                                      User ID=student;
                                                      Password=93nu5/nrCKX;
                                                      Encrypt=True;
                                                      TrustServerCertificate=False;
                                                      Connection Timeout=30;";

        public static GroceryItemCollection GetAllGroceries()
        {
            GroceryItemCollection groceries;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query = @"SELECT GroceryItemId, Description, Price, ExpirationDate
                                 FROM GroceryItem
                                 ORDER BY Description";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    groceries = new GroceryItemCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int groceryItemId;
                        string description = null;
                        decimal price = 0;
                        DateTime expirationDate = DateTime.MinValue;

                        while (reader.Read())
                        {
                            groceryItemId = (int)reader["GroceryItemId"];

                            if (!reader.IsDBNull(1))
                            {
                                description = reader["Description"] as string;
                            }

                            if (!reader.IsDBNull(2))
                            {
                                price = (decimal)reader["Price"];
                            }

                            if (!reader.IsDBNull(3))
                            {                               
                                expirationDate = (DateTime)reader["ExpirationDate"];
                            }

                            groceries.Add(new GroceryItem(description, price, expirationDate));

                            description = null;
                            price = 0;                           

                        }
                    }
                    return groceries;
                }
            }
        }

        public static GroceryItemCollection GetAllGroceriesByPrice()
        {
            GroceryItemCollection groceries;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query = @"SELECT GroceryItemId, Description, Price, ExpirationDate
                                 FROM GroceryItem
                                 ORDER BY Price";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    groceries = new GroceryItemCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int groceryItemId;
                        string description = null;
                        decimal price = 0;
                        DateTime expirationDate = DateTime.MinValue;

                        while (reader.Read())
                        {
                            groceryItemId = (int)reader["GroceryItemId"];

                            if (!reader.IsDBNull(1))
                            {
                                description = reader["Description"] as string;
                            }

                            if (!reader.IsDBNull(2))
                            {
                                price = (decimal)reader["Price"];
                            }

                            if (!reader.IsDBNull(3))
                            {                              
                                expirationDate = (DateTime)reader["ExpirationDate"];
                            }

                            groceries.Add(new GroceryItem(description, price, expirationDate));
                            description = null;
                            price = 0;
                        }
                    }
                    return groceries;
                }
            }
        }
    }
}
