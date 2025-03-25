using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Register : Form
    {
        private string connectionString = "Data Source=C:\\Users\\artem\\OneDrive\\Desktop\\rubbish\\Project\\HealthTracker.db;Version=3;";
        public Register()
        {
            FormStyle.FadeIn(this);
            InitializeComponent();
            FormStyle.ButtonStyle(btRegister);
            FormStyle.ButtonStyle(btBack);
            FormStyle.ButtonStyle(btExit);
            FormStyle.ApplyGradient(this, Color.DarkBlue, Color.LightBlue);
        }

        private async void btRegister_Click(object sender, EventArgs e)
        {
            string login = tblogin.Text;
            string password = tbpassword.Text;
            string email = tbemail.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Fill in all fields!");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format!");
                return;
            }

            string hashedPassword = HashPassword(password);

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();
                string query = "INSERT INTO UserInfo (UserName, Password, Email) VALUES (@UserName, @Password, @Email)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", login);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account created successfully!");

                       
                        CreateUserTable(login);
                        btBack_Click(sender, e);
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Error: user already exists." + ex.Message);
                    }
                }
            }
        }

        private void CreateUserTable(string userName)
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
                    CardioType NUMERIC,
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

        private string HashPassword(string password)
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

        private void btBack_Click(object sender, EventArgs e)
        {
            FormStyle.FadeOut(this);
            this.Hide();
            LogIn form4 = new LogIn();
            form4.ShowDialog();
            this.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            FormStyle.FadeOut(this);
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            var emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailRegex);
        }
    }
}
