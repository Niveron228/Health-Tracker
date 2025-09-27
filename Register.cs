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

            if (password.Length < 6)
            {
                MessageBox.Show("Password length must be more than 6 symbols!");
                tbpassword.Text = null;
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Incorrect email format!");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(DataBase.connectionString))
            {
                try
                {
                    await conn.OpenAsync();

                    string checkQuery = "SELECT COUNT(*) FROM UserInfo WHERE UserName = @UserName";
                    using (SQLiteCommand cmd = new SQLiteCommand(checkQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", login);
                        long count = (long)await cmd.ExecuteScalarAsync();

                        if (count > 0)
                        {
                            MessageBox.Show("Account with this login already exist!");
                            return;
                        }
                    }

                    string hashedPassword = DataBase.HashPassword(password);
                    string insertQuery = "INSERT INTO UserInfo (UserName, Password, Email) VALUES (@UserName, @Password, @Email)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", login);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@Email", email);

                        await cmd.ExecuteNonQueryAsync();
                        MessageBox.Show("Account created!");

                        DataBase.CreateUserTable(login);

                        btBack_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка: " + ex.Message);
                }
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
