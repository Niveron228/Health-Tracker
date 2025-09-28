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

        public ToolTip tooltip = new ToolTip();
        public AddInfo()
        {
            FormStyle.FadeIn(this);
            InitializeComponent();
            cbexercise.SelectedItem = "Biceps";
            FormStyle.ApplyGradient(this, Color.DarkBlue, Color.LightBlue);
            FormStyle.ButtonStyle(btsend);
            FormStyle.ButtonStyle(btexit);
            FormStyle.ButtonStyle(btback);
            lblmuscle.Visible = false;
            cbmuscle.Visible = false;
            groupBox1.Enabled = false;
            tbdate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            tooltip = new ToolTip();
            tooltip.IsBalloon = true;
            tooltip.ToolTipIcon = ToolTipIcon.Warning;
            tooltip.ToolTipTitle = "Input required";



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
            tbdate.Text = DateTime.Now.ToString("yyyy-MM-dd");

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
                    groupBox1.Enabled = true;
                    lblmodeinfo01.Text = "Type of cardio:";
                    lblmodeinfo02.Text = "Duration:";
                    lblmodeinfo03.Text = "Distance:";
                    lblmodeinfo04.Text = "Calories burned:";
                    lblmode.Text = "Cardio";
                    break;

                case "Lifting":
                    groupBox1.Enabled = false;
                    lblmuscle.Visible = true;
                    cbmuscle.Visible = true;
                    liftingExercise();
                    lblmode.Text = "Muscle";
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

        private ToolTip tbDateTip = new ToolTip();
        private ToolTip tbWeightTip = new ToolTip();
        private ToolTip tbInfo01Tip = new ToolTip();
        private ToolTip tbInfo02Tip = new ToolTip();
        private ToolTip tbInfo03Tip = new ToolTip();
        private ToolTip tbInfo04Tip = new ToolTip();


        private async void addExercise()
        {
            var fields = new Dictionary<TextBox, string>
    {
        { tbdate, "Enter date!" },
        { tbweight, "Enter weight!" },
        { tbinfo01, "Enter value!" },
        { tbinfo02, "Enter value!" },
        { tbinfo03, "Enter value!" },
        { tbinfo04, "Enter value!" }
    };

            bool hasEmptyField = false;

            foreach (var kvp in fields)
            {
                if (string.IsNullOrWhiteSpace(kvp.Key.Text))
                {
                    ToolTip tip = new ToolTip();
                    tip.IsBalloon = true;
                    tip.ToolTipIcon = ToolTipIcon.Warning;
                    tip.ToolTipTitle = "Input required";
                    tip.Show(kvp.Value, kvp.Key, kvp.Key.Width - 20, -55, 4000);
                    hasEmptyField = true;
                }
            }

            if (hasEmptyField) return;

            if (!DateTime.TryParse(tbdate.Text, out DateTime date))
            {
                ToolTip tip = new ToolTip();
                tip.IsBalloon = true;
                tip.ToolTipIcon = ToolTipIcon.Warning;
                tip.ToolTipTitle = "Input required";
                tip.Show("Enter a valid date!", tbdate, tbdate.Width + 110, -65, 4000);
                return;
            }

            if (!double.TryParse(tbweight.Text, out double parsedWeight) ||
                !double.TryParse(tbinfo02.Text, out double parsedInfo02) ||
                !double.TryParse(tbinfo03.Text, out double parsedInfo03) ||
                !double.TryParse(tbinfo04.Text, out double parsedInfo04))
            {
                MessageBox.Show("Incorrect numeric parameters!");
                return;
            }

            string info01 = tbinfo01.Text;
            string muscle = lblmode.Text;

            if (cbexercise.SelectedItem?.ToString() == "Cardio")
            {
                CardioExercise cardio = new CardioExercise(date, parsedWeight, info01, parsedInfo02, parsedInfo03, parsedInfo04);
                await SaveCardioExerciseToDatabase(cardio);
            }
            else
            {
                if (!int.TryParse(info01, out int parsedInfo01))
                {
                    MessageBox.Show("For Lifting exercises, working weight must be numeric!");
                    return;
                }
                LiftingExercise lifting = new LiftingExercise(date, parsedWeight, parsedInfo01, parsedInfo02, parsedInfo03, parsedInfo04, muscle);
                await SaveLiftingExerciseToDatabase(lifting);
            }
        }







        private async Task SaveCardioExerciseToDatabase(CardioExercise cardio)
        {
            using (var connection = new SQLiteConnection(DataBase.connectionString))
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
            using (var connection = new SQLiteConnection(DataBase.connectionString))
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

        private void cbmuscle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmuscle.SelectedItem == null)
            {
                return;
            }

            switch (cbmuscle.SelectedItem.ToString())
            {
                case "Biceps":
                    lblmode.Text = "Biceps";
                    groupBox1.Enabled = true;
                    break;

                case "Triceps":
                    lblmode.Text = "Triceps";
                    groupBox1.Enabled = true;
                    break;

                case "Shoulders":
                    lblmode.Text = "Shoulders";
                    groupBox1.Enabled = true;
                    break;

                case "Back":
                    lblmode.Text = "Back";
                    groupBox1.Enabled = true;
                    break;

                case "Chest":
                    lblmode.Text = "Chest";
                    groupBox1.Enabled = true;
                    break;
            }
        }
    }
}

