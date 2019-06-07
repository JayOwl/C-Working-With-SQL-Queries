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

        public static GroceryItemCollection GetAllSongs()
        {
            GroceryItemCollection songs;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // embedded SQL
                string query = @"SELECT SongId, Artist, Title, Length
                                 FROM Song
                                 ORDER BY Artist, Title";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    songs = new GroceryItemCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int songId;
                        string artist = null;
                        string title;
                        int length = 0;

                        while (reader.Read())
                        {
                            songId = (int)reader["SongId"];

                            if (!reader.IsDBNull(1))
                            {
                                artist = reader["Artist"] as string;
                            }

                            title = reader["Title"] as string;

                            if (!reader.IsDBNull(3))
                            {
                                length = (int)reader["Length"];
                            }

                            songs.Add(new GroceryItem(songId, artist, title, length));

                            artist = null;
                            length = 0;
                        }
                    }

                    return songs;
                }
            }
        }

    }
}
