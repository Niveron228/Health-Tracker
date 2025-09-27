using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    static class DataBase
    {

        public static string connectionString = "Data Source=C:\\Users\\artem\\OneDrive\\Desktop\\rubbish\\Project\\HealthTracker.db;Version=3;";
        public static void CreateUserTable(string userName)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string tableQuery = $@"
                CREATE TABLE IF NOT EXISTS {userName}_Cardio (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Date DATE,
                    Weight NUMERIC,
                    CardioType VARCHAR,
                    Duration NUMERIC,
                    Distance NUMERIC,
                    CaloriesBurned NUMERIC
                );
                CREATE TABLE IF NOT EXISTS {userName}_Lifting (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Date DATE,
                    Weight NUMERIC,
                    WorkWeight NUMERIC,
                    MaxWeight NUMERIC,
                    Reps NUMERIC,
                    RestTime NUMERIC,
                    Muscle TEXT
                );
                CREATE TABLE IF NOT EXISTS {userName}_Goals (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    type TEXT,
                    goal TEXT,
                    parameter NUMERIC
                );";

                        using (SQLiteCommand cmd = new SQLiteCommand(tableQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error creating tables: {ex.Message}");
                    }
                }
            }
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }



    }
}
