using Project.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project
{
    public partial class AddInfo : Form
    {
        public AddInfo()
        {
            FormStyle.FadeIn(this);
            InitializeComponent();
            groupBox1.Visible = false;
            FormStyle.ApplyGradient(this, Color.DarkBlue, Color.LightBlue);
            FormStyle.ButtonStyle(btsend);
            FormStyle.ButtonStyle(btexit);
            FormStyle.ButtonStyle(btback);
        }

        private void btsend_Click(object sender, EventArgs e)
        {
            addExercise();
            tbdate.Text = "";
            tbweight.Text = "";
            tbinfo01.Text = "";
            tbinfo02.Text = "";
            tbinfo03.Text = "";
            tbinfo04.Text = "";
            cbexercise.SelectedIndex = -1;

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            FormStyle.FadeOut(this);
            this.Close();
        }

        private void exerciseMode()
        {
            if (cbexercise.SelectedItem == null)
            {
                return;
            }

            switch (cbexercise.SelectedItem.ToString())
            {
                case "Cardio":
                    lblmodeinfo01.Text = "Type of cardio:";
                    lblmodeinfo02.Text = "Duration:";
                    lblmodeinfo03.Text = "Distance:";
                    lblmodeinfo04.Text = "Calories burned:";
                    groupBox1.Visible = true;
                    lblmode.Text = "Cardio";
                    break;

                case "Biceps":
                    groupBox1.Visible = true;
                    liftingExercise();
                    lblmode.Text = "Biceps";
                    break;

                case "Triceps":
                    groupBox1.Visible = true;
                    liftingExercise();
                    lblmode.Text = "Triceps";
                    break;

                case "Chest":
                    groupBox1.Visible = true;
                    liftingExercise();
                    lblmode.Text = "Chest";
                    break;

                case "Back":
                    groupBox1.Visible = true;
                    liftingExercise();
                    lblmode.Text = "Back";
                    break;

                case "Shoulders":
                    groupBox1.Visible = true;
                    liftingExercise();
                    lblmode.Text = "Shoulders";
                    break;

                default:
                    lblmodeinfo01.Text = "";
                    lblmodeinfo02.Text = "";
                    lblmodeinfo03.Text = "";
                    lblmodeinfo04.Text = "";
                    break;

            }

        void liftingExercise()
            {
                lblmodeinfo01.Text = "Working weight:";
                lblmodeinfo02.Text = "Max weight:";
                lblmodeinfo03.Text = "Repeats:";
                lblmodeinfo04.Text = "Rest time:";
            }
        }

        private void cbexercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            exerciseMode();
        }

        private async void addExercise()
        {
            DateTime date;
            if (!DateTime.TryParse(tbdate.Text, out date) || string.IsNullOrWhiteSpace(tbweight.Text) ||
                string.IsNullOrWhiteSpace(tbinfo01.Text) || string.IsNullOrWhiteSpace(tbinfo02.Text) ||
                string.IsNullOrWhiteSpace(tbinfo03.Text) || string.IsNullOrWhiteSpace(tbinfo04.Text))
            {
                MessageBox.Show("Please, enter all parameters!");
                return;
            }

            string weight = tbweight.Text;
            string info01 = tbinfo01.Text;
            string info02 = tbinfo02.Text;
            string info03 = tbinfo03.Text;
            string info04 = tbinfo04.Text;
            string muscle = lblmode.Text;


            if (!double.TryParse(weight, out double parsedWeight) ||
                !double.TryParse(info02, out double parsedInfo02) ||
                !double.TryParse(info03, out double parsedInfo03) ||
                !double.TryParse(info04, out double parsedInfo04))
            {
                MessageBox.Show("Incorrect parameters");
                return;
            }

            if (cbexercise.SelectedItem != null && cbexercise.SelectedItem.ToString() == "Cardio")
            {
                if (string.IsNullOrEmpty(info01))
                {
                    MessageBox.Show("For Cardio exercises, info01 must be a string value!");
                    return;
                }

                CardioExercise cardio = new CardioExercise(date, parsedWeight, info01, parsedInfo02, parsedInfo03, parsedInfo04);
                await SaveCardioExerciseToDatabase(cardio);
            }
            else
            {
                if (!int.TryParse(info01, out int parsedInfo01))
                {
                    MessageBox.Show("For other exercises, info01 must be an integer value!");
                    return;
                }

                LiftingExercise lifting = new LiftingExercise(date, parsedWeight, parsedInfo01, parsedInfo02, parsedInfo03, parsedInfo04, muscle);
                await SaveLiftingExerciseToDatabase(lifting);
            }
        }

        private async Task SaveCardioExerciseToDatabase(CardioExercise cardio)
        {
            using (var connection = new SQLiteConnection("Data Source=C:\\Users\\artem\\OneDrive\\Desktop\\rubbish\\Project\\HealthTracker.db;Version=3;"))
            {
                await connection.OpenAsync();
                string query = $"INSERT INTO {LogIn.userName}_Cardio (Date, Weight, CardioType, Duration, Distance, CaloriesBurned) " +
                               "VALUES (@Date, @Weight, @CardioType, @Duration, @Distance, @CaloriesBurned)";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Date", cardio.Date);
                    cmd.Parameters.AddWithValue("@Weight", cardio.Weight);
                    cmd.Parameters.AddWithValue("@CardioType", cardio.CardioType);
                    cmd.Parameters.AddWithValue("@Duration", cardio.Duration);
                    cmd.Parameters.AddWithValue("@Distance", cardio.Distance);
                    cmd.Parameters.AddWithValue("@CaloriesBurned", cardio.CaloriesBurned);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
            MessageBox.Show("Parameters added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task SaveLiftingExerciseToDatabase(LiftingExercise lifting)
        {
            using (var connection = new SQLiteConnection("Data Source=C:\\Users\\artem\\OneDrive\\Desktop\\rubbish\\Project\\HealthTracker.db;Version=3;"))
            {
                await connection.OpenAsync();

                string query = $"INSERT INTO {LogIn.userName}_Lifting (Date, Weight, WorkWeight, MaxWeight, Reps, RestTime, Muscle) " +
                               "VALUES (@Date, @Weight, @WorkWeight, @MaxWeight, @Reps, @RestTime, @Muscle)";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Date", lifting.Date);
                    cmd.Parameters.AddWithValue("@Weight", lifting.Weight);
                    cmd.Parameters.AddWithValue("@WorkWeight", lifting.WorkWeight);
                    cmd.Parameters.AddWithValue("@MaxWeight", lifting.MaxWeight);
                    cmd.Parameters.AddWithValue("@Reps", lifting.Reps);
                    cmd.Parameters.AddWithValue("@RestTime", lifting.Duration);
                    cmd.Parameters.AddWithValue("@Muscle", lifting.Musсle);

                    await cmd.ExecuteNonQueryAsync();
                }
            }

            MessageBox.Show("Parameters added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btback_Click(object sender, EventArgs e)
        {
            FormStyle.FadeOut(this);
            this.Hide();
            Menu form2 = new Menu();
            form2.ShowDialog();
            this.Close();
        }
    }
}
