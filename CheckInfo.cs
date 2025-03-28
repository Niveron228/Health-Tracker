using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;


namespace Project
{
    public partial class CheckInfo : Form
    {
        public CheckInfo()
        {
            FormStyle.FadeIn(this);
            InitializeComponent();
            dataGridStyle();
            FormStyle.ButtonStyle(btExit);
            FormStyle.ButtonStyle(btBack);
            Load += async (sender, e) =>
            {
                await LoadLiftingData();
                await LoadCardioData();
                ChartForLifting();
                ChartForCardio();
            };
            FormStyle.ApplyGradient(this, Color.DarkBlue, Color.LightBlue);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            FormStyle.FadeOut(this);
            this.Hide();
            Menu form2 = new Menu();
            form2.ShowDialog();
            this.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            FormStyle.FadeOut(this);
            this.Close();
        }

        private void CheckInfo_Load(object sender, EventArgs e)
        {
            FormStyle.FadeIn(this);
        }

        private async Task LoadData(string tableName, DataGridView gridView)
        {
            using (var connection = new SQLiteConnection("Data Source=C:\\Users\\artem\\OneDrive\\Desktop\\rubbish\\Project\\HealthTracker.db;Version=3;"))
            {
                await connection.OpenAsync();

                string query = $"SELECT * FROM {LogIn.userName}_{tableName} ORDER BY DATE";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync()) 
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        gridView.DataSource = dt;
                    }
                }
            }
        }

        private async Task LoadCardioData()
        {
            await LoadData("Cardio", dataGridView1);
        }

        private async Task LoadLiftingData()
        {
            await LoadData("Lifting", dataGridView2);
        }

        private void dataGridStyle()
        {
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


            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void clearLabel(Label label)
        {
            label.Text = "";
        }

        private void ChartForLifting()
        {
            chart2.Series.Clear();
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM";
            chart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;

            var series = new Series("Max Weigh")
            {
                ChartType = SeriesChartType.Line,  
                BorderWidth = 3,                 
                Color = Color.Blue             
            };
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            series.Color = Color.Blue;

            var series02 = new Series("Work Weight")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.Black
            };

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["Date"].Value != null && row.Cells["MaxWeight"].Value != null)
                {
                    DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);
                    double maxWeight = Convert.ToDouble(row.Cells["MaxWeight"].Value);
                    series.Points.AddXY(date, maxWeight);
                }
                if (row.Cells["Date"].Value != null && row.Cells["WorkWeight"].Value!= null)
                {
                    DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);
                    double workWeight = Convert.ToDouble(row.Cells["WorkWeight"].Value);
                    series02.Points.AddXY(date, workWeight);
                }
            }

            chart2.Series.Add(series);
            chart2.Series.Add(series02);
        }

        private void ChartForCardio()
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;

            var series = new Series("Distance")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.Blue
            };
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            series.Color = Color.Blue;

            var series02 = new Series("Duration")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.Blue
            };
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            series.Color = Color.Black;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Date"].Value != null && row.Cells["Distance"].Value != null)
                {
                    DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);
                    double distance = Convert.ToDouble(row.Cells["Distance"].Value);
                    series.Points.AddXY(date, distance);
                }
                if (row.Cells["Date"].Value != null && row.Cells["Duration"].Value != null)
                {
                    DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);
                    double caloriesBurned = Convert.ToDouble(row.Cells["Duration"].Value);
                    series02.Points.AddXY(date, caloriesBurned);
                }
            }

            chart1.Series.Add(series);
            chart1.Series.Add(series02);
        }
    }
}
