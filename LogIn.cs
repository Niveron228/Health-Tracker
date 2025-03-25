using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class LogIn : Form
    {


        public static string userName = "";
        private string connectionString = "Data Source=C:\\Users\\artem\\OneDrive\\Desktop\\rubbish\\Project\\HealthTracker.db;Version=3;";
        private int incorrectPasswordCounter=1;
        public LogIn()
        {
            FormStyle.FadeIn(this);
            InitializeComponent();
            FormStyle.ButtonStyle(btLogin);
            FormStyle.ButtonStyle(btExit);
            FormStyle.ApplyGradient(this, Color.DarkBlue, Color.LightBlue);
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            FormStyle.FadeOut(this);
            this.Hide();
            Register form5 = new Register();
            form5.ShowDialog();
            this.Close();
        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            await userLogin();
        }

        private async Task userLogin()
        {
            string login = tblogin.Text;
            string password = tbpassword.Text;

            userName = login;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Fill in all fields!");
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();
                string query = "SELECT Password FROM UserInfo WHERE UserName = @Username";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", login);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string storedHash = result.ToString();
                        string enteredHash = HashPassword(password);

                        if (storedHash == enteredHash)
                        {
                            this.Hide();
                            Menu form2 = new Menu();
                            form2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            if (incorrectPasswordCounter < 5)
                            {
                                MessageBox.Show($"Incorrect password! {incorrectPasswordCounter}/5");
                                incorrectPasswordCounter++;
                            }
                            else
                            {
                                MessageBox.Show("Access denied! Try again later.");
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("User does not exist!");
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

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbpassword.PasswordChar = '\0';
            }

            else
            {
                tbpassword.PasswordChar = '*';
            }
        }

    }
}

    
    

