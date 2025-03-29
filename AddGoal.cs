using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddGoal : Form
    {
        public AddGoal()
        {
            FormStyle.FadeIn(this);
            InitializeComponent();
            FormStyle.ButtonStyle(btBack);
            FormStyle.ButtonStyle(btAddCardio);
            FormStyle.ButtonStyle(btAddLifting);
            FormStyle.ApplyGradient(this, Color.DarkBlue, Color.LightBlue);
            gbLifting.Enabled = false;
            gbCardio.Enabled = false;
        }

        private async void btAddLifting_Click(object sender, EventArgs e)
        {
            await AddLiftingGoal();
        }
    

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbType.SelectedItem)
            {
                case "Lifting goal":
                    gbLifting.Enabled = true;
                    gbCardio.Enabled = false;
                    break;
                case "Cardio goal": 
                    gbLifting.Enabled = false;
                    gbCardio.Enabled = true;
                    break;
            }

        }

        private async void btAddCardio_Click(object sender, EventArgs e)
        {
            await AddCardioGoal();
        }

        private async Task AddLiftingGoal()
        {
            if (!ValidateInputs()) return;

            AddGoalClass liftingGoal = new AddGoalClass(cbLiftingType.Text, Convert.ToInt32(tbLiftingParam.Text));

            using (var connection = new SQLiteConnection("Data Source=C:\\Users\\artem\\OneDrive\\Desktop\\rubbish\\Project\\HealthTracker.db;Version=3;"))
            {
                try
                {
                    await connection.OpenAsync();
                    string query = $"INSERT INTO {LogIn.userName}_Goals (firstParam, secondParam, type) VALUES (@firstParam, @secondParam, @type)";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@firstParam", liftingGoal.firstParam);
                        cmd.Parameters.AddWithValue("@secondParam", liftingGoal.secondParam);
                        cmd.Parameters.AddWithValue("@type", "Lifting");

                        await cmd.ExecuteNonQueryAsync();
                    }

                    MessageBox.Show("New lifting goal added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task AddCardioGoal()
        {
            if (!ValidateInputs()) return;

            AddGoalClass cardioGoal = new AddGoalClass(cbCardioType.Text, Convert.ToInt32(tbCardioParam.Text));

            using (var connection = new SQLiteConnection("Data Source=C:\\Users\\artem\\OneDrive\\Desktop\\rubbish\\Project\\HealthTracker.db;Version=3;"))
            {
                try
                {
                    await connection.OpenAsync();
                    string query = $"INSERT INTO {LogIn.userName}_Goals (firstParam, secondParam, type) VALUES (@firstParam, @secondParam, @type)";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@firstParam", cardioGoal.firstParam);
                        cmd.Parameters.AddWithValue("@secondParam", cardioGoal.secondParam);
                        cmd.Parameters.AddWithValue("@type", "Cardio");

                        await cmd.ExecuteNonQueryAsync();
                    }

                    MessageBox.Show("New cardio goal added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool ValidateInputs()
        {
            if (cbType.SelectedItem == null)
            {
                MessageBox.Show("Please select a goal type (Lifting or Cardio).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbType.SelectedItem.ToString() == "Lifting goal")
            {
                if (string.IsNullOrWhiteSpace(cbLiftingType.Text))
                {
                    MessageBox.Show("Please select the lifting type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(tbLiftingParam.Text) || !int.TryParse(tbLiftingParam.Text, out _))
                {
                    MessageBox.Show("Please enter a valid lifting parameter (weight).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            else if (cbType.SelectedItem.ToString() == "Cardio goal")
            {
                if (string.IsNullOrWhiteSpace(cbCardioType.Text))
                {
                    MessageBox.Show("Please select the cardio type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(tbCardioParam.Text) || !int.TryParse(tbCardioParam.Text, out _))
                {
                    MessageBox.Show("Please enter a valid cardio parameter (distance or time).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            FormStyle.FadeOut(this);
            this.Hide();
            Menu form = new Menu();
            form.ShowDialog();
            this.Close();
        }
    }
}

