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
using System.Windows.Forms.DataVisualization.Charting;

namespace Project
{
    public partial class CheckGoals : Form
    {
        public CheckGoals()
        {
            FormStyle.FadeIn(this);
            InitializeComponent();
            FormStyle.ApplyGradient(this, Color.DarkBlue, Color.LightBlue);
            FormStyle.ButtonStyle(btBack);
            chbDelete.Visible = false;
            lblComplete.Visible = false;
            pbComplete.Visible = false;
            Load += async (sender, e) =>
            {
                await checkGoals();
            };
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridStyle();

        }


        private async Task checkGoals()
        {
            using (var connection = new SQLiteConnection("Data Source=C:\\Users\\artem\\OneDrive\\Desktop\\rubbish\\Project\\HealthTracker.db;Version=3;"))
            {
                await connection.OpenAsync();

                string query = $"SELECT * FROM {LogIn.userName}_Goals";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private async Task deleteGoalFromTable(int selectedGoalId)
        {
            using (var connection = new SQLiteConnection("Data Source=C:\\Users\\artem\\OneDrive\\Desktop\\rubbish\\Project\\HealthTracker.db;Version=3;"))
            {
                await connection.OpenAsync();

                string query = $"DELETE FROM {LogIn.userName}_Goals WHERE id = @goalId";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@goalId", selectedGoalId);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            chbDelete.Checked = false;
        }

        private async void chbDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedGoalId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                await deleteGoalFromTable(selectedGoalId);
                await checkGoals();
                lblComplete.Visible = false;
                chbDelete.Visible = false;
                pbComplete.Visible = false;
            }
        }


        private async Task<int> searchMaxGoal(string columnName, string tableName)
        {
            using (var connection = new SQLiteConnection("Data Source=C:\\Users\\artem\\OneDrive\\Desktop\\rubbish\\Project\\HealthTracker.db;Version=3;"))
            {
                await connection.OpenAsync();

                string query = $"SELECT MAX({columnName}) FROM {tableName}";

                using (var command = new SQLiteCommand(query, connection))
                {
                    object result = await command.ExecuteScalarAsync();
                    if (result != null && int.TryParse(result.ToString(), out int value))
                    {
                        return value;
                    }
                    return 0;
                }
            }
        }

        private async void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string param = (dataGridView1.SelectedRows[0].Cells[1].Value).ToString();

                switch (param) 
                {
                    case "Work weight":
                        await checkWorkWeight();
                        break;

                    case "Max weight":
                        await checkMaxWeight();
                        break;

                    case "Duration":
                        await checkDuration();
                        break;

                    case "Distance":
                        await checkDistance();
                        break;

                    case "Callories burned":
                        await checkCaloriesBurned();
                        break;
                }

                      
            }
        }

        private async Task checkWorkWeight()
        {
            chbDelete.Visible = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lblComplete.Visible = true;
                pbComplete.Visible = true;
                string param = (dataGridView1.SelectedRows[0].Cells[1].Value).ToString();
                int goal = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                string type = (dataGridView1.SelectedRows[0].Cells[3].Value).ToString();

                int workWeight = await searchMaxGoal("WorkWeight", $"{LogIn.userName}_Lifting");

                int barValue = (workWeight * 100) / goal;

                await Task.Delay(100);

                if (barValue >= 100)
                {
                    pbComplete.Value = 100;
                }
                else if (barValue > 0)
                {
                    pbComplete.Value = barValue;
                }
                else
                {
                    pbComplete.Value = 0;
                }



                lblComplete.Text = $"Completed {pbComplete.Value} %";

                if(pbComplete.Value == 100)
                {
                    chbDelete.Visible = true;
                }
            }
        }

        private async Task checkMaxWeight()
        {
            chbDelete.Visible = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lblComplete.Visible = true;
                pbComplete.Visible = true;
                string param = (dataGridView1.SelectedRows[0].Cells[1].Value).ToString();
                int goal = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                string type = (dataGridView1.SelectedRows[0].Cells[3].Value).ToString();

                int maxWeight = await searchMaxGoal("MaxWeight", $"{LogIn.userName}_Lifting");

                int barValue = (maxWeight * 100) / goal;

                await Task.Delay(100);

                if (barValue >= 100)
                {
                    pbComplete.Value = 100;
                }
                else if (barValue > 0)
                {
                    pbComplete.Value = barValue;
                }
                else
                {
                    pbComplete.Value = 0;
                }



                lblComplete.Text = $"Completed {pbComplete.Value} %";

                if (pbComplete.Value == 100)
                {
                    chbDelete.Visible = true;
                }
            }
        }

        private async Task checkDuration()
        {
            chbDelete.Visible = false;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                lblComplete.Visible = true;
                pbComplete.Visible = true;
                string param = (dataGridView1.SelectedRows[0].Cells[1].Value).ToString();
                int goal = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                string type = (dataGridView1.SelectedRows[0].Cells[3].Value).ToString();

                int duration = await searchMaxGoal("Duration", $"{LogIn.userName}_Cardio");


                int barValue = (duration * 100) / goal;

                await Task.Delay(100);

                if (barValue >= 100)
                {
                    pbComplete.Value = 100;
                }
                else if (barValue > 0)
                {
                    pbComplete.Value = barValue;
                }
                else
                {
                    pbComplete.Value = 0;
                }


                lblComplete.Text = $"Completed {pbComplete.Value} %";


                if (pbComplete.Value == 100)
                {
                    chbDelete.Visible = true;
                }
            }
        }

        private async Task checkDistance()
        {
            chbDelete.Visible = false;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                lblComplete.Visible = true;
                pbComplete.Visible = true;
                string param = (dataGridView1.SelectedRows[0].Cells[1].Value).ToString();
                int goal = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                string type = (dataGridView1.SelectedRows[0].Cells[3].Value).ToString();

                int distance = await searchMaxGoal("Distance", $"{LogIn.userName}_Cardio");


                int barValue = (distance * 100) / goal;

                await Task.Delay(100);

                if (barValue >= 100)
                {
                    pbComplete.Value = 100;
                }
                else if (barValue > 0)
                {
                    pbComplete.Value = barValue;
                }
                else
                {
                    pbComplete.Value = 0;
                }


                lblComplete.Text = $"Completed {pbComplete.Value} %";

                if (pbComplete.Value == 100)
                {
                    chbDelete.Visible = true;
                }
            }
        }

        private async Task checkCaloriesBurned()
        {
            chbDelete.Visible = false;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                lblComplete.Visible = true;
                pbComplete.Visible = true;
                string param = (dataGridView1.SelectedRows[0].Cells[1].Value).ToString();
                int goal = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                string type = (dataGridView1.SelectedRows[0].Cells[3].Value).ToString();

                int caloriesBurned = await searchMaxGoal("CaloriesBurned", $"{LogIn.userName}_Cardio");


                int barValue = (caloriesBurned * 100) / goal;

                await Task.Delay(100);

                if (barValue >= 100)
                {
                    pbComplete.Value = 100;
                }
                else if (barValue > 0)
                {
                    pbComplete.Value = barValue;
                }
                else
                {
                    pbComplete.Value = 0;
                }


                lblComplete.Text = $"Completed {pbComplete.Value} %";


                if (pbComplete.Value == 100)
                {
                    chbDelete.Visible = true;
                }
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.ShowDialog();
            this.Close();
        }

        private void dataGridStyle()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
