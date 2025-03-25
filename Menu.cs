using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project
{
    public partial class Menu : Form
    {

        public Menu()
        {
            FormStyle.FadeIn(this);
            InitializeComponent();
            FormStyle.ButtonStyle(btShowProgress);
            FormStyle.ButtonStyle(btAddInfo);
            FormStyle.ButtonStyle(btExit);
            FormStyle.ApplyGradient(this, Color.DarkBlue, Color.LightBlue);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            FormStyle.FadeOut(this);
            this.Close();
        }

        private void btAddInfo_Click(object sender, EventArgs e)
        {
            FormStyle.FadeOut(this);
            this.Hide();
            AddInfo form1 = new AddInfo();
            form1.ShowDialog();
            this.Close();

        }

        private void btShowProgress_Click(object sender, EventArgs e)
        {
            FormStyle.FadeOut(this);
            this.Hide();
            CheckInfo form3 = new CheckInfo();
            form3.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            FormStyle.FadeIn(this);
        }

    }
}
