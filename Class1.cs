using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AMS
{


    public static class CardCheck
    {
        public static void CreateLogEntriesTable()
        {
            using (var connection = new SQLiteConnection("Data Source=cardcheck.db;Version=3;"))
            {
                connection.Open();
                string createTableSql = @"
                CREATE TABLE IF NOT EXISTS LogEntries (
                    unique_id INTEGER PRIMARY KEY AUTOINCREMENT,
                    card_id TEXT NOT NULL,
                    room_id TEXT NOT NULL,
                    user TEXT NOT NULL,
                    todays_date TEXT NOT NULL,
                    from_date TEXT NOT NULL,
                    to_date TEXT NOT NULL
                );";
                using (var command = new SQLiteCommand(createTableSql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Inserts a new log entry into the LogEntries table.
        /// Assumes the table has columns: unique_id (INTEGER PRIMARY KEY AUTOINCREMENT),
        /// card_id, user, todays_date, from_date, to_date.
        /// </summary>
        /// <param name="connectionString">The SQLite connection string (e.g., "Data Source=log.db;Version=3;").</param>
        /// <param name="cardId">The identifier for the room (or card).</param>
        /// <param name="user">The user associated with the log entry.</param>
        /// <param name="todaysDate">The current date.</param>
        /// <param name="fromDate">The start date for the log entry.</param>
        /// <param name="toDate">The end date for the log entry.</param>
        public static void AddLogEntry(string cardId, string roomId, string user, DateTime fromDate, DateTime toDate)
        {
            using (var connection = new SQLiteConnection("Data Source=cardcheck.db;Version=3;"))
            {
                connection.Open();
                string insertQuery = @"
                INSERT INTO LogEntries (card_id, room_id, user, todays_date, from_date, to_date)
                VALUES (@card_id, @room_id, @user, @todays_date, @from_date, @to_date)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@card_id", cardId);
                    command.Parameters.AddWithValue("@room_id", roomId);
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@todays_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@from_date", fromDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@to_date", toDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Retrieves up to five most recent log entries (ordered by unique_id descending)
        /// for the given card (room). Returns a list of tuples containing:
        /// (unique_id, card_id, user, todays_date, from_date, to_date).
        /// </summary>
        /// <param name="connectionString">The SQLite connection string.</param>
        /// <param name="cardId">The card (or room) identifier to filter by.</param>
        /// <returns>A list of tuples representing log entries.</returns>
        public static List<(int unique_id, string card_id, string room_id, string user, DateTime todays_date, DateTime from_date, DateTime to_date)>
            GetRecentLogEntries(string cardId)
        {
            var entries = new List<(int, string, string, string, DateTime, DateTime, DateTime)>();
            using (var connection = new SQLiteConnection("Data Source=cardcheck.db;Version=3;"))
            {
                connection.Open();
                string selectQuery = @"
                SELECT unique_id, card_id, room_id, user, todays_date, from_date, to_date
                FROM LogEntries
                WHERE card_id = @card_id
                ORDER BY todays_date DESC
                LIMIT 5";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@card_id", cardId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int uniqueId = Convert.ToInt32(reader["unique_id"]);
                            string cId = reader["card_id"].ToString();
                            string rId = reader["room_id"].ToString();
                            string usr = reader["user"].ToString();
                            DateTime todays = DateTime.Parse(reader["todays_date"].ToString());
                            DateTime from = DateTime.Parse(reader["from_date"].ToString());
                            DateTime to = DateTime.Parse(reader["to_date"].ToString());
                            entries.Add((uniqueId, cId, rId, usr, todays, from, to));
                        }
                    }
                }
            }
            return entries;
        }

        public static List<(int unique_id, string card_id, string room_id, string user, DateTime todays_date, DateTime from_date, DateTime to_date)>
            GetRecentLogEntriesByRoomId(string roomId)
        {
            var entries = new List<(int, string, string, string, DateTime, DateTime, DateTime)>();
            using (var connection = new SQLiteConnection("Data Source=cardcheck.db;Version=3;"))
            {
                connection.Open();
                string selectQuery = @"
                SELECT unique_id, card_id, room_id, user, todays_date, from_date, to_date
                FROM LogEntries
                WHERE room_id = @room_id
                ORDER BY todays_date DESC
                LIMIT 5";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@room_id", roomId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int uniqueId = Convert.ToInt32(reader["unique_id"]);
                            string cId = reader["card_id"].ToString();
                            string rId = reader["room_id"].ToString();
                            string usr = reader["user"].ToString();
                            DateTime todays = DateTime.Parse(reader["todays_date"].ToString());
                            DateTime from = DateTime.Parse(reader["from_date"].ToString());
                            DateTime to = DateTime.Parse(reader["to_date"].ToString());
                            entries.Add((uniqueId, cId, rId, usr, todays, from, to));
                        }
                    }
                }
            }
            return entries;
        }
    }

}
