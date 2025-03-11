using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4_NET8.Shared
{
    public static class Data
    {
        public static string ConnectionString { get; set; }

        public static int CreateClub()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string insert = "INSERT INTO footballclubs VALUES('Racing Genk','Belgium', 1988, 'Cegeka Arena', 22764)";
                using (SqlCommand command = new SqlCommand(insert, connection))
                {
                    return command.ExecuteNonQuery();
                }
                //connection.Close(); // <== niet nodig door using! (gebeurt automatisch)
            }
        }

        public static int DeleteClub(string clubName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string delete = "DELETE FROM footballclubs WHERE ClubName = @ClubName";
                using (SqlCommand command = new SqlCommand(delete, connection))
                {
                    command.Parameters.AddWithValue("@ClubName", clubName);

                    return command.ExecuteNonQuery();
                }
                //connection.Close(); // <== niet nodig door using! (gebeurt automatisch)
            }
        }

        public static int UpdateCapacityById(int id, int capacity)
        {
            // Deel 3
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string update = "UPDATE FootballClubs SET Capacity = @Capacity WHERE ClubId = @ClubId";
                using (SqlCommand command = new SqlCommand(update, connection))
                {
                    command.Parameters.AddWithValue("@Capacity", capacity);
                    command.Parameters.AddWithValue("@ClubId", id);

                    return command.ExecuteNonQuery();
                }
                //connection.Close(); // <== niet nodig door using! (gebeurt automatisch)
            }
        }

        public static List<FootballClub> GetAllClubs()
        {
            List<FootballClub> clubs = new List<FootballClub>();
            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string select = "SELECT * FROM FootballClubs";
                using(SqlCommand command = new SqlCommand(select, connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            FootballClub club = new FootballClub()
                            {
                                ClubId = reader.GetInt32(0),
                                ClubName = reader.GetString(1),
                                Country = reader["Country"].ToString(),
                                FoundedYear = (int)reader[3],
                                StadiumName = (string)reader.GetValue(4),
                                Capacity = reader.GetInt32(5)
                            };
                            clubs.Add(club);
                        }
                    }
                }
            }
            return clubs;
        }
    }
}
